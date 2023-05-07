using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vena.Data;
using Vena.Models;
using Vena.Repositories;
using Vena.ViewModels;

namespace Vena.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly VenaDbContext _context;

        public CustomerService(ICustomerRepository repository, VenaDbContext context)
        {
            _repository = repository;
            _context = context;
        }
        public void Add(CustomerFormViewModel viewModel)
        {
            Customer customer = new Customer
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Birthdate = viewModel.Birthdate,
                MembershipType = _repository.GetMembershipType(viewModel.MembershipTypeId)
            };
            _repository.Add(customer);
        }

        public void Delete(CustomerFormViewModel viewModel)
        {
            Customer customer = new Customer
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                Birthdate = viewModel.Birthdate,
                Phone = viewModel.Phone,
                MembershipType = _repository.GetMembershipType(viewModel.MembershipTypeId)
            };
            _repository.Delete(customer);
        }

        public ListCustomerViewModel Find(int customerId)
        {
            throw new NotImplementedException();
        }

        public IList<ListCustomerViewModel> List()
        {
            IList<Customer> customers = _repository.List().Result;
            return BindCustomerList(customers);
        }

        private IList<ListCustomerViewModel> BindCustomerList(IList<Customer> customers)
        {
            IList<ListCustomerViewModel> customerViewModels = new List<ListCustomerViewModel>();
            foreach (Customer c in customers)
            {
                customerViewModels.Add(new ListCustomerViewModel
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    MembershipType = c.MembershipType
                });
            }
            return customerViewModels;
        }

        public void Update(ListCustomerViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
