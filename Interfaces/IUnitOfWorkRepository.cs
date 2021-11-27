namespace EmployeeCapibilityDemonstration.Interfaces
{
    public interface IUnitOfWorkRepository
    {

        IEmployeeRepository Employee { get; }
        IMethodRepository Method { get; }
        ICategoryRepository Category { get; }
        void Save();
    }
}
