using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vena.ViewModels;

namespace Vena.Services
{
    public interface ICustomerService
    {
        IList<ListCustomerViewModel> List();
        ListCustomerViewModel Find(int customerId);
        void Add(CustomerFormViewModel viewModel);
        void Update(ListCustomerViewModel viewModel);
        void Delete(CustomerFormViewModel viewModel);
    }
}
