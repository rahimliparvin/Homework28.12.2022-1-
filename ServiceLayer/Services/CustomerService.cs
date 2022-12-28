using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerService
    {
        

        public int GetCustomerCountByFiltered()
        {
            var customers = GetAll();

            int count = 0;
            foreach (var item in customers)
            {
                if(item.Age > 25 && item.Age < 30)
                {
                    count++;
                }
            }

            return count;
        }

        public double GetCustomersAverageByAges()
        {
            var customers = GetAll();

            
            double sumAge = 0;

            foreach (var item in customers)
            {
                sumAge += item.Age;
            }
            //sumAge / customers.Length;
            return Math.Ceiling (sumAge / customers.Length);

        }

        public Customer[] GetCustomersByFiltered(int startAge, int endAge)
        {
            var customers = GetAll();

            Customer[] result = new Customer[customers.Length];

            int count = 0;

            foreach (var item in customers)
            {
                if (item.Age > startAge && item.Age < endAge)
                {
                    result[count++] = item;
                    count++;
                }
            }


            return result;
        }

       
        
        private Customer[] GetAll()
        {
            Customer c1 = new Customer
            {
                Id = 1,
                Name = "Shaig",
                Surname = "Kazimov",
                Age = 25,
                Position = "Backend developer"
            };

            Customer c2 = new Customer
            {
                Id = 2,
                Name = "Konul",
                Surname = "Ibrahomiva",
                Age = 26,
                Position = "Frontend developer"
            };


            Customer c3 = new Customer
            {
                Id = 3,
                Name = "Roya",
                Surname = "Maharramova",
                Age = 26,
                Position = "Fullstack developer"
            };


            Customer c4 = new Customer
            {
                Id = 4,
                Name = "Mubariz",
                Surname = "Aghayev",
                Age = 18,
                Position = "Software instructor"
            };

            Customer[] customers = {c1,c2,c3,c4};
            return customers;
        }
   
        

    }
}
