using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICalculateService
    {
        int MultiplyArrayItems(int[] arr);
        int SquareOfSumArrayItems(int[] arr);
    }
}
