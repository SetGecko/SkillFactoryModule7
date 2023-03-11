namespace LimitationsOfGenerics_7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Order
    {
        public int Number;

        public string Description;

    }
    abstract class Delivery
    {
        public string Address;
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
    }
    class HomeDelivery : Delivery 
    { 

    }
    class PickPointDelivery : Delivery
    {

    }
    class ShopDelivery : Delivery
    {

    }
    class PremiumService<T> where T : Order<HomeDelivery>
    {
        public T Order;
    }
}