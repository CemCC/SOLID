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
        public double Cost(object[] cars)
        {
            double cost = 0;
            foreach (var car in cars)
            {
                if (car is Mercedes)
                {
                    Mercedes mercedes = (Mercedes)car;
                    cost += mercedes.Cost;
                }
                else if (car is Toyota) {
                    /// we have added Toyota as in if condition. And It will calculate Toyota Cost. 
                    /// However, What if dealership receives Hyundai, BMW, Holden or anyother Type?
                    /// This method will get bigger and bigger. We need a new if condition for each Car Model.
                    /// *Desirable method should be close to the Modification, even though new car models are added.
                    /// *SO, Classes should be extensible.
                    /// This Code still has got work to meet Open-Close principle.
                    /// Let's fix that.!
                    Toyota toyota = (Toyota)car;
                    cost += toyota.Cost;
                }
            }
            return cost;
        }
    }
}
