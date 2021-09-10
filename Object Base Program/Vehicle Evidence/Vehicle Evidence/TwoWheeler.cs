using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Evidence
{
    class TwoWheeler : Vehicle, IExterior
    {
        public string FrontBreak { get; set; }
        public string RearBreak { get; set; }
        public void DesignExterior(Motorcycle motorcycle)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Design " + motorcycle.vehicleTypes + " Motorcycle !!");
            Console.WriteLine
            (
                motorcycle.ModelNo
                + " Y" + motorcycle.YearMake
                + " Seat" + motorcycle.NumberOfSeat
                + " CC" + motorcycle.EngineCapacityCC
            );
        }
    }

    interface IExterior
    {
        void DesignExterior(Motorcycle motorcycle);
    }
}
