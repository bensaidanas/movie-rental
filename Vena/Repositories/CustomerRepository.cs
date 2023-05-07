using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vena.Data;
using Vena.Models;

namespace Vena.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly VenaDbContext _context;

        public CustomerRepository(VenaDbContext context)
        {
            _context = context;
        }
        public void Add(Customer customer)
        {
           _context.Customers.Add(customer);
           _context.SaveChanges();
        }

        public async Task Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public Task<Customer> Find()
        {
            throw new NotImplementedException();
        }

        public MembershipType GetMembershipType(int id)
        {
            return _context.MembershipTypes.Find(id);
        }

        public async Task<IList<Customer>> List()
        {
           return await _context.Customers.Include(c => c.MembershipType).ToListAsync();
        }

        public Task Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
