using GenericControllerAPI.DTOs;
using GenericControllerAPI.Entities;

namespace GenericControllerAPI.Services
{
    public interface IBaseCrudService<TGetDTO,TGetByIdDTO,TPutDTO,TPostDTO>
            where TGetDTO : BaseEntityDTO
            where TGetByIdDTO : BaseEntityDTO
            where TPutDTO : BaseEntityDTO
            where TPostDTO : BaseEntityDTO
    {
        Task<List<TGetDTO>> Get();
        Task<TGetByIdDTO> Get(Guid id);
        Task Post(TPostDTO element);
        Task Put(Guid id, TPutDTO element);
        Task Delete(Guid id);
    }

    public interface IBaseCrudService<TGetDTO> : IBaseCrudService<TGetDTO,TGetDTO,TGetDTO,TGetDTO> where TGetDTO : BaseEntityDTO
    {
       
    }
}
