using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose
{
    public class EstimatedCost
    {   /// <summary>
    /// We are writing program for car dealership.
    /// It needs to calculate estimated cost.
    /// Here we have written a program which returns Mercedes Costs
    /// </summary>
    /// <param name="cars"></param>
    /// <returns></returns>
        public double Cost(Mercedes[] cars)
        {
            double cost = 0;
            foreach (var car in cars)
            {
                cost += car.Cost;
            }
            return cost;
        }
    }
}
