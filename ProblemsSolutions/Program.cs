using System;


 namespace ProblemSolution {

    public class ProblemSolution
    {
      public static void Main(string[] args)
        {
            // stars();
            Console.WriteLine("Star Series1");
            starsSeries1();
            Console.WriteLine("Star Series2");
            starsSeries2();
            Console.WriteLine("Problem 01");
            Problem1();



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

        #region
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

    }

}