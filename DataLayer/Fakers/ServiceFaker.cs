

using Bogus;
using DataLayer.Models;

namespace DataLayer.Fakers
{
    public static class ServiceFaker
    {
        public static List<Service> GenerateServices(int count)
        {
            var fake = new Faker();
            var serviceTypeId = fake.Random.Number(1, 2); // solo hay 2 tipos de servicios
            var descripcion = serviceTypeId == 1 ? "Cable" : "Internet";
            var serviceSettingId = serviceTypeId == 1 ? fake.Random.Number(4 , 5) : fake.Random.Number(1, 3); // solo hay 5 configuraciones de servicio
            var faker = new Faker<Service>()
                .RuleFor(c => c.Description, _ => $"Servicio de {descripcion}")
                .RuleFor(c => c.MonthyCost, f => f.Finance.Amount(200, 600))
                .RuleFor(c => c.ServiceLocationId, f => f.Random.Number(1, 10)) // solo hay 10 registros
                .RuleFor(c => c.ServiceSettingId, _ => serviceSettingId)
                .RuleFor(c => c.ServiceTypeId, _ => serviceTypeId) 
                .RuleFor(c => c.Code, f => $"SRV-{f.Random.Number(1000, 9999)}");

            return faker.Generate(count);
        }
    }
}
