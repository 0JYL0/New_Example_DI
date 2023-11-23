using Ex_DL;

namespace Ex_DAL.Interface
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        void Insert(Employee emp);
        void Update(Employee emp);
        void Delete(int id);
    }
}
