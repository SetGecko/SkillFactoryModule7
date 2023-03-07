﻿namespace OverridingProperties_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Citizen
    {
        public virtual double Age
        {
            get; set;
        }
        public void SayYourAge()
        {
            Console.WriteLine("Мне {0} лет", Age);
        }
    }
    class CivilServant : Citizen
    {
        private double age;
        public override double Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
    class President: CivilServant
    {
        private double age;
        public override double Age
        {
            get { return age; }
            set
            {
                if (value < 35) 
                {
                    Console.WriteLine("Для работы президентом гражданин должен быть не младше 35 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

}