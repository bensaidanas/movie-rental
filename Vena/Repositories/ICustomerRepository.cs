using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vena.Models;

namespace Vena.Repositories
{
    public interface ICustomerRepository
    {
        Task<IList<Customer>> List();
        Task<Customer> Find();

        MembershipType GetMembershipType(int id);
        void Add(Customer customer);
        Task Update(Customer customer);
        Task Delete(Customer customer);
    }
}
