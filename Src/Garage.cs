using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondRepoCore
{
    public class Garage
    {
        ICar _car;

        public Garage(ICar car)
        {
            _car = car;
        }

        public ICar GetCar()
        {
            return _car;
        }

        public int PrepairCarEngine(string engine)
        {
            return _car.Prepair(engine);
        }
    }
}
