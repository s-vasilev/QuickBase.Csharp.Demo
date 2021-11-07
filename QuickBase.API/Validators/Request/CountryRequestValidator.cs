using FluentValidation;
using QuickBase.API.ApiModels.Request;

namespace QuickBase.API.Validators.Request
{
    /// <summary>Country Request Validator.</summary>
    public class CountryRequestValidator : AbstractValidator<CountryRequest>
    {
        /// <summary>Initializes a new instance of the <see cref="CountryRequestValidator" /> class.</summary>
        public CountryRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2);
        }
    }
}
