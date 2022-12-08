using HandsOnMVCUsingEFCodeFirst_Demo2.Contracts;
using HandsOnMVCUsingEFCodeFirst_Demo2.Entties;
using HandsOnMVCUsingEFCodeFirst_Demo2.Models;

namespace HandsOnMVCUsingEFCodeFirst_Demo2.Services
{
    public class EmployeeService : IEmployeeContract
    {
        private MVCDB1128Context mVCDB1128Context;
        public EmployeeService()
        {
            mVCDB1128Context = new MVCDB1128Context();
        }
        public void AddEmployee(Employee employee)
        {
            try
            {
                mVCDB1128Context.Employees.Add(employee);
                mVCDB1128Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            try
            {
                Employee employee = mVCDB1128Context.Employees.Find(employeeId);
                mVCDB1128Context.Employees.Remove(employee);
                mVCDB1128Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditEmployee(Employee employee)
        {
            try
            {
               
                mVCDB1128Context.Employees.Update(employee);
                mVCDB1128Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Employee GetEmployee(int employeeId)
        {
            Employee employee = mVCDB1128Context.Employees.Find(employeeId);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return mVCDB1128Context.Employees.ToList();
        }
        public List<EmployeeProject> GetEmployeeProjects()
        {
            List<EmployeeProject> employeeProjects = (from e in mVCDB1128Context.Employees
                                                      join p in mVCDB1128Context.Projects
                                                      on e.ProjectCode equals p.ProjectCode
                                                      select new EmployeeProject()
                                                      {
                                                          EmployeeId=e.EmployeeId,
                                                          EmployeeName=e.EmployeeName,
                                                          ProjectCode=p.ProjectCode,
                                                          PrjoectName=p.ProjectName
                                                      }).ToList();
            return employeeProjects;
        }
    }
}
