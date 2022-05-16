using EmploymentData.API.Models;


namespace EmploymentData.API.Model
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        void Delete(int id);
        void Update(Employee employee);
        void Create(Employee employee);
        bool SaveChanges();
    }
}
