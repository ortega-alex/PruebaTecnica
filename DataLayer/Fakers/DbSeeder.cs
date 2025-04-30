

using DataLayer.DataAccess;

namespace DataLayer.Fakers
{
    public static class DbSeeder
    {
        public static void SeedInitial(ApplicationDbContext context)
        {
            int count = 40; // configurable
            if (!context.Customers.Any())
            //if (context.Customers.Count() < 10)
            {
                var customers = CustomerFaker.GenerateCustomers(count);
                var services = ServiceFaker.GenerateServices(count);

                context.Customers.AddRange(customers);
                context.Services.AddRange(services);
                context.SaveChanges();

                for (int i = 0; i < count; i++)
                {
                    var customer = customers[i];
                    var service = services[i];

                    var contract = ContractFaker.GenerateContractForCustomer(customer, 1).First();
                    contract.CustomerId = customer.Id;

                    context.AddRange(contract);
                    context.SaveChanges();

                    var details = ContractFaker.GenerateDetailForContractAndServices(contract, service, 1);
                    context.AddRange(details);
                    context.SaveChanges();
                }
            }
        }
    }
}
