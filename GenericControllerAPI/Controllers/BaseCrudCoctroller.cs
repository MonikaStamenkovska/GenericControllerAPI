using GenericControllerAPI.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GenericControllerAPI.Controllers
{
    [ApiController]
    public class BaseCrudCoctroller<T> : ControllerBase where T : BaseEntity 
    {
        private readonly AppDbContext _db;

        public BaseCrudCoctroller(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<List<T>> Get()
        {
            return await _db.Set<T>().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<T> Get(Guid id)
        {
            return await _db.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task Post(T element)
        {
            await _db.Set<T>().AddAsync(element);
            await _db.SaveChangesAsync();
        }

        [HttpPut("{id}")]
        public async Task Put(Guid id,T element)
        {
            _db.Set<T>().Update(element);
            await _db.SaveChangesAsync();
        }

        [HttpDelete]
        public async Task Delete(Guid id)
        {
            var element = await _db.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            _db.Set<T>().Remove(element);
            await _db.SaveChangesAsync();
        }
    }
}
