using System;
using System.Diagnostics.Metrics;
using SATA = SectionA.TeamA;
using SBTB = SectionB.TeamB;

class Video_19
{
    string firstname;
    string lastname;

    public Video_19()
        : this("No first name provided", "No Last name provided")
    {
    }
    public Video_19(string FN, string LN)
    {
        this.firstname = FN;
        this.lastname = LN;
    }
    public void fullname()
    {
        Console.WriteLine(this.firstname+this.lastname);
    }

    ~Video_19()
    {

    }


}

public class Video_20
{
    public static float PI;
    int radius;

    static Video_20()
    {
        PI = 3.14F;
        Console.WriteLine("static constructor called ");
    }

    public Video_20(int radius)
    {
        this.radius = radius;
    }

    public static void print()
    {
        Console.WriteLine("Value of Pi is:{0}",PI);
        //this nahi use hosakta because object static hai and uski aik hi copy hai.
    }
    
    public float CalculateArea()
    {
        return this.radius * PI;
    }
}

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


        //Video_17_ExtraPractice(1,2,3,4,5);
        //SATA.ClassA.print();
        //SBTB.ClassA.print();
        //Can you use namespace from bottom section or can use namespace from separate class library project. Just add reference to the project and include in namespace. 

        //Video_19 v19 = new Video_19("rethek","SWE");
        //v19.fullname();

        Console.WriteLine("Static field called by static constructor before even creating an instance, value of static field pie is:{0}",Video_20.PI);

        Video_20 v20 = new Video_20(10);
        float v20_return=v20.CalculateArea();
        Console.WriteLine(v20_return);
        Video_20.print();


        Video_20 v20_1 = new Video_20(10);
        float v20_return_1 = v20_1.CalculateArea();
        Console.WriteLine(v20_return_1);
        Video_20.print();
        //this stops working when using static object because there is no specific instance for each object and there is only one copy thats why we wont be able to use this*
        //       if a variable is not changing and remaining same after initializing than its better to make them static.
        //other each object will it own set of instance object therefore it will occupy memory therefore we should make them static then there will be only one copy and will be shared by all objects. similar concept for methods
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