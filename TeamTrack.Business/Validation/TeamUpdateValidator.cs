
using FluentValidation;
using TeamTrack.Common.Dtos.Teams;

namespace TeamTrack.Business.Validation;

public class TeamUpdateValidator : AbstractValidator<TeamUpdate>
{
    public TeamUpdateValidator()
    {
        RuleFor(teamCreate => teamCreate.Name).NotEmpty().MaximumLength(50);
    }
}
