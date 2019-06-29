using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
//using Project.TeamA;
//using Project.TeamB;
using ProjTA = Project.TeamA;
using ProjTB = Project.TeamB;

namespace c_sharp_practice
{
    public delegate void HelloFunctionDelegate(string msg);
    public delegate bool isEligibleToPromote(Employee e);
    class Program
    {
        static void Main(string[] args)
        {
            //foreach loop
            //int[] Numbers = {101, 102, 103 };
            //foreach(int x in Numbers)
            //Console.WriteLine("x = " + x);


            /*Types of parameters
            Value Parameters = pass by value
            Reference Parameters = reference to variable is passed
            Out Parameters = when u want to return more than one output
            Params Parameter = if u want to make parameter optional, it must be a single dimension array. 
            */
            //int refVar = 10;
            //Console.WriteLine("Value of x = {0} before method call", refVar);
            //int total = 0, product = 0;
            //Calculate(10, 15, ref refVar, out total, out product, 3, 4, 6, 8, 3, 8);
            //Console.WriteLine("Value of x = {0} after method call", refVar);
            //Console.WriteLine("Total = {0} and Product = {1}", total, product);

            //using namespace
            //ProjTA.ClassA.Print();
            //ProjTB.ClassA.Print();

            /*static
             * if u create a static constructor then it will be called before instance constructor is called or static variable is referenced
             * static constructor can be used to initialize static fields or action that only needs to be performed only once.
             */

            //Circle circle1 = new Circle(12);
            //Console.WriteLine("Area = " + circle1.calculateArea());

            //Circle circle2 = new Circle(15);
            //Console.WriteLine("Area = " + circle2.calculateArea());

            /*inheritance
             * equivelent of super is base keyword in c#
             * method hiding or shadowing base class method, use new keyword, if u still want to use base method then use base.methodName() 
             * if intention is to override the defination provided by base class then use virtual keyword in base class method and override where u want to override
             */
            //ChildClass childClass = new ChildClass();
            //childClass.PrintMethod();
            //childClass.VirPrintMethod();
            //((ParentClass)childClass).VirPrintMethod();

            //getter setter
            //in case u don't want to check any condition, then simply use get set as in below method
            //behind scenes compiler will create private field for above case and then get set
            //Student std = new Student();
            //std.Id = 343;
            //std.Name = "Ali";
            //std.city = "Lahore";
            //Console.WriteLine("Name is {0}, city is {1} and id is {2}", std.Name, std.city, std.Id);

            //struct
            //many ways to initialize, nearly same as class object initialization, following is object initializer method
            //struct is value type class is reference type
            //struct can't have destructors but class can have
            //struct cannot have explicit parameterless constructor
            //struct cannot inherit from other class. however both class and struct can inherit from interface
            //if u mark a class as sealed then other classes cannot inherit from it
            //Customer c = new Customer
            //{
            //    Id = 32,
            //    Name = "Paul"
            //};
            //Console.WriteLine("Name is {0} and id is {1}", c.Name, c.Id);

            //interfaces can only provide declaration of methods, they can't contain fields
            //if u r inheriting from two interfaces having same method name then ambiguity will rise, to fix
            //this we'll use explicit interface implementation, there r two rules for it,
            //don't use access modifier and with method name write interfaceName.method
            //Cust c = new Cust();
            //c.Print();
            //c.Print2();
            //((ICust)c).Hi();
            //((ICust2)c).Hi();

            //abstract class 
            //incomplete class, abstract method inside it cannot declare body

            //delegate is a type safe function pointer, so when u invoke delegate, function will be invoked
            //see syntax outside class, so delegate on line 9 can be used to point to a function with similar signature
            //return type and parameter should match. to make it point create instance of it like class, in 
            //constructor pass name of method
            //HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            //del("Hello from delegate");
            //we use delegates to make our code re usable, apply different logic as required without affecting code
            //below we're removing logic and passing delegate, now we can apply any logic and code remain reusable
            //instead of all this u can simply pass lambda expression to method 
            //List<Employee> emplList = new List<Employee>();
            //emplList.Add(new Employee() { ID = 1, Name = "Amar", Experience = 6, Salary = 89000 });
            //emplList.Add(new Employee() { ID = 2, Name = "Akbar", Experience = 1, Salary = 89700});
            //emplList.Add(new Employee() { ID = 3, Name = "Anthony", Experience = 4, Salary = 88000});
            //emplList.Add(new Employee() { ID = 4, Name = "Jessica", Experience = 7, Salary = 89400});
            //emplList.Add(new Employee() { ID = 5, Name = "John", Experience = 4, Salary = 59000});

            ////isEligibleToPromote promote = new isEligibleToPromote(isPromotable);
            ////Employee.PromoteEmployee(emplList, promote);
            //Employee.PromoteEmployee(emplList, emp => emp.Experience > 5);

            //Multi Cast Delegate
            //one delegate pointing to many function. when invoked all functions get executed. 
            //we can do this by using + symbol. e.g. del4 = del1+del2+del3 so del4 is now multicast delegate 
            //we can also use +=. +, -, +=, -= are valid operations. in case func return something then only
            //last return value will be returned.

            //Exeption handling(inner exeption included)
            //inner exception return exeption instance that caused current exception
            //try {
            //    try
            //    {
            //        int x, y, res;
            //        Console.WriteLine("Enter values: ");
            //        x = Convert.ToInt32(Console.ReadLine());
            //        y = Convert.ToInt32(Console.ReadLine());
            //        res = x / y;
            //        Console.WriteLine("{0} / {1} = {2}", x, y, res);
            //    }
            //    catch (Exception e)
            //    {
            //        string filePath = @"C:\Users\mamir\Desktop\log1.txt";
            //        if (File.Exists(filePath))
            //        {
            //            StreamWriter sw = new StreamWriter(filePath);
            //            sw.Write(e.GetType().Name);
            //            sw.WriteLine();
            //            sw.Write(e.Message);
            //            sw.Close();
            //            Console.WriteLine("There is problem try again");
            //        }
            //        else
            //        {
            //            throw new FileNotFoundException(filePath + "is not present", e);
            //        }
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Current exeption = " + ex.GetType().Name);
            //    Console.WriteLine("Inner exeption = " + ex.InnerException.GetType().Name);
            //}

            //enums 
            //line 187

            //Reflection
            /*reflection is ability to inspect assembly meta data ar runtime. when we bulid solution the
             * classes are assembled in assembly. when we look at assembly it consist of two parts, 
             * one is the intermediate language and the other one is meta data, meta data contain info
             * about type. e.g what are different types in this assembly e.g Employee, Customer etc.,
             * what are its members(e.g constructors, methods, name etc) so all info about these type is 
             * packaged in form of metadata. What is reflection then? taking that assembly and inspecting
             * it e.g. how many classes, enums, structs etc it got and for each class what are different 
             * members. How it is useful? when we drag and drop a btn, we know btn is a class and it got
             * properties, so when we click on it, all of its properties appear on one sidebar, this is done
             * through reflection(pulling all properties from assembly).
             * Early binding - e.g on creating customer object we have knowledge about this customer at 
             * compile time.
             * Late Binding - e.g u might not have knowledge at compile time about class, so u can only 
             * create its instance at runtime dynamically.
             */
            //Type type = Type.GetType("c_sharp_practice.Employee");
            //Type type = typeof(Employee);
            //Console.WriteLine("Full name = {0}" ,type.FullName);
            //Console.WriteLine("name = {0}", type.Name);
            //Console.WriteLine("namespace = {0}", type.Namespace);
            //PropertyInfo[] properties = type.GetProperties();
            //foreach(PropertyInfo property in properties)
            //{
            //    Console.WriteLine(property.Name + " - " + property.PropertyType);
            //}
            //MethodInfo[] methods = type.GetMethods();
            //foreach (MethodInfo method in methods)
            //{
            //    Console.WriteLine(method.Name + " - " + method.ReturnType);
            //}

            //Late Binding - if we don't have info 
            /*first of all load assembly, activator will create instance, since we don't know type so use 
             * object, u can get method, if it was a static method we will directly get it from type,
             * now to invoke first pass parameters;
             */
            //Assembly executingAssembly = Assembly.GetExecutingAssembly();
            //Type t = executingAssembly.GetType("c_sharp_practice.ParentClass");
            //object o =  Activator.CreateInstance(t, "hi");
            //MethodInfo meth = t.GetMethod("PrintMethod");
            //meth.Invoke(o, null);

            //Generics
            /*generics allow us to design classes and methods decoupled from the data types.
             * if we use object as parameter then it will work fine for object child however int is struct
             * so unnecssary boxing unboxing will occur casuing performance issue. to fix this and many
             * other related issue we use generics that will be independent of type,
             * u will tell in <> on which types u want to operate this function
             * class can also be made generic which mean that class will operate on that data type
             */
            //Console.WriteLine(areEqual<string>("ho", "ho"));

            //toString()
            /*use toString to convert int to string. int x = 6; string a = x.toString();
             * we can override toString() method for class and return custom text.
             */
            //Employee e = new Employee() { ID = 1, Name = "Amar", Experience = 6, Salary = 89000 };
            //Console.WriteLine(e.ToString());

            //Equalities
            /*== gives reference equality, Equals gives value equality(to get this functionality)
             * override method
             */
             Employee e = new Employee() { ID = 1, Name = "Amar", Experience = 6, Salary = 89000 };
             Employee e2 = new Employee() { ID = 1, Name = "Amar", Experience = 6, Salary = 89000 };
            Console.WriteLine(e == e2);
            Console.WriteLine(e.Equals(e2));
        }

