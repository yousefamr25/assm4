using Demo_session_18.binding;
using Demo_session_18.polymorphism_overriding_;
using System;


namespace Demo_session_18
{
    internal class Program
    {
        #region Overloading

        //public static int sum(int x,int y)
        //{
        //    return x + y;
        //}
        //public static int sum(int x, int y,int z)
        //{
        //    return x + y+ z;
        //}
        //public static double sum(double x, double y)
        //{
        //    return x + y;
        //}
        //public static double sum(int x, double y)
        //{
        //    return x + y;
        //}





        #endregion
        public static void ProcessEmployee(Employee employee)
        {
            if (employee is not null)
            {
                employee.GetEmployeeType();
                employee.GetEmplyeeData();
            }


        }



        static void Main(string[] args)
        {
            #region polymorphism(overloading)
            //int result = sum(1, 2);
            //int result3 = sum(1, 2,3);
            //Console.WriteLine(result);//3
            //Console.WriteLine(result3);//6









            #endregion
            #region polymorphism(overriding)
            //function overriding must be with relationship[inheritance]
            //typeA typeA = new typeA(1);
            //typeA.MyFunB1();
            //typeA.myfun2();

            //TypeB typeB = new TypeB(1,2);
            //typeB.A = 10;
            //typeB.B= 20;




            #endregion

            #region Binding
            ////ref fromparent =>Object from child
            //typeA refBase;
            //refBase = new TypeB(1, 2);
            ////Binding
            //refBase.A = 10;
            ////refBase.B = 30;//invalid
            //refBase.myfun2();
            //refBase.MyFunB1();







            #endregion
            #region Not Binding
            //TypeB child = (TypeB)new typeA(1);
            ////not binding
            ////Explicit Casting 
            ////unsafe

            //typeA typeA = new typeA(1);
            //TypeB typeB = (TypeB)typeA;
            ////casting operator --function
            ///

            //typeA typeA = new TypeB(1, 2);
            //TypeB typeB = (TypeB)typeA;
            ////valid


















            #endregion
            #region binding Ex01
            //FullTimeEmployee fullTimeEmp=new FullTimeEmployee(10,"Yousef",20,5000);
            //ProcessEmployee(fullTimeEmp);

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 10,
            //    Name = "yousef", 
            //    Age = 20,
            //    CountHours = 50,
            //    HoursRate = 2000,


            //};
            //ProcessEmployee(partTimeEmployee);
            ////valid



            #endregion
            #region Binding Ex02
            //typeA typeA = new TypeC(1, 2, 3);
            //typeA.A = 10;
            ////typeA.B = 20;//invalid
            ////typeA.C = 30;//invalid
            //typeA.myfun01();///override using new keyword[static binding]
            ////output:I am base
            //typeA.myfun2();//override using override keyword [dynamic binding]
            // //output:typeA =10 typeB=2 typeC=3

            //TypeB typeB=new TypeC(1, 2,5); 
            //typeB.A = 10;
            //typeB.B = 20;
            ////typeB.C=30;//invalid
            //typeB.myfun01();///override using new keyword[static binding]
            ////output:I am child
            //typeB.myfun2();
            ////override using override keyword [dynamic binding]
            ////output:typeA =10 typeB=20 type c=3


            typeA typeA = new TypeE(1, 2, 3, 4, 5);
            TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            TypeC typeC = new TypeE(1, 2, 3, 4, 5);


            typeA.myfun2();
            typeB.myfun2();
            typeC.myfun2();



            TypeD typeD = new TypeE(1, 2, 3, 4, 5);
            // TypeD type = new TypeE(1,2,3,4,5);







            #endregion










        }
    }
}
