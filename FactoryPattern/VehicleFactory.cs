using System;
namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelAmount)
        {

          switch (wheelAmount)
            {   case 2: return new MotorCycle();

                case 4: return new Car();


                default: return new Car();









            }

        }

    }


          
                                

        
    
}

