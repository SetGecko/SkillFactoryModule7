namespace Task_7._6._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;
        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }
    abstract class Engine
    {

    }
    abstract class CarPart
    {

    }
    class ElectricEngine : Engine
    {

    }
    class GasEngine : Engine
    {

    }
    class Battery : CarPart
    {

    }
    class Differential : CarPart
    {

    }
    class Wheel : CarPart
    {

    }
    class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
}