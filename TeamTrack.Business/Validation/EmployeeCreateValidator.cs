using TeamTrack.Common.Dtos.Address;
using FluentValidation;
using TeamTrack.Common.Dtos.Employee;

namespace TeamTrack.Business.Validation;

public class EmployeeCreateValidator : AbstractValidator<EmployeeCreate>
{
    public EmployeeCreateValidator()
    {
        RuleFor(employeeCreate => employeeCreate.FirstName).NotEmpty().MaximumLength(50);
        RuleFor(employeeCreate => employeeCreate.LastName).NotEmpty().MaximumLength(50);
    }
}
