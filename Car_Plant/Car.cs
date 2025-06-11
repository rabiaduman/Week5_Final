using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Plant
{
    internal class Car
    {

        public Car() 
        {
            ProductionDate = DateTime.Now;
        }

        public string CarBrand { get; set; } //Marka

        public string CarModel { get; set; } //Model

        public string CarColor { get; set; } //Renk

        public DateTime ProductionDate { get; set; } //Üretim Tarihi
        
        public int CarDoor { get; set; } //Kapı Sayısı

        public string VIN { get; set; } //Seri Numarası
    }
}
