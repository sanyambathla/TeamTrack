
using FluentValidation;
using TeamTrack.Common.Dtos.Teams;

namespace TeamTrack.Business.Validation;

public class TeamCreateValidator : AbstractValidator<TeamCreate>
{
    public TeamCreateValidator()
    {
        RuleFor(teamCreate => teamCreate.Name).NotEmpty().MaximumLength(50);
    }
}
