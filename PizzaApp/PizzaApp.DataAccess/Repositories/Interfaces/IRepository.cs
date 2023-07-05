namespace PizzaApp.DataAccess.Repositories.Interfaces
{
    using PizzaApp.Domain.Models;

    public interface IRepository<T> where T : BaseEntity
    {
        //CRUD Operations
        Task<List<T>> GetAll();

        Task<T> GetById(int id);

        Task Insert(T entity);

        Task<T> InsertAndReturn(T entity);

        Task Update(T entity);

        Task<int> DeleteById(int id);
    }
}
