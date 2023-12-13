using System;
namespace NewConsoleApplication
{

    class Program
    {

        static void Main(string[] args)
        {
            Pick();
        }

        public static void Pick()
        {
            Console.WriteLine("Pick one of the options / or type 0 to leave");
            Console.Write("Backwards Letters: 1\nPerimeter of Circle: 2\nKilometers per Hour: 3\nArea and Volume of Sphere: 4");
            Console.Write("\nPick one: ");
            int leave = 0;
            int back = 1;
            int per = 2;
            int kph = 3;
            int avs = 4;
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == per)
            {
                Console.Clear();
                Perimeter();
            } else if (x == back)
            {
                Console.Clear();
                backwardsLetters();
            } else if (x == kph)
            {
                Console.Clear();
                KPH();
            } else if (x == leave)
            {

            } else if (x == avs)
            {
                Console.Clear();
                AVS();
            } else
            {
                Console.Clear();
                Console.WriteLine("Doesn't seem like we have that\ntry again!");
                Console.ReadKey();
                Console.Clear();
                Pick();
            }
        }
        public static void backwardsLetters()
        {
            Console.WriteLine("Enter a 3 letter word backwards:");
            Console.Write("Enter letter: ");
            string first = Convert.ToString(Console.ReadLine())!;
            Console.Write("Enter letter: ");
            string second = Convert.ToString(Console.ReadLine())!;
            Console.Write("Enter letter: ");
            string third = Convert.ToString(Console.ReadLine())!;
            Console.Write("Here is your word: {0}{1}{2}",third,second,first);

            Console.ReadKey();
            Console.Clear();
            Pick();
        }
        public static void Perimeter()
        {
            double Radius,per;
            double PI = 3.14;
            Console.WriteLine("Insert the Radius of a circle: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            per = 2 * PI * Radius;

            Console.Write("Perimeter of Circle: {0}", per);
            Console.ReadKey();
            Console.Clear();
            Pick();

        }

        public static void KPH()
        {
            float distance;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Input distance(metres): ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(hours): ");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(minutes): ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());

            timeSec = (hour*3600) + (min*60) + sec;
            mps = distance/timeSec;
            kph = (distance/1000.0f)/(timeSec/3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine("Your speed in metres/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
            Console.ReadKey();
            Console.Clear();
            Pick();
        }

        public static void AVS()
        {
            float r;
            float pi = 3.1415926535f;
         
            Console.Write("Radius: ");
            r = Convert.ToSingle(Console.ReadLine());
         
            Console.WriteLine("Area of Sphere: " + (4 * pi * (r * r)));
         
            Console.WriteLine("Volume of sphere: " + (4f/3f * pi * (r * r * r)));
            Console.ReadKey();
            Console.Clear();
            Pick();
        }

    }
}