        public static bool areEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }

        public static bool isPromotable(Employee e)
        {
            if(e.Salary > 80000)
                return true;
            else
                return false;
        }


        public static void Hello(string msg)
        {
            Console.WriteLine(msg);
        }


        static void Calculate(int x, int y, ref int z, out int sum, out int prod, params int[] optional)
        {
            Console.WriteLine("There are {0} elements in array", optional.Length);
            sum = x + y;
            prod = x * y;
            z = 9;
        }
    }

    public enum Gender
    {
        Male, Female, Unknown
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        
        
        public static void PromoteEmployee(List<Employee> empList, isEligibleToPromote isPromotable)
        {
            foreach(Employee e in empList)
            {
                if(isPromotable(e))
                {
                    Console.WriteLine(e.Name + " Promoted");
                }
            }
        }

        public override string ToString()
        {
            return "Employee " + Name + " has salary = " + Salary; 
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else if (!(obj is Employee))
                return false;
            else
                return ID == ((Employee)obj).ID && Name == ((Employee)obj).Name;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode() ^ Name.GetHashCode();
        }
    }

    interface ICust
    {
        void Print();
        void Hi();
    }
    interface ICust2
    {
        void Print2();
        void Hi();
    }
    class Cust : ICust, ICust2
    {
        public void Print()
        {
            Console.WriteLine("Hi from class, implementing interface icust");
        }
        public void Print2()
        {
            Console.WriteLine("Hi from class, implementing interface icust2");
        }
        void ICust.Hi()
        {
            Console.WriteLine("Hi from interface icust");
        }
        void ICust2.Hi()
        {
            Console.WriteLine("Hi from interface icust2");
        }
    }

    struct Customer
    {
        private int id;
        private string name;

        public int Id { get; set; }
        public string Name { get; set; }
    }

    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent constructor called");
        }

        public ParentClass(String msg)
        {
            Console.WriteLine(msg);
        }

        public void PrintMethod()
        {
            Console.WriteLine("Print method of parent");
        }

        public virtual void VirPrintMethod()
        {
            Console.WriteLine("Virtual Print method of parent");
        }
    }

    class ChildClass : ParentClass
    {
        public ChildClass() : base("Message passed to ParentClass constructor")
        {
            Console.WriteLine("Child constructor called");
        }

        public new void PrintMethod()
        {
            Console.WriteLine("Print method of child hiding parent method");
        }

        public override void VirPrintMethod()
        {
            Console.WriteLine("overrider Print method of child");

        }
    }

    class Circle
    {
        static float PI;
        int radius;

        static Circle()
        {
            Circle.PI = 3.144F;
            Console.WriteLine("static constructor called");
        }

        public Circle(int rad)
        {
            Console.WriteLine("Instance constructor called");
            this.radius = rad;
        }

        public float calculateArea()
        {
            return Circle.PI * this.radius * this.radius;
        }
    }

    class Student
    {
        private int id;
        private String name;
        public String city { get; set; }

        public int Id
        {
            set
            {
                if(value < 0)
                {
                    throw new Exception("Student id cannot be null");
                }
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }

        public String Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }

    }
}

/*
 * namespaces help to organize program and avoid name clashes. e.g if working on project we assign some task 
 * to team and some to team b, we want all classes develope by team a to be presented in project.team a namespace,
 * same for team b, consider a scenario of university portal where all data realated to student is placed in 
 * student namesapce, System is also a namespace as used above. {} brace tells it's a namespace in suggestion.
 * to avoid ambiguity b/w class names either use fully qualified namespace or use aliases
 * if namespace is in another project and we want to use it, go to project and add reference of that namespace
 */

namespace Project
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A print method");
            }
        }
    }
}

namespace Project
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B print method");
            }
        }

    }
}