namespace Task_7._6._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Car<T1> where T1 : Engine
    {
        public T1 Engine;
        public virtual void ChangePart<T2>(T2 newPart) where T2 :  CarPart
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