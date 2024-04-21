using TeamTrack.Common.Model;
using TeamTrack.Common.Dtos.Employee;

namespace TeamTrack.Common.Interfaces;

public interface IEmployeeService
{
    Task<int> CreateEmployeeAsync(EmployeeCreate employeeCreate);
    Task UpdateEmployeeAsync(EmployeeUpdate employeeUpdate);
    Task<List<EmployeeList>> GetEmployeesAsnyc(EmployeeFilter employeeFilter);
    Task<EmployeeDetails> GetEmployeeAsync(int id);
    Task DeleteEmployeeAsync(EmployeeDelete employeeDelete);
}
