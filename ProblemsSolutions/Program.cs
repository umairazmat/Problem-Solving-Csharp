namespace ProblemSolution
{

    public class ProblemSolution
    {
        public static void Main(string[] args)
        {
            // stars();
            // Console.WriteLine("Star Series1");
            //  starsSeries1();
            //  Console.WriteLine("Star Series2");
            // starsSeries2();
            Console.WriteLine("Problem 01");
            // Problem1();
            Console.WriteLine("Problem 02");
            // Problem2();
            Console.WriteLine("Problem 03");
            // Problem3();
            Console.WriteLine("Problem 04");
            // Problem4();
            Console.WriteLine("Problem 05");
            // Problem5();
            Console.WriteLine("Problem 06");
            //  Problem6();
            Console.WriteLine("Problem 07");
            // Problem7();
            Console.WriteLine("Problem 08");
            // Problem8();
            Console.WriteLine("Problem 09");
            // Problem9();
            Console.WriteLine("Problem 10");
            // Problem10();
            Console.WriteLine("Problem 11");
           // Problem11();
            Console.WriteLine("Problem 12");
            // Problem12();
            Console.WriteLine("Problem 13");
            // Problem13();
            Console.WriteLine("Problem 14");
            //Problem14();
            Console.WriteLine("Problem 15");
            // Problem15();
            Console.WriteLine("Problem 16");
            // Problem16();
            Console.WriteLine("Problem 17");
             // Problem17();
            Console.WriteLine("Problem 18");
             // Problem18();
            Console.WriteLine("Problem 19");
             Problem19();
            Console.WriteLine("Problem 20");
            // Problem20();



        }

        public static void stars()
        {
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("*");
            }
        }

        #region StarSeries1
        public static void starsSeries1()
        {

            for (int i = 1; i < 6; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
        #endregion

        #region StarSeries2
        public static void starsSeries2()
        {

            for (int i = 1; i < 6; i++)
            {

                for (int j = 6; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
        #endregion

        #region Problem 1
        public static void Problem1()
        {
            for (int h = 0; h < 6; h++)
            {
                for (int w = 0; w < 9; w++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        #endregion

        #region Problem 02 
        public static void Problem2()
        {
            string[] lines = new string[]
        {
            "        *",
            "     *  *  * ",
            "  *     *     *",
            "*       *        *",
            "        *",
            "        *",
            "        *",
            "        *",
            "        *",
            "        *",
            "        *",
            "        *",
            "        *",
            "        *"
        };

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        #endregion

        #region Problem 3
        public static void Problem3()
        {
            // int a = 5;
            Console.Write("Enter value 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            // int b = 3;
            Console.Write("Enter value 2:");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Value of a is : {0}", a);
            Console.WriteLine("Value of b is : {0}", b);
            Console.WriteLine("Sum is : {0}", sum);
            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, sum);
        }
        #endregion

        #region Problem 4
        public static void Problem4()
        {
            /*  int a = 1;
              int b = 2;
              int result = b * a;
              Console.WriteLine("{0} * {1} = {2}", b, a, result);
              a++;
              Console.WriteLine("{0} * {1} = {2}", b, a, result);
              a++;
              Console.WriteLine("{0} * {1} = {2}", b, a, result);
              a++;
              Console.WriteLine("{0} * {1} = {2}", b, a, result);
              a++;
              Console.WriteLine("{0} * {1} = {2}", b, a, result); */

            // 2nd way 
            Console.Write("Enter Number What table you want to print :");
            int tableNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter How many times you want to Print :");
            int mul = Convert.ToInt32(Console.ReadLine());
            for (int times = 0; times < mul; times++)
            {
                int result = tableNumber * times;
                Console.WriteLine("{0} * {1} = {2}", tableNumber, times, result);
            }

        }
        #endregion

        #region Problem 5
        public static void Problem5()
        {
            Console.Write("Input some String: ");
            string message = Console.ReadLine();
            Console.WriteLine("You have Typed : {0}", message);

        }
        #endregion

        #region Problem 6
        public static void Problem6()
        {
            Console.Write("Enter some Integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have Typed : {0}", number);
        }
        #endregion

        #region Problem 7
        public static void Problem7()
        {

            Console.Write("Enter value 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value 2:");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Sum of {0} & {1} is : {2}", a, b, sum);
        }
        #endregion

        #region problem 8
        public static void Problem8()
        {

            Console.Write("Name:");
            String _name = Console.ReadLine();
            Console.Write("Cell:");
            String _cell = Console.ReadLine();
            Console.Write("WhatsApp:");
            String _whatsApp = Console.ReadLine();
            Console.Write("Email:");
            String _email = Console.ReadLine();
            Console.Write("Age:");
            int _age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thanks for the input ");
            Console.WriteLine("You have provided the following info ");

            Console.WriteLine("Name : {0}", _name);
            Console.WriteLine("Cell : {0}", _cell);
            Console.WriteLine("Whatsapp : {0}", _whatsApp);
            Console.WriteLine("Email : {0}", _email);
            Console.WriteLine("Age : {0}", _age);

        }
        #endregion

        #region problem 9
        public static void Problem9()
        {
            Console.Write("Enter 1st number to multiply: ");
            int _num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number to multiply: ");
            int _num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number to multiply: ");
            int _num3 = Convert.ToInt32(Console.ReadLine());
            int multi = _num1 * _num2 * _num3;
            Console.WriteLine("Output : {0} * {1} * {2} =  {3}", _num1, _num2, _num3, multi);
        }
        #endregion

        #region problem 10
        public static void Problem10()
        {
            Console.Write("Enter an integer variable: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The table of {0} is as follows:", number);

            Console.WriteLine("{0} * 1 = {1}", number, number * 1);
            Console.WriteLine("{0} * 2 = {1}", number, number * 2);
            Console.WriteLine("{0} * 3 = {1}", number, number * 3);
            Console.WriteLine("{0} * 4 = {1}", number, number * 4);
            Console.WriteLine("{0} * 5 = {1}", number, number * 5);
            Console.WriteLine("{0} * 6 = {1}", number, number * 6);
            Console.WriteLine("{0} * 7 = {1}", number, number * 7);
            Console.WriteLine("{0} * 8 = {1}", number, number * 8);
            Console.WriteLine("{0} * 9 = {1}", number, number * 9);
            Console.WriteLine("{0} * 10 = {1}", number, number * 10);

        }
        #endregion

        #region problem 11

        public static void Problem11()
        {

            Console.Write("Enter value 1:");
            int _num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value 2:");
            int _num2 = Convert.ToInt32(Console.ReadLine());
            int sum = _num1 + _num2;
            Console.WriteLine("{0} + {1} = {2}", _num1, _num2, sum);
            int sub = _num1 - _num2;
            Console.WriteLine("{0} - {1} = {2}", _num1, _num2, sub);
            int mult = _num1 * _num2;
            Console.WriteLine("{0} * {1} = {2}", _num1, _num2, mult);
            int divide = _num1 / _num2;
            Console.WriteLine("{0} / {1} = {2}", _num1, _num2, divide);
        }
        #endregion

        #region Problem12
        public static void Problem12()
        {
            int n = 1;
            int n2 = n * n;
            int n3 = n * n * n;
            Console.WriteLine("n\tn2\tn3");
            Console.WriteLine("{0}\t{1}\t{2}", n, n2, n3);

            n = 2;
            n2 = n * n;
            n3 = n * n * n;
            Console.WriteLine("{0}\t{1}\t{2}", n, n2, n3);
            
            n = 3;
            n2 = n * n;
            n3 = n * n * n;
            Console.WriteLine("{0}\t{1}\t{2}", n, n2, n3);

            n = 4;
            n2 = n * n;
            n3 = n * n * n;
            Console.WriteLine("{0}\t{1}\t{2}", n, n2, n3);

            n = 5;
            n2 = n * n;
            n3 = n * n * n;
            Console.WriteLine("{0}\t{1}\t{2}", n, n2, n3);

            n = 6;
            n2 = n * n;
            n3 = n * n * n;
            Console.WriteLine("{0}\t{1}\t{2}", n, n2, n3);

            n = 7;
            n2 = n * n;
            n3 = n * n * n;
            Console.WriteLine("{0}\t{1}\t{2}", n, n2, n3);

            n = 8;
            n2 = n * n;
            n3 = n * n * n;
            Console.WriteLine("{0}\t{1}\t{2}", n, n2, n3);

            n = 9;
            n2 = n * n;
            n3 = n * n * n;
            Console.WriteLine("{0}\t{1}\t{2}", n, n2, n3);

            n = 10;
            n2 = n * n;
            n3 = n * n * n;
            Console.WriteLine("{0}\t{1}\t{2}", n, n2, n3);
        }

        #endregion

        #region Problem 13
        public static void Problem13()
        {
            Console.Write("Enter number for Table : ");
            int table = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter How many times you want to print :");
            int mul = Convert.ToInt32(Console.ReadLine());

            for (int times = 0; times < mul; times++)
            {
                int result =  table * times;
                Console.WriteLine("{0} * {1} = {2}",table,times,result);
            }
        }
        #endregion

        #region Problem 14
        public static void Problem14()
        {

            Console.Write("Enter number for Table : ");
            int table = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter How many times you want to print :");
            //int mul = Convert.ToInt32(Console.ReadLine());

            for ( int times = 0; times <= 10 ; times++)
            {
                if (times % 2 == 0 )
                {
                    int result = table * times;
                    Console.WriteLine("{0} * {1} = {2}", table, times, result);
                }
            }
        }
        #endregion

        #region Problem 15
        public static void Problem15()
        {

            Console.Write("Enter number for Table : ");
            int table = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter How many times you want to print :");
            //int mul = Convert.ToInt32(Console.ReadLine());

            for (int times = 10; times >= 0; times--)
            {
                if (times % 2 == 0)
                {
                    int result = table * times;
                    Console.WriteLine("{0} * {1} = {2}", table, times, result);
                }
            }
        }
        #endregion

        #region Problem 16
        public static void Problem16()
        {
            Console.Write("Enter number for Table : ");
            int table = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter How many times you want to print :");
            //int mul = Convert.ToInt32(Console.ReadLine());

            for (int times = 0; times < 10; times++)
            {
                if (times % 2 != 0)
                {
                    int result = table * times;
                    Console.WriteLine("{0} * {1} = {2}", table, times, result);
                }
            }

        }
        #endregion

        #region Problem 17
        public static void Problem17()
        {
            
            int table = 5;

            for (int times = 0; times <= 20; times++)
            {
                if (times % 2 == 0)
                {
                    int result = table * times;
                    Console.WriteLine("{0} * {1} = {2}", table, times, result);
                }
            }
            Console.WriteLine("\nIn revere Order\n");
            for (int times = 20; times >= 0; times--)
            {
                if (times % 2 == 0)
                {
                    int result = table * times;
                    Console.WriteLine("{0} * {1} = {2}", table, times, result);
                }
            }

        }
        #endregion

        #region Problem 18
        public static void Problem18()
        {
            Console.Write("Enter number for Table : ");
            int table = Convert.ToInt32(Console.ReadLine());

            for (int times = 0; times < 10; times++)
            {
                int result = table * times;
                Console.WriteLine("{0} * {1} = {2}", table, times, result);
            }
        }
        #endregion

        #region Problem 19
        public static void Problem19()
        {
            Console.Write("Enter number for Table : ");
            int table = Convert.ToInt32(Console.ReadLine());

            for (int times = 10; times > 0; times--)
            {
                int result = table * times;
                Console.WriteLine("{0} * {1} = {2}", table, times, result);
            }
        }
        #endregion

        #region Problem 20
        public static void Problem20()
        {

        }
        #endregion
    }

}