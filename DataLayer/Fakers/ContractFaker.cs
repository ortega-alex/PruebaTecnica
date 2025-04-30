

using Bogus;
using DataLayer.Models;

namespace DataLayer.Fakers
{
    public static class ContractFaker
    {
        public static List<Contract> GenerateContractForCustomer(Customer customer, int count)
        {
            var startDate = new Faker().Date.Past(1);
            var faker = new Faker<Contract>()
               .RuleFor(c => c.CustomerId, f => customer.Id)
               .RuleFor(c => c.StartDate, _ => startDate)
               .RuleFor(c => c.EndDate, f => startDate.AddMonths(f.Random.Number(1, 12)))
               .RuleFor(c => c.PayPeriod, f => "Mensual")
               .RuleFor(c => c.DisconuntPercentage, f => f.Random.Decimal(0, 10m));

            return faker.Generate(count);
        }

        public static List<ContractDetail> GenerateDetailForContractAndServices(Contract contract, Service service, int count)
        {
           
            var faker = new Faker<ContractDetail>()
              .RuleFor(c => c.ContractId, f => contract.Id)
              .RuleFor(c => c.ServiceId, f => service.Id)
              .RuleFor(c => c.Price, f => Math.Round(service.MonthyCost - ((contract.DisconuntPercentage * service.MonthyCost) / 100), 2))
              .RuleFor(c => c.DisconuntPercentage, f => contract.DisconuntPercentage)
              .RuleFor(c => c.BillingFrequency, f => contract.PayPeriod);

            return faker.Generate(count);
        }
    }
}
