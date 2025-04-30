

using DataLayer.DataAccess;
using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class ContractRepository : IContractRepository
    {
        private readonly ApplicationDbContext _context;

        public ContractRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(Contract contract)
        {await _context.AddRangeAsync(contract);
            return await _context.SaveChangesAsync() > 0;
            

            //bool success = false;

            //var strategy = _context.Database.CreateExecutionStrategy();

            //await strategy.ExecuteAsync(async () =>
            //{
            //    await using var transaction = await _context.Database.BeginTransactionAsync();
            //    try
            //    {
            //        await _context.AddAsync(contract);
            //        await _context.SaveChangesAsync();

            //        if (contract.ContractDetails != null)
            //        {
            //            foreach (var detail in contract.ContractDetails)
            //            {
            //                detail.ContractId = contract.Id;
            //                //await _context.ContractDetails.AddAsync(detail);
            //                _context.ContractDetails.Add(detail);
            //            }
            //        }

            //        await _context.SaveChangesAsync();
            //        await transaction.CommitAsync();
            //        success = true;
            //    }
            //    catch (Exception)
            //    {
            //        await transaction.RollbackAsync();
            //        throw;
            //    }
            //});

            //return success;
        }

        public async Task<List<Contract>> GetAll(string search = "")
        {
            IQueryable<Contract> query = _context.Contracts
                 .Include(c => c.Customer)
                 .Include(t => t.ContractDetails)
                     .ThenInclude(s => s.Service)
                         .ThenInclude(st => st.ServiceType)
                 .Include(t => t.ContractDetails)
                         .ThenInclude(s => s.Service)
                             .ThenInclude(ss => ss.ServiceSetting)
                 .Include(t => t.ContractDetails)
                     .ThenInclude(s => s.Service)
                         .ThenInclude(sl => sl.ServiceLocation);

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(c =>
                    c.Customer.Name.Contains(search)
                );
            }

            return await query.ToListAsync();
        }

        public Task<Contract?> GetById(int id)
        {
            return _context.Contracts
                .Include(t => t.Customer)
                .Include(l => l.ContractDetails)
                    .ThenInclude(s => s.Service)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<bool> Update(Contract contract)
        {
            _context.Update(contract);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
