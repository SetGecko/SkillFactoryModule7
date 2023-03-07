namespace inheritancePractice_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car= new HybridCar();
            car.Move();
            //sealed - если установлено перед классом - то от него нельзя наследоваться
        }
    }

    // Простой пример наследования классов
    class BaseClass
    {

    }

    class InheritedClass : BaseClass 
    { 

    }

    class Car
    {
        public double Fuel;
        public int Mileage;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }
        public void Move()
        {
            // Передвижение на километр
            Mileage++;
            Fuel -= 0.5;
        }

        public void FillTheCaer()
        {
            Fuel = 50;
        }
    }
    enum FuelType
    {
        Gas = 0,
        Electricity
    }
    class HybridCar : Car
    {
        public FuelType FuelType;

        public void ChangeFuelType(FuelType type) 
        { 
            FuelType = type;
        }
    }

}