using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesAndObjects.Data;
using ClassesAndObjects.Exercises;
using ClassesAndObjects.Concepts;
using ClassesAndObjects.Math;
using ClassesAndObjects.UdemyClasses;

namespace ClassesAndObjects
{
    public enum SMethods
        {
        threed = 3,
        twod = 2,
        oned = 1
        }

     class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Testing my new XPS laptop");
            //Palindrome.palindrome();
            //Class49 C49 = new Class49();
            //ArraysClass AR = new ArraysClass();
            //AR.ArraysMethod();
           // C49.RandomNumbers();
            //Console.WriteLine(C49.DivisibleByThree());
           //Console.WriteLine("The sum of previously entered numbers is: " + Class49.SumOfAllEnteredNumbers());
            //Console.WriteLine(C49.FactorialOfNumber());
            // Console.WriteLine(C49.PrintLargest());

            //    Class46 C4 = new Class46();
            //    C4.loop();

            //UdemyClass43 UC43 = new UdemyClass43();
            //UC43.SpeedCamera();
            //Console.WriteLine(UC43.LandOrPotrait());
            //Console.WriteLine(UC43.TaskOne());
            // Console.WriteLine(UC43.DisplayMax());
            // ControlFlow CF = new ControlFlow();
            //CF.IfStatement();
            //  Console.WriteLine(CF.SwitchCase());
            // Prime p = new Prime();
            // Console.WriteLine(p.Hello());
            ///*************** Arrays Practice ***************************//
            // ArraysPractice AP = new ArraysPractice();
            // AP.LargestArray();
            //AP.DeleteSmallest();
            //  Console.WriteLine(AP.prime());
            //Prime pn = new Prime();
            //ReadingTheFile RF = new ReadingTheFile();
            //RF.ReadFileProcess();

            //pn.IsPrime();
            // Console.WriteLine(Addition.EvenOdd());
            // Console.WriteLine(Addition.HasSpaces());
            //double[] arr2 = new double[] {2.3,5.4,7.8,3.7,9.2,4.9, 20.1 };
            //Console.WriteLine(Addition.differenceMaxMin(arr2));
            ///************* ListsPractice***************//
            //Customer Cus1 = new Customer() { ID = 10, Name = "John", Grade = "8th" };
            //Customer Cus2 = new Customer() { ID = 11, Name = "Jake", Grade = "9th" };
            //Customer Cus3 = new Customer() { ID = 12, Name = "Mary", Grade = "10th" };

            //List<Customer> CL = new List<Customer>();
            //CL.Add(Cus1);
            //CL.Add(Cus2);
            //CL.Add(Cus3);

            //foreach (Customer C in CL)
            //{
            //    Console.WriteLine("ID is {0} Name is {1} Grade is {2}" ,C.ID , C.Name,C.Grade );
            //}


            //Console.WriteLine(IstheStringNullOrEmpty.isStringNull());

            ///************** Get Set Properties**************/
            //GetSetProperties GSP = new GetSetProperties();
            //int z  = GSP.ReturnLength("Yeshwanth");
            //Console.WriteLine(z);


            // SMethods SM = new SMethods();
            //int y = (int)SMethods.oned;
            //Console.WriteLine((int)y);

            //int x = 3;
            //Console.WriteLine((SMethods)x);
            //string Smstr = "twod";
            //int sm1 = (int)Enum.Parse(typeof(SMethods), Smstr);
            //Console.WriteLine(sm1);    

            /////***************** Date Time **************//
            //String InputDate = Console.ReadLine();
            //DateTime CurrentDate = Convert.ToDateTime(InputDate);
            ////Console.WriteLine(CurrentDate.DayOfWeek);
            //int month = Convert.ToInt32(Console.ReadLine());
            //int day = Convert.ToInt32(Console.ReadLine());
            //bool opres = DateTimeCheck.CheckDateTime(month, day);
            //Console.WriteLine(opres);

            //int IncValue = DateTimeCheck.ReturnIncremented(5);
            //Console.WriteLine(IncValue);

            //string Fullname = DateTimeCheck.FullName("Gopala" , "Krishna");
            //Console.WriteLine(Fullname);
            ///****************IstheStringNullOrEmpty*****************////
            //string InputString1 = Console.ReadLine();
            //bool OutputBool = IstheStringNullOrEmpty.IstheGivenStringNullOrEmpty(InputString1);
            //Console.WriteLine(OutputBool);

            ////*************** flip the boolean **************//
            //Console.WriteLine("Enter true of false");
            //bool bool3 = Convert.ToBoolean(Console.ReadLine());
            //bool bool2 = IsStringEmpty2.FlipTheBoolean(bool3);
            //Console.WriteLine("The flipped value of the bool is: " +bool2);

            //************* Divisible by 5 **************/
            //int divby5 = Convert.ToInt32(Console.ReadLine());
            //bool resofdiv5 = IsDivisibleBy5.IsDivisibleByFive(divby5);
            //Console.WriteLine(resofdiv5);

            //int resOfLegs =  NumberOfLegs.NoOfLegs(2,4,4);
            // Console.WriteLine(resOfLegs);

