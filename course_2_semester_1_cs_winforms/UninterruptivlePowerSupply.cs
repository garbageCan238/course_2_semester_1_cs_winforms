namespace course_2_semester_1_cs_winforms
{
    class UninterruptivlePowerSupply : ICloneable
    {
        public string manufacturer { get; set; }
        public string brand { get; set; }
        public int capacity { get; set; }

        private ComparingValue _currentComparingValue;

        public void SetComparingValue(ComparingValue value)
        {
            _currentComparingValue = value;
        }

        public int GetComparingValue()
        {
            return _currentComparingValue switch
            {
                ComparingValue.Capacity => capacity,
                ComparingValue.Manufacturer => (Array.IndexOf(possibleManufacturers, manufacturer) + 1) * 100,
                ComparingValue.Brand => (Array.IndexOf(possibleBrands, brand) + 1) * 100,
                _ => throw new Exception(),
            };
        }

        protected string[] possibleManufacturers = ["Alcatel","Apple","Asus","Dell","Google","Hp","Huawei","Lenovo","OnePlus","Samsung","Techno"];
        protected string[] possibleBrands = ["13","15","A60","B256","Galaxy","Go","K15","Nova","Redmi","S1"];

        public UninterruptivlePowerSupply()
        {
            _currentComparingValue = ComparingValue.Manufacturer;
            this.manufacturer = possibleManufacturers[new Random().Next(0, possibleManufacturers.Length)];
            this.brand = possibleBrands[new Random().Next(0, possibleBrands.Length)];
            this.capacity = new Random().Next(0, 1000);
        }

        public UninterruptivlePowerSupply(int seed)
        {
            this.manufacturer = possibleManufacturers[new Random(seed).Next(0, possibleManufacturers.Length)];
            this.brand = possibleBrands[new Random(seed).Next(0, possibleBrands.Length)];
            this.capacity = new Random(seed).Next(0, 1000);
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"UninterruptivlePowerSupply: manufacturer: {manufacturer}, brand: {brand}, capacity: {capacity}");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public enum ComparingValue
        {
            Manufacturer,
            Brand,
            Capacity
        }
    }
}
