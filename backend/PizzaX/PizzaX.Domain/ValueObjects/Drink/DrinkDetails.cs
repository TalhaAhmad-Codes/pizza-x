using PizzaX.Domain.Common;
using System.Text.RegularExpressions;

namespace PizzaX.Domain.ValueObjects.Drink
{
    public sealed class DrinkDetails
    {
        // Attributes
        public string Company { get; }
        public string? RetailerContactNumber { get; }

        // Constructors
        private DrinkDetails() { }
        private DrinkDetails(string company, string? reatilerContactNumber)
        {
            Guard.AgainstNullOrWhitespace(company, nameof(Company));
            RetailerContactNumber = reatilerContactNumber?.Trim();
            AgainstInvalidContactNumber(reatilerContactNumber!);

            Company = company.Trim().ToLower();
            RetailerContactNumber = reatilerContactNumber;
        }

        // Method - Create a new object
        public static DrinkDetails Create(string company, string? reatilerContactNumber)
            => new(company, reatilerContactNumber);

        // Method - Check if phone number is valid or not
        private static void AgainstInvalidContactNumber(string number)
        {
            Regex PhoneRegex = new(
                @"^\+?[1-9]\d{0,2}[\s\-\.]?\(?\d{1,4}\)?([\s\-\.]?\d){6,10}$",
                RegexOptions.Compiled
            );

            Guard.AgainstNullOrWhitespace(number, nameof(RetailerContactNumber));

            if (!PhoneRegex.IsMatch(number))
                throw new DomainException("The given contact number is not valid.");
        }

        // Method - Convert to string
        public override string ToString()
            => $"{Company} | {RetailerContactNumber}";
    }
}
