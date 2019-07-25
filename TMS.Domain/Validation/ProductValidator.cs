using FluentValidation;
using TMS.Domain.Domain;

namespace TMS.Domain.Validation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            Product_Name();
            Product_Description();
        }

        private void Product_Name()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Product name cannot be blank");
        }

        private void Product_Description()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Product description cannot be blank");
        }
    }
}