            //int resultNumDen = NumberOfLegs.remainder(6,3);
            //Console.WriteLine(resultNumDen);
            /************************* total number of legs in the farm ********************

            ///***************  verify if the string is empty ****************/
            //Console.WriteLine("Enter a string: ");
            //string str1 = Console.ReadLine();
            //bool res =  IsStringEmpty.Checkstring(str1);
            //Console.WriteLine("The string I entered is an empty string: " +res);

            /*************************** Enums ***************************/
            //var val1 = (byte)ShppingMethods.OneDayShipping;
            ////string strval1 = val1.ToString();
            ////Console.WriteLine(strval1);
            //////if we do casting by adding a datatype, the value of the const will be printed. Else the name of the constant will be printed - Hence Enums are Name-Value pairs
            //Console.WriteLine(val1.ToString());
            ////int val2 = (int)ShppingMethods.PriorityMail;
            ////Console.WriteLine(val2);

            ////int val3 = 2;

            ////Console.WriteLine((ShppingMethods)val3);


            //var method = ShppingMethods.OneDayShipping;
            //Console.WriteLine(method.ToString());

            //string methodname = "OneDayShipping";

            //ShppingMethods SM = (ShppingMethods)Enum.Parse(typeof(ShppingMethods), methodname);
            //Console.WriteLine(Convert.ToInt32(SM));


            //int StypeValue = (int)ShppingMethods.OneDayShipping;
            ////Console.WriteLine(StypeValue);

            //byte ShippingDaysType = 3;

            //Console.WriteLine((ShppingMethods)ShippingDaysType);

            //string ShippingTypeValue = "TwoDayShippingdfwer";
            //try
            //{
            //    int ShippingTypeDay = (int)Enum.Parse(typeof(ShppingMethods), ShippingTypeValue);
            //    Console.WriteLine(ShippingTypeDay);

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The entered value {0} doesn't match with any shipping type in our company", ShippingTypeValue);                
            //}

            ////****************Strings Today***********//
            //Console.WriteLine("Enter a String");
            //string chkthestr = Console.ReadLine();
            //bool resValue = IsStringEmpty2.IsTheGivenStringEmpty(chkthestr);
            //Console.WriteLine(resValue);
            //Console.WriteLine("Enter a Number: ");


            //try
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    bool result = IsNumberLessThanOrEqualToZero.ValidateNumber(num);
            //    Console.WriteLine("The number entered is less than or equal to 0: " + result);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The entered number is either larger or smaller than what int32 can hold");
            //}

            //    //************************ Code for Area of Triangle in the Triangle class
            //    Console.WriteLine("Enter the value of the base of the triangle: ");
            //    int base1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter the value of the height of the triangle: ");
            //    int height1 = Convert.ToInt32(Console.ReadLine());
            //    int AreaTR = Triangle.AreaOfTriangle(base1, height1);
            //    Console.WriteLine("Area of the triangle with Base {0} and height {1} is : {2}" ,base1 , height1, AreaTR);


            ////*************Code for Perimeter of the Triangle in the Triangle Class ******************//
            //Triangle PObj = new Triangle();
            //int Pmeter = PObj.PerimeterOfTriangle(4,6,7);
            //Console.WriteLine(Pmeter);

            ////**********************************Is String Emplty from StringEmpty Class **************************//
            //Console.WriteLine("Enter a string: ");
            ////string strValue = "abcd1234";
            ////string strNull = string.Empty;

            ////bool chkStr = IsStringEmpty.IsTheStringEmpty(strNull);
            ////Console.WriteLine(chkStr);
            //string str1 = Console.ReadLine();
            //bool Strvalue = IsStringEmpty.IsTheStringEmpty(str1);
            //Console.WriteLine("The string I entered is an empty string: " + Strvalue);
            //string s1 = null;
            //bool s1Val = IsStringEmpty.IsTheStringEmpty(s1);
            //Console.WriteLine(s1Val);




            //Arrays Ar = new Arrays();
            //Ar.intArray1();
            //Ar.boolArray1();
            //Ar.InitializingValues();
            //Strings is a class created by me, which has a static method.
            //Thats's why we don't have to create an object to access this method.

            //  Strings.SplitString();
            //Strings Str1 = new Strings();
            //Str1.TestingStaticKeyword();
            //Strings.FormattedString();
            //Strings.EscapeCharacters();

            //Calculator c = new Calculator();
            //Details det = new Details();
            //Addition Ad = new Addition();
            ////int result;
            //result = c.Add(3, 4);
            //Console.WriteLine(result);

            //result = c.Add(5, 4);
            //Console.WriteLine(result);

            //Introduce I = new Introduce
            //{
            //    FirstName = "Yeshwanth",
            //    LastName = "Tirunagari"
            //};

            //Introduce I1 = new Introduce();
            //I1.FirstName = "Yeshwanth";
            //I1.LastName = "Tirunagari";

            //I.IntroduceMethod();
            //I1.IntroduceMethod();
            //Details DetObj = new Details
            //{
            //    ID = 1,
            //    age = "29"
            //};
            //DetObj.CustomerDetails();

            //EmployeeDetails ED = new EmployeeDetails();
            //ED.EmployeeDesignation = "Software Engineer";
            //ED.EmployeeSalary = 120000;
            //ED.EMployeedets();
            Console.ReadLine();
        }
    }


   
}
