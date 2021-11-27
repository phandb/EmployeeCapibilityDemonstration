namespace EmployeeCapibilityDemonstration.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        //  CRUD operations

        bool Create(T entity);
        ICollection<T> FindAll();
        T FindById(string id);
        bool Update(T entity);
        bool Delete(T entity);

        bool IsExisted(string id);

        bool Save();
    }
}
