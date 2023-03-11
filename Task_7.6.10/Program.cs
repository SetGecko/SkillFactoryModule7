namespace Task_7._6._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;
        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
        {

        }
    }
    class Engine
    {

    }
    class CarPart
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
}