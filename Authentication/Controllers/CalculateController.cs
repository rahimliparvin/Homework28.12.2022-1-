using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Practices_26._12._2022.Controllers
{
    public class CalculateController
    {
        public readonly ICalculateService _service;
        public CalculateController()
        {
            _service = new CalculateService();
        }





        public void MultiplyArrayItems() => Console.WriteLine(_service.MultiplyArrayItems(GetArr()));
        //{
        //var result = GetArr();
        //int[] arr = { 1, 2, 3, 4, 5, 6, 12 };
        //var result = _service.MultiplyArrayItems(arr);
        //Console.WriteLine(_service.MultiplyArrayItems(GetArr()));
        //}



        public void SquaredArrayItems() => Console.WriteLine(_service.SquareOfSumArrayItems(GetArr()));
        //{
            //var result = GetArr();
            //int[] arr = { 1, 2, 3, 4, 5, 6, 12 };
            //var result = _service.SquareOfSumArrayItems(arr);
            //Console.WriteLine(_service.SquareOfSumArrayItems(GetArr());
        //}

        private int[] GetArr() => new[] { 1, 2, 3, 4, 5, 6, 12 }; 
        //{
            //int[] arr = { 1, 2, 3, 4, 5, 6, 12 };
            //return new[] { 1, 2, 3, 4, 5, 6, 12 }; 
        //}

    }
}
