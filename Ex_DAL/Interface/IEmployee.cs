using Ex_DL;

namespace Ex_DAL.Interface
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        List<Project> GetProjects();
        Employee GetEmployee(int id);
        void Insert(Employee emp);
        void Update(Employee emp);
        void Delete(int id);
    }
}
