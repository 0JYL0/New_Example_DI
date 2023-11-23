using Ex_DL;

namespace Ex_BAL.Interface
{
    public interface IEmployeeBL
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        void Insert(Employee emp);
        void Update(Employee emp);
        void Delete(int id);
    }
}
