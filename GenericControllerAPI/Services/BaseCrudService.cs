using AutoMapper;
using GenericControllerAPI.DTOs;
using GenericControllerAPI.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GenericControllerAPI.Services
{
    public class BaseCrudService<TGetDTO, TGetByIdDTO, TPutDTO, TPostDTO, TEntity> : IBaseCrudService<TGetDTO, TGetByIdDTO, TPutDTO, TPostDTO>
            where TGetDTO : BaseEntityDTO
            where TGetByIdDTO : BaseEntityDTO
            where TPutDTO : BaseEntityDTO
            where TPostDTO : BaseEntityDTO
            where TEntity : BaseEntity
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _db;

        public BaseCrudService(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<TGetDTO>> Get()
        {
            var result = await _db.Set<TEntity>().ToListAsync();
            return _mapper.Map<List<TGetDTO>>(result);
        }

        public async Task<TGetByIdDTO> Get(Guid id)
        {
            var result = await _db.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<TGetByIdDTO>(result);
        }

        public async Task Post(TPostDTO element)
        {
            var elementToAdd = _mapper.Map<TEntity>(element);
            await _db.Set<TEntity>().AddAsync(elementToAdd);
            await _db.SaveChangesAsync();
        }

        public async Task Put(Guid id, TPutDTO element)
        {
            var elementToUpdate = _mapper.Map<TEntity>(element);
            _db.Set<TEntity>().Update(elementToUpdate);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var element = await _db.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
            var elementToDelete = _mapper.Map<TEntity>(element);
            _db.Set<TEntity>().Remove(elementToDelete);
            await _db.SaveChangesAsync();
        }
    }
    public class BaseCrudService<TGetDTO, TEntity> : BaseCrudService<TGetDTO, TGetDTO, TGetDTO, TGetDTO, TEntity>, IBaseCrudService<TGetDTO>
          where TGetDTO : BaseEntityDTO
          where TEntity : BaseEntity
    {
        public BaseCrudService(AppDbContext db, IMapper mapper) : base(db, mapper)
        {
        }
    }
}

