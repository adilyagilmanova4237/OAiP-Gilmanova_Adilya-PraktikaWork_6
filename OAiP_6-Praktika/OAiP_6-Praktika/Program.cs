namespace Гилманова_Каримова
{
    class Transport
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public double MaxSpeed { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Двигатель запущен.");
        }
        public void StopEngine()
        {
            Console.WriteLine("Двигатель заглушен.");
        }
        public virtual void Move()
        {
            Console.WriteLine("Транспортное средство движется.");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Транспортное средство остановилось.");
        }
        public void Repair()
        {
            Console.WriteLine("Транспорт отремонтирован в мастерской.");
        }
        public void Service()
        {
            Console.WriteLine("Проведено плановое обслуживание транспорта.");
        }
    }
    class Car : Transport
    {
        public int PassengerCapacity { get; set; }
        public double EngineVolume { get; set; }

        public override void Move()
        {
            Console.WriteLine("Автомобиль едет по дороге");
        }
        public override void Stop()
        {
            Console.WriteLine("Автомобиль припаркован.");
        }
        public new void Repair()
        {
            Console.WriteLine("Транспорт отремонтирован в мастерской.");
        }
        public new void Service()
        {
            Console.WriteLine("Проведено плановое обслуживание транспорта.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Transport c = new Car();
            c.Repair();
            c.Service();

            Transport a = new Car();
            a.Move();
            a.Stop();
        }
    }
}