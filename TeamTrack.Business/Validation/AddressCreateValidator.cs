using FluentValidation;
using TeamTrack.Common.Dtos.Address;

namespace TeamTrack.Business.Validation;

public class AddressCreateValidator : AbstractValidator<AddressCreate>
{
    public AddressCreateValidator()
    {
        RuleFor(addressCreate => addressCreate.Email).NotEmpty().EmailAddress().MaximumLength(100);
        RuleFor(addressCreate => addressCreate.City).NotEmpty().MaximumLength(100);
        RuleFor(addressCreate => addressCreate.Street).NotEmpty().MaximumLength(100);
        RuleFor(addressCreate => addressCreate.Zip).NotEmpty().MaximumLength(16);
        RuleFor(addressCreate => addressCreate.Phone).MaximumLength(32);
    }
}
