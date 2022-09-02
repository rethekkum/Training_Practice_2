using System;
using SATA = SectionA.TeamA;
using SBTB = SectionB.TeamB;

class Program
{
    static void Video_14()
    {
        Console.WriteLine("Till what range even number you want?");
        int User_Target = int.Parse(Console.ReadLine());
        int Count = 1;
        do
        {
            Console.WriteLine("Number{1} is not even {0}",Count % 2==0?0:1,Count);
            Count+=1;
        }while(Count!=User_Target);

    }
    static void Video_15()
    {
        int userinput = int.Parse(Console.ReadLine());   
        for (int i=1;i<=userinput;i++) {
            Console.WriteLine("{1} is even? {0}",i%2==0?"yes":"no",i);
        }
        
        int[] numbers = new int[3] {1,2,3};
        foreach (int k in numbers)
        {
            Console.WriteLine(k);
        }


        for (int i = 1; i <= userinput - 1; i=i+3) {
            if (i % 2 == 1)
            {
                continue;
            }
            Console.WriteLine("{0} is even",i);
        }

    }

    public void Video_16()
    {
        Console.WriteLine("Static vs instance method");
    }

    static void Video_17(ref int a, int b, out int sum, out int product)
    {
        // in pass by value a copy is sent\
        // in pass by reference address of location is sent.
        a = 10;
        b = 11;
        sum = a + b;
        product = a*b;
    }

    static void Video_17_ExtraPractice(params int[] numbers)
    {
        //with the help of params we can send any length of array, we can opt to not send anything and we are not limited.
        Console.WriteLine(numbers.Length);
        //params has to be last in parameters of a function and there can be only one params.

    }


    static void Main()
    {
        //Video_14_ExtraPractice();
        //Video_14();
        //Video_15();
        //Program Video_16_Object = new Program();
        //Video_16_Object.Video_16();
        
        
        //int a = 5;
        //int b = 6;
        //int sum=0;
        //int product = 0;
        //Video_17(ref a,b,out sum,out product);
        //Console.WriteLine("{0} & {1} and their sum is {2} and their product is {3} \n and the reason sum&product feels wrong is we have copy of b value from the function",a,b,sum,product);


        Video_17_ExtraPractice(1,2,3,4,5);
        SATA.ClassA.print();
        SBTB.ClassA.print();
        //Can you use namespace from bottom section or can use namespace from separate class library project. Just add reference to the project and include in namespace. 
  
    }



}

//namespace SectionA
//{
//    namespace TeamA
//    {
//        class ClassA
//        {
//            public static void print()
//            {
//                Console.WriteLine("Section A , Team A");
//            }
//        }

//    }
//}


//namespace SectionB
//{
//    namespace TeamB
//    {
//        class ClassA
//        {
//            public static void print()
//            {
//                Console.WriteLine("Section B , Team B");
//            }
//        }

//    }
//}