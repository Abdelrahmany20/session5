using System.Reflection.Metadata.Ecma335;

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
            y = Temp;

        }


        public static int multiplication(int[] table)
        {
            //by value
            int multiply = 1;
            table[0] = 100;
            for (int i = 0; i < table.Length; i++)
            {
                multiply *= table[i]; 
            }

            return multiply;
        }



        public static int multiplication(ref int[] table)
        {

            //by ref
            int multiply = 1;
            table[0] = 100;
            for (int i = 0; i < table.Length; i++)
            {
                multiply *= table[i];
            }

            return multiply;
        }




        public static void SumAndSubt(int x, int y, int c, int z, out int sum, out int subtracting)
        {
            //Q03

            sum = x + y;
            subtracting = c - z;




        }


        //public static int SumOfindividualArray(int [] numbers )
        //{
        //Q04
        //int sum = 0;

        //for (int i=0; i<numbers.Length; i++)
        //{

        //sum += numbers[i];

        //}

        //return sum;

        //I wanted to make the number that the user would enter into an array, and each number would be in a separate index,
        //and then I would be able to sum the index.but I couldn’t do that.
        //}

        public static int SumOfNumbers(int number)
        {
            //Q04
            int sum = 0;
            while (number > 0)

            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }


        public static bool prime(int Number)
       
        //Q05
        {
            if (Number ==1)
            {
                return false;
            }

                for (int i = 2; i < Number; i++)
                {
                    if(Number % i == 0)
                        return false;
                    


                }



            return true;


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


            //int A = 5;
            //int B = 50;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //swap(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //when we send ref we send the variable A=5,B=50  ---> x=5,y=50 and making swap and return main names (a,b)
            #endregion


            #endregion


            #region Q02
            //2-	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example


            #region by value
            //int[] numbers = { 2, 3 };
            //Console.WriteLine(multiplication(numbers));
            //Console.WriteLine(numbers[0]);


            // when add table[0]=100 , i make numbers and table point to same values in heap so the first value will change  
            #endregion

            #region By ref



            //int[] numbers = { 2, 3 };
            //Console.WriteLine(multiplication(numbers));
            //Console.WriteLine(numbers[0]);


            // i send numbers with obj and change the name to table and get the same answer 
            #endregion






            #endregion

            #region Q03
            //3-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers



            //int a = 5;
            //int b = 10;
            //int c = 50;
            //int d = 20;
            //int sum,subtracting;

            //SumAndSubt(a, b, c, d, out sum, out subtracting);
            //Console.WriteLine(sum);
            //Console.WriteLine(subtracting);
            #endregion

            #region Q04
            //4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.


            //Console.Write("Enter a number: ");
            //int number =int.Parse(Console.ReadLine());

            //int answer = SumOfNumbers(number);

            //Console.WriteLine($"Sum Of Numbers : {answer}");

            #endregion

            #region Q05
            //5-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime,
            //or false if it is not:            


            Console.WriteLine("Enter A Number :");
            int number =int.Parse(Console.ReadLine());


            Console.WriteLine(prime(number));

            #endregion

        }
    }
}
