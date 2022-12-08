using HandsOnMVCUsingEFCodeFirst_Demo2.Entties;

namespace HandsOnMVCUsingEFCodeFirst_Demo2.Contracts
{
    public interface IEmployeeContract
    {
        void AddEmployee(Employee employee);
        Employee GetEmployee(int employeeId);
        List<Employee> GetEmployees();
        void DeleteEmployee(int employeeId);
        void EditEmployee(Employee employee);
    }
}
