using System;

namespace quizcodesat5
{
    class Program
    {
        static void Main(string[] args)
        {
            int rose;
            Console.Write("Input Total Rose : ");
            rose = int.Parse(Console.ReadLine());

            int sunflower;
            Console.Write("Input Total Sun Flower : ");
            sunflower = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Rose");
            int ID, Amount;
            Console.Write("ID : ");
            ID = int.Parse(Console.ReadLine());
            string Plantname, Plantdescription, Height, Circumference;
            Console.Write("Plant name : ");
            Plantname = (Console.ReadLine());
            Console.Write("Plant description : ");
            Plantdescription = (Console.ReadLine());
            Console.Write("Amount : ");
            Amount = int.Parse(Console.ReadLine());
            Console.Write("Heigh : ");
            Height = (Console.ReadLine());
            Console.Write("Circumference : ");
            Circumference = (Console.ReadLine());

            Rose flower = new Rose(ID, Plantname, Plantdescription, Amount, Height, Circumference);

            Console.WriteLine("Input Sun Flower");
            int ID2, Amount2;
            Console.Write("ID : ");
            ID2 = int.Parse(Console.ReadLine());
            string Plantname2, Plantdescription2, Height2, Circumference2;
            Console.Write("Plant name : ");
            Plantname2 = (Console.ReadLine());
            Console.Write("Plant description : ");
            Plantdescription2 = (Console.ReadLine());
            Console.Write("Amount : ");
            Amount2 = int.Parse(Console.ReadLine());
            Console.Write("Heigh : ");
            Height2 = (Console.ReadLine());
            Console.Write("Circumference : ");
            Circumference2 = (Console.ReadLine());

            SunFlower flower2 = new SunFlower(ID, Plantname, Plantdescription, Amount, Height, Circumference);
        }
    }
    class Rose 
    {
        public int ID;
        public string Plantname;
        public string Plantdescription;
        public int Amount;
        public string Height;
        public string Circumference;

        public Rose(int valueID, string valuePlantname, string valuePlantdescription, int valueAmount, string valueHeight, string valueCircumference) 
        {
            ID = valueID;
            Plantname = valuePlantname;
            Plantdescription = valuePlantdescription;
            Amount = valueAmount;
            Height = valueHeight;
            Circumference = valueCircumference;
        }
        public string InformationRose()
        {
            return Plantname ;
            return Plantdescription;
        }
    }

    class SunFlower 
    {
        public int ID;
        public string Plantname;
        public string Plantdescription;
        public int Amount;
        public string Height;
        public string Circumference;

        public SunFlower(int valueID, string valuePlantname, string valuePlantdescription, int valueAmount, string valueHeight, string valueCircumference)
        {
            ID = valueID;
            Plantname = valuePlantname;
            Plantdescription = valuePlantdescription;
            Amount = valueAmount;
            Height = valueHeight;
            Circumference = valueCircumference;
        }
    }
    
}
