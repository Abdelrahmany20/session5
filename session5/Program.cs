using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace session5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Casting [Boxing - Unboxing]
            // Reference Type Casting => Convert from Reference to To Reference Ty
            // Boxing Casting => Convert from Value Type to To Reference Type
            // UnBoxing Casting => Convert from  Reference Type to Value Type

            #region Boxing
            //object obj = new object();
            //obj = "Mostafa"; // Reference Type Casting
            //obj = 2; // Boxing [Casting from Value Type [int] to Reference Type [Object]]



            //int X = 10;
            //object obj01 = new object();
            //obj01 = X;  //stac--->heap (boxing)


            // Parent = Child
            // Dog is Animal
            #endregion

            #region unboxing

            //object obj02 = new object();
            //obj02 + 10;
            //int X = (int)obj02;


            // Child = Parent
            // Animals is Dogs

            #endregion

            #endregion

            #region Nullable Datatype

            #region value type

            //int X = null; // int Number only

            //int? X = null; // int Number and Null

            //Nullable<int> Number;

            //Console.WriteLine(X};

            //int X = 10
            // int Y = 20;


            //int X = 10;
            //int? Y = /*(int?)*/X;

            //int? X = null;
            //int Y;
            //if (X != null)
            //{
            //Y = (int)X; // Casting
            //}
            //else
            //{
            //Y = 0;
            //}




            //if (X.HasValue)
            //{
            //Y = X.Value;
            //}
            //else
            //{
            //Y = 0;
            //}



            //Y = X.HasValue ? X.Value : 0;
            //Console.WriteLine(Y);

            #endregion

            #region Reference Type
            //string? Name = null!;

            //Console.WriteLine(Name);
            #endregion

            #region Null Propagation Operator
            //int[] Numbers = null;

            /////////// for (int i = 0; Numbers!=null && i < Numbers.Length; i++)
            ////for (int i = 0; i < Numbers ?.Length; i++)
            //{
            //Console.WriteLine(Numbers[i]);

            //}



            // i < Numbers ?. Length
            // Numbers => Object [Length]
            //Numbers => Null[Null]



            //int[] Numbers = null;
            //if (Numbers != null)
            //{
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //Console.WriteLine(Numbers[i]);
            //}
            //}







            //int Length = Numbers ?. Length ?? 0;

            //Console. WriteLine(Length);







            //Employee Emp = new Employee();

            //Console.WriteLine(Emp.Department.Name);



            //if (Emp != null)
            //{
            //if (Emp.Department != null)
            //{
            //Console.WriteLine(Emp.Department.Name);
            //}
            //}


            //Console.WriteLine(Emp.Department?.Name ?? "Not Found");
            #endregion

            #endregion

            #region Functions

            //////namespace Demo_Session_05_C_Basics_G02

            // class
            // interface
            // enum
            // struct
            ////// internal class Program

            // Functions
            // Data


            // Types of Function
            // 1. Class Member Function [static Function]
            // 2. object Member Function [non Static Function]


            //  --1--

            //public static void PrintShape()
            //{
            //for (int i = 0; i < 10; i++)
            //{
            //Console.WriteLine("( *-* )");
            //}
            //}


            //PrintShape()


            //----------------------------------------------------------//




            //public static void PrintShape(int Count, string Pattern)
            //{
            //for (int i = 0; i < Count; i++)
            //{
            //Console.WriteLine(Pattern);
            //}
            //}

            //PrintShape(10,"***")    //   passing by order

            // PrintShape(Pattern: " *-* ", Count: 10);   //   passing by name


            //PrintShape()    //   passing by defult





            //----------------------------------------------------------//


            #endregion

            #region  Value Type Paramters





            //public static void Swap(int X, int Y)
            //{
            //int Temp = X;
            //X = Y;
            //Y = Temp;
            //}

            #region by value
            //int A = 5;
            //int B = 9;
            //Console.WriteLine(A);
            //Console.WriteLine(B);


            //Swap(A, B);

            //Console.WriteLine(A);
            //Console.WriteLine(B);

            #endregion

            #region By ref
            //public static void Swap(ref int X, ref int Y)
            //{
            //int Temp = X;
            //X = Y;
            //Y = Temp;
            //}




            //int A = 5;
            //int B = 9;
            //Console.WriteLine(A);
            //Console.WriteLine(B);


            //Swap(ref A,ref  B);

            //Console.WriteLine(A);
            //Console.WriteLine(B);





            #endregion


            #endregion

            #region refrence type

            //public static int SumArray(int[] Arr)
            //{
            //// Sum + 1 = 1
            ////1+2=3
            ////3+3=6
            //int Sum = 0;
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //Sum += Arr[i];
            //}
            //return Sum;

            //}
            //



            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbärs));


            #region Ex01

            #region By Value

            //public static int SumArray(int[] Arr)
            //{
            //// Sum + 1 = 1
            ////1+2=3
            ////3+3=6
            //int Sum = 0;
            //arr[0]=100;
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //Sum += Arr[i];
            //}
            //return Sum;

            //}
            //



            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion

            #region by Ref





            //public static int SumArray(ref int[] Arr)
            //{
            //// Sum + 1 = 1
            ////1+2=3
            ////3+3=6
            //int Sum = 0;
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //Sum += Arr[i];
            //}
            //return Sum;

            //}
            //




            //int[] Numbers = { 1,*2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);





            #endregion

            #endregion

            #region Ex02


            //public static int SumArray(int[] Arr)
            //{
            //// Sum +1=1
            ////1 + 2 =3
            //// 3 + 3 = 6
            //int Sum = 0;
            ////Arr[0]=100;
            //Arr = new int[] { 4, 5, 6 };
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //Sum += Arr[i];
            //}
            //return Sum;
            //}




            #region  by value 


            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(NumbErs[0]);


            #endregion


            #region by ref

            //    public static int SumArray(ref int[] Arr)
            //{
            //    // Sum + 1=1
            //    //1+2=3
            //    // 3 +3 =6
            //    int Sum = 0;
            //    //Arr[0] = 100+
            //    Arr = new int[] { 4, 5, 6 };
            //    for (int i = 0; i < Arr.Length; i++)
            //    { 
            //        Sum += Arr[i];
            //}
            //    return Sum;

            //}  



            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]); 


            #endregion
            #endregion


            #endregion

            #region Functions - Passing By Out


            //public static void SumMul(int X, int Y, out int Sum, out int Mul)
            //{
            //Sum = X + Y;
            //Mul = X * Y;
            //return Sum;
            //return Mul;
            // }





            //int A = 10;
            //int B = 20;
            //int Sum, Mul;
            //SumMul(A, B, out Sum, out Mul);

            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul);
            #endregion

            #region Functions - Params
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(SumArray(Numbers));

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } ;
            //Console.WriteLine(SumArray(1, 2, 3, 4, 5, 6, 7, 8,9,10));


            //int A = 10, B = 20, C = 30;
            //Console.WriteLine("A : {0} , B : {1} ,C : {2}" , A, B, C);
            #endregion



        }
    }
}
