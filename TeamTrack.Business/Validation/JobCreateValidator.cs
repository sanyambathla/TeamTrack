using TeamTrack.Common.Dtos.Address;
using FluentValidation;
using TeamTrack.Common.Dtos.Job;

namespace TeamTrack.Business.Validation;

public class JobCreateValidator : AbstractValidator<JobCreate>
{
    public JobCreateValidator()
    {
        RuleFor(jobCreate => jobCreate.Name).NotEmpty().MaximumLength(50);
        RuleFor(JobCreate => JobCreate.Description).NotEmpty().MaximumLength(250);
    }
}
