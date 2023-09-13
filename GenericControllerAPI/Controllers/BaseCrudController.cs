using GenericControllerAPI.DTOs;
using GenericControllerAPI.Entities;
using GenericControllerAPI.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GenericControllerAPI.Controllers
{
    [ApiController]
    public class BaseCrudController<TService,TDTO,TEntity> : ControllerBase 
        where TService : IBaseCrudService<TDTO>
        where TDTO : BaseEntityDTO
        where TEntity : BaseEntity
    {
        private readonly TService _baseCrudService;
        public BaseCrudController(TService baseCrudService)
        {
            _baseCrudService = baseCrudService;
        }

        [HttpGet]
        public async Task<List<TDTO>> Get()
        {
            return await _baseCrudService.Get();
        }

        [HttpGet("{id}")]
        public async Task<TDTO> Get(Guid id)
        {
            return await _baseCrudService.Get(id);
        }

        [HttpPost]
        public async Task Post(TDTO element)
        {
            await _baseCrudService.Post(element);
        }

        [HttpPut("{id}")]
        public async Task Put(Guid id,TDTO element)
        {
            await _baseCrudService.Put(id,element);
        }

        [HttpDelete]
        public async Task Delete(Guid id)
        {
            await _baseCrudService.Delete(id);
        }
    }
}
