using Ex_BAL.Interface;
using Ex_DAL.Interface;
using Ex_DL;
using System.Reflection.Metadata;

namespace Ex_BAL.Implemenatation
{
    public class EmployeBO : IEmployeeBL
    {
        private readonly IEmployee _emplpoyee;
        public EmployeBO(IEmployee employee)
        {
            _emplpoyee = employee;
        }
        public void Delete(int id)
        {
            try
            {
                _emplpoyee.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Employee GetEmployee(int id)
        {
            var obj = new Employee();
            try
            {
                obj = _emplpoyee.GetEmployee(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return obj;
        }

        public List<Employee> GetEmployees()
        {
            var oList = new List<Employee>();
            try
            {
               oList = _emplpoyee.GetEmployees();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return oList;
        }

        public void Insert(Employee emp)
        {
            try
            {
                _emplpoyee.Insert(emp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Employee emp)
        {
            try
            {
                _emplpoyee.Update(emp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
