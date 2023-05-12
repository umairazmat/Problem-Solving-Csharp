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
            Problem1();
            Console.WriteLine("Problem 02");
            Problem2();
            Console.WriteLine("Problem 03");
            Problem3();



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

        #region
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

    }

}