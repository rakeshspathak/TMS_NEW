using FluentValidation.Attributes;
using System.ComponentModel.DataAnnotations;
using TMS.Domain.Validation;

namespace TMS.Domain.Domain
{
    [Validator(typeof(ProductValidator))]
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
