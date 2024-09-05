using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_2_semester_1_cs_winforms
{
    class UninterruptivlePowerSupply
    {
        public string? manufacturer { get; set; }
        public string? brand { get; set; }
        public int? capacity { get; set; }

        protected string[] possibleManufacturers = ["Apple", "Samsung", "Hp", "Dell", "Xiaomi", "Huawei", "Techno", "Google", "OnePlus", "Alcatel", "Asus", "Lenovo", "Vivo"];
        protected string[] possibleBrands = ["S1", "S2", "S3", "Redmi", "Nova", "Spark", "A60", "Go", "K15", "Galaxy", "15", "13", "B256"];

        public UninterruptivlePowerSupply()
        {
            this.manufacturer = possibleManufacturers[new Random().Next(0, possibleManufacturers.Length)];
            this.brand = possibleBrands[new Random().Next(0, possibleBrands.Length)];
            this.capacity = new Random().Next(0, 100_000);
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"UninterruptivlePowerSupply: manufacturer: {manufacturer}, brand: {brand}, capacity: {capacity}");
        }

    }
}
