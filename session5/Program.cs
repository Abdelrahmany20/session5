namespace session5
{
    internal class Program
    {



        public static void swap(int x, int y)


        {
            // for Q01 by value

            int Temp = x;
            x = y;
            Temp = y;

        }


        public static void swap(ref int x, ref int y)


        {
            // for Q01 by Ref

            int Temp = x;
            x = y;
           y=Temp;

        }

        static void Main(string[] args)
        {
            #region Q01

            //1-	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            #region By Value


            //int A = 10;
            //int B = 20;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //swap(A, B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);


            // when we passing by value we send the value in a and b (10,20) ,but a and b still As it is so we cant see any changes when we run



            #endregion

            #region By Ref


            int A = 5;
            int B = 50;
            Console.WriteLine(A);
            Console.WriteLine(B);
            swap(ref A, ref B);
            Console.WriteLine(A);
            Console.WriteLine(B);

            //when we send ref we send the variable A=5,B=50  ---> x=5,y=50 and making swap and return main names (a,b)
            #endregion


            #endregion


        }
    }
}
