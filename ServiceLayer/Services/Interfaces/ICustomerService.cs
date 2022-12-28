using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICustomerService
    {
        int GetCustomerCountByFiltered();

        Customer[] GetCustomersByFiltered(int startAge, int endAge);
        double GetCustomersAverageByAges();
    }
}
