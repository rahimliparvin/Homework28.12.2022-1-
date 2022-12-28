using DomainLayer.Models;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Practices_26._12._2022.Controllers
{
    public class CustomerController
    {
        private readonly ICustomerService _service;

        public CustomerController()
        {
            _service = new CustomerService();
        }


        public void GetCustomerCountByFiltered() => Console.WriteLine(_service.GetCustomerCountByFiltered());
        //{
            //Console.WriteLine(_service.GetCustomerCountByFiltered());
        //}


        public void GetCustomersAverageByAges() => Console.WriteLine(_service.GetCustomersAverageByAges());
        //{
            //Console.WriteLine(_service.GetCustomersAverageByAges());
        //}

        public void GetCustomersByFiltered()
        {
            int startAge = 22;
            int endAge = 30;
            Customer[] result = _service.GetCustomersByFiltered(startAge, endAge);

            //var result  = _service.GetCustomersByFiltered(startAge, endAge);

            foreach (var item in result)
            {
                if (item!=null)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Age} {item.Position}");
                }
            }
        }
    }
}
