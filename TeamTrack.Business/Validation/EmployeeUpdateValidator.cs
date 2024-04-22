﻿using TeamTrack.Common.Dtos.Address;
using FluentValidation;
using TeamTrack.Common.Dtos.Employee;

namespace TeamTrack.Business.Validation;

public class EmployeeUpdateValidator : AbstractValidator<EmployeeUpdate>
{
    public EmployeeUpdateValidator()
    {
        RuleFor(employeeUpdate => employeeUpdate.FirstName).NotEmpty().MaximumLength(50);
        RuleFor(employeeUpdate => employeeUpdate.LastName).NotEmpty().MaximumLength(50);
    }
}
