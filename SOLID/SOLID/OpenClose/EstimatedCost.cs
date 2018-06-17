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
        /// Now we have another problem. A dealership can have more than Mercedes Models.
        /// For example Dealership receives Toyota brand car in to the shop... 
        /// </summary>
        /// <param name="cars"></param>
        /// <returns></returns>
        public double Cost(Car[] cars) /// I do care about the Car Abstract class, which makes all car types extensible... 
                                        ///And closed the method for modification
        {
            double cost = 0;
            foreach (var car in cars)
            {
                cost += car.Cost();
            }
            return cost;
        }
    }
    
}
