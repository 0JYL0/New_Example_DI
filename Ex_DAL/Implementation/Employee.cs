using Ex_DAL.Interface;
using Ex_DL;

namespace Ex_DAL.Implementation
{
    public class Employee : IEmployee
    {
        private readonly CompanyDBContext _dbContext;
        public Employee(CompanyDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete(int id)
        {
            _dbContext.Remove(id);
        }

        public Ex_DL.Employee GetEmployee(int id)
        {
            return _dbContext.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
        }

        public List<Ex_DL.Employee> GetEmployees()
        {
           return _dbContext.Employees.ToList();
        }

        public void Insert(Ex_DL.Employee emp)
        {
            _dbContext.Employees.Add(emp);
            _dbContext.SaveChanges();
        }

        public void Update(Ex_DL.Employee emp)
        {
            _dbContext.Employees.Update(emp);
            _dbContext.Employees.Attach(emp);
            _dbContext.SaveChanges();
        }
    }
}
