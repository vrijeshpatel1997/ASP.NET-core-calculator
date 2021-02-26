using CalculatorView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorView.Service
{
    public class CalculatorBusinessService
    {


        public double addnumber(CalculatorModel cmodel)

        {
            return (cmodel.num1 + cmodel.num2);




        }
    }
}
