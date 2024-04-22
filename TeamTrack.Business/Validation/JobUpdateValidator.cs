using TeamTrack.Common.Dtos.Address;
using TeamTrack.Common.Dtos.Employee;

using FluentValidation;
using TeamTrack.Common.Dtos.Job;

namespace TeamTrack.Business.Validation;

public class JobUpdateValidator : AbstractValidator<JobUpdate>
{
    public JobUpdateValidator()
    {
        RuleFor(jobUpdate => jobUpdate.Name).NotEmpty().MaximumLength(50);
        RuleFor(JobUpdate => JobUpdate.Description).NotEmpty().MaximumLength(250);
    }
}
