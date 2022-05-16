using EmploymentData.API.Models;

namespace EmploymentData.API.Model
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly TimeTracker_dbContext _context;

        public EmployeeRepository(TimeTracker_dbContext context)
        {
            _context = context;
        }
        public void Create(Employee employee)
        {
            _context.Add(employee);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            return _context.Employees.FirstOrDefault(p => p.EmpId == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
