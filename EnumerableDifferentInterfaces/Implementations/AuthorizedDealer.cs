using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableDifferentInterfaces
{
    public class AuthorisedDealer
    {
        private readonly IEnumerable<IVehicle> vehicles;

        public AuthorisedDealer()
        {
            this.vehicles = new List<IVehicle>
            {
                new Car()
                {
                    TypeOfCar = "Private Car"
                },
                new Cycle()
                {
                    TypeOfCycle = "Mountain Bike"
                }
            };
        }

        public void ListProperties()
        {
            foreach (dynamic vehicle in this.vehicles)
            {
                this.ListProperties(vehicle);
            }
        }

        public void ListProperties(ICar car)
        {
            Console.WriteLine(car.TypeOfCar);
        }

        public void ListProperties(ICycle cycle)
        {
            Console.WriteLine(cycle.TypeOfCycle);
        }
            
    }
}
