
using TeamTrack.Common.Dtos.Address;
using TeamTrack.Common.Dtos.Employee;
using TeamTrack.Common.Dtos.Job;

namespace TeamTrack.Common.Dtos.Employee;

public record EmployeeDetails(int Id, string FirstName, string LastName, AddressGet Address, JobGet Job/*, List<TeamGet> Teams*/);