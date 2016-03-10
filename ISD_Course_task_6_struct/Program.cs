using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_6_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            int chosen_exersise = -1;

            while (chosen_exersise != 0)
            {
                Console.WriteLine("\tISD Course. Task 6. Homework by Fedor Voloshyn.\n");
                Console.WriteLine("Enter number of exercise or '0' to exit: ");
                chosen_exersise = ImputFilter.ImputIntNumber(Console.ReadLine());
                Console.Clear();

                switch (chosen_exersise)
                {
                    case 0: Console.WriteLine("Have a nice day!");
                        break;
                    case 1: ExerciseOne();
                        break;
                    case 2: ExerciseTwo();
                        break;
                    case 3: ExerciseThree();
                        break;
                    case 4: ExerciseFour();
                        break;
                    case 5: ExerciseFive();
                        break;
                    case 6: ExerciseSix();
                        break;
                    default: Console.WriteLine("Looks like you entered wrong number! Try again ;)");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void ExerciseOne()
        {
            Notebook myNote = new Notebook("Acer", "V5", 600);
            myNote.Show();
        }
        public static void ExerciseTwo()
        {
            Train[] myTrains = new Train[8];
            Random rand = new Random();
            char symbol;
            Console.WriteLine("=====Trains=====");
            for(int i = 0; i < myTrains.Length; i++)
            {
                symbol = (char)rand.Next(0x0410, 0x0429);
                myTrains[i] = new Train("Point_" + symbol, rand.Next(1000, 2001), DateTime.Now.AddHours(rand.Next(0, 10)));
                Console.WriteLine("{0}. {1}. {2}.", myTrains[i].NumberOfTrain, myTrains[i].Time, myTrains[i].DistinationPoint);
            }
            Console.WriteLine("================\n\nEnter number of train: ");
            int number = ImputFilter.ImputIntNumber(Console.ReadLine());
            for(int i = 0; i < myTrains.Length; i++)
            {
                if (myTrains[i].NumberOfTrain == number)
                    Console.WriteLine("{0}. {1}. {2}.", myTrains[i].NumberOfTrain, myTrains[i].Time, myTrains[i].DistinationPoint);
                else if (i == myTrains.Length - 1)
                    Console.WriteLine("No such train");
            }
        }
        public static void ExerciseThree()
        {
            MyClass myClass = new MyClass();
            myClass.change = "не изменено";
            MyStruct myStruct;
            myStruct.change = "не изменено";

            Console.WriteLine("myClass.change = {0}", myClass.change);
            Console.WriteLine("myStruct.change = {0}", myStruct.change);

            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine("\nClassTaker(myClass);\nStructTaker(myStruct);\n");

            Console.WriteLine("myClass.change = {0}", myClass.change);
            Console.WriteLine("myStruct.change = {0}\n", myStruct.change);

            // На деле получили работу с передачей параметров по ссылке и по копии.
            // Класс - ссылочный тип, соответственно мы передавали в метод ссылку на него,
            // поэтому на выходе из метода получили изменение непосредственно экземпляра.
            // В случае со структурой, в метод была передана копия экземпляра, отчего
            // вызов метода StructTaker() никак не сказался на исходном экземпляре.
        }
        public static void ExerciseFour() // Не учитываются высокосные года!
        {
            Console.WriteLine("Enter your birsday date: ");
            DateTime userBD = Convert.ToDateTime(Console.ReadLine());
            int daysToBD = userBD.DayOfYear - DateTime.Now.DayOfYear;
            if (daysToBD < 0)
                daysToBD += 365;
            Console.WriteLine("{0} days to your birthday!", daysToBD);
        }
        public static void ExerciseFive()
        {

        }
        public static void ExerciseSix()
        {

        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
}
