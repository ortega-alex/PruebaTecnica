
using DataLayer.Models;
using Bogus;

namespace DataLayer.Fakers
{
    public static class CustomerFaker
    {
        public static List<Customer> GenerateCustomers(int count)
        {
            var faker = new Faker<Customer>()
                .RuleFor(c => c.Name, f => f.Name.FullName())
                .RuleFor(c => c.Code, f => f.Random.AlphaNumeric(8).ToUpper())
                .RuleFor(c => c.Address, f => f.Address.FullAddress())
                .RuleFor(c => c.Email, f => f.Internet.Email())
                .RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber());
            return faker.Generate(count);
        }
    }
}
