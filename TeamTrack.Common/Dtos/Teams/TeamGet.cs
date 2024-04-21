using TeamTrack.Common.Dtos.Employee;

namespace TeamTrack.Dtos.Teams;

public record TeamGet(int Id, string Name, List<EmployeeList> Employees);