using System;


 namespace ProblemSolution {

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
            Problem6();
            Console.WriteLine("Problem 07");
            Problem7();


        }

        public  static void stars()
        {
              for (int i = 0; i< 5; i++)
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
            for (int h = 0; h < 6; h++  )
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
            Console.WriteLine("Sum of {0} and {1} is {2}" , a ,b , sum);
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
                Console.WriteLine("{0} * {1} = {2}", tableNumber ,times, result);
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

    }

}