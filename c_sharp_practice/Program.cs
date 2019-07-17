using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
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
            #region Foreach Loop
            //foreach loop
            //int[] Numbers = {101, 102, 103 };
            //foreach(int x in Numbers)
            //Console.WriteLine("x = " + x);
            #endregion

            #region Types of Parametes
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
            #endregion

            #region Namespace
            //using namespace
            //ProjTA.ClassA.Print();
            //ProjTB.ClassA.Print();
            #endregion

            #region Static
            /*static
             * if u create a static constructor then it will be called before instance constructor is called or static variable is referenced
             * static constructor can be used to initialize static fields or action that only needs to be performed only once.
             */

            //Circle circle1 = new Circle(12);
            //Console.WriteLine("Area = " + circle1.calculateArea());

            //Circle circle2 = new Circle(15);
            //Console.WriteLine("Area = " + circle2.calculateArea());
            #endregion

            #region Inheritance
            /*inheritance
             * equivelent of super is base keyword in c#
             * method hiding or shadowing base class method, use new keyword, if u still want to use base method then use base.methodName() 
             * if intention is to override the defination provided by base class then use virtual keyword in base class method and override where u want to override
             */
            //ChildClass childClass = new ChildClass();
            //childClass.PrintMethod();
            //childClass.VirPrintMethod();
            //((ParentClass)childClass).VirPrintMethod();
            #endregion

            #region Getter Setter
            //getter setter
            //in case u don't want to check any condition, then simply use get set as in below method
            //behind scenes compiler will create private field for above case and then get set
            //Student std = new Student();
            //std.Id = 343;
            //std.Name = "Ali";
            //std.city = "Lahore";
            //Console.WriteLine("Name is {0}, city is {1} and id is {2}", std.Name, std.city, std.Id);
            #endregion

            #region Struct
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
            #endregion


            #region Interface
            //interfaces can only provide declaration of methods, they can't contain fields
            //if u r inheriting from two interfaces having same method name then ambiguity will rise, to fix
            //this we'll use explicit interface implementation, there r two rules for it,
            //don't use access modifier and with method name write interfaceName.method
            //Cust c = new Cust();
            //c.Print();
            //c.Print2();
            //((ICust)c).Hi();
            //((ICust2)c).Hi();
            #endregion

            #region Abstract Class
            //abstract class 
            //incomplete class, abstract method inside it cannot declare body
            #endregion

            #region Delegate
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
            #endregion

            #region Exeption Handling
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
            #endregion

            #region Enums
            //enums 
            //line 187
            #endregion

            #region Reflection and Bindings
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
            #endregion

            #region Generics
            //Generics
            /*generics allow us to design classes and methods decoupled from the data types.
             * if we use object as parameter then it will work fine for object child however int is struct
             * so unnecssary boxing unboxing will occur casuing performance issue. to fix this and many
             * other related issue we use generics that will be independent of type,
             * u will tell in <> on which types u want to operate this function
             * class can also be made generic which mean that class will operate on that data type
             */
            //Console.WriteLine(areEqual<string>("ho", "ho"));
            #endregion

            #region Some Useful methods
            //toString()
            /*use toString to convert int to string. int x = 6; string a = x.toString();
             * we can override toString() method for class and return custom text.
             * differnce b/w Convert.toString and toString is that if we pass null to Convert.toString
             * then it will convert it to string wheras toString give Exeption
             */
            //Employee e = new Employee() { ID = 1, Name = "Amar", Experience = 6, Salary = 89000 };
            //Console.WriteLine(e.ToString());

            //Equalities
            /*== gives reference equality, Equals gives value equality(to get this functionality)
             * override method
             */
            //     Employee e = new Employee() { ID = 1, Name = "Amar", Experience = 6, Salary = 89000 };
            //     Employee e2 = new Employee() { ID = 1, Name = "Amar", Experience = 6, Salary = 89000 };
            //    Console.WriteLine(e == e2);
            //    Console.WriteLine(e.Equals(e2));
            #endregion

            #region String vs StringBuilder
            //String and StringBuilder
            /*
             * String is immutable while StringBuilder is mutable
             * e.g string a = "c#"; a += "tutorials"; in heap a was 1st referncing to c# but now a new
             * string is generated c# tutorials and a start refering it, whereas in stringbuilder
             * a new string is not generated and object keep on referring same string, it's the string that
             * will change, so from performance point of view stringbuilder is better when heavy string
             * manipulation is required.
             */
            //String a = "C#";
            //a += " tutorials";
            //StringBuilder b = new StringBuilder("C#");
            //b.Append(" tutorials");
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region Partial Classes and Methods
            /**
             * partial classes
             * allow us to split a class into two or more files, on compilation all these are then combined
             * to single class. use partial keyword to use.
             * Rules
             * 1-All parts spread across multiple files should use partial keyword
             * 2-All parts spread across multiple files should have same access modifiers. 
             * 3-if any of the parts are declared abstract then entire type is considered abstract
             * 4-if any of the parts are declared sealed then entire type is considered sealed
             * 5-if any of the parts are inherits a class then entire type is considered inherting.
             * 6-Different parts of partial class can specify different base interfaces.
             * 7-Any members that are declared in partial defination are available to all other parts
             * of partial class
             */

            /*partial methods
             * declaration of partial method, if partial method has no implementation then compiler
             * will ignore it without giving error, u can provide implemenation in other parts of 
             * partial class. no access modifiers are allowed they are private by default.
             * there must be declaration of partial method otherwise it'll not be partial method.
             * return type must be void. it must be declared inside partial class or struct.
             * one partial method can be implemented only once. 
             */
            //SamplePartial samplePartial = new SamplePartial();
            //samplePartial.print();
            #endregion

            #region Optional Parameters
            /*Optioanl parameters
             * there are 4 ways of making method parameters optional
             * 1-use parameter array e.g. addNumbers(int a, int b, params object[] restOfNumbers)
             * 2-Method overloading e.g. addNum(int a, int b) and addNum(int a, int b, int[] c)
             * 3-specify parameter deafults e.g. addNum(int a, int b, int[] c = null), now we can simply call addNum(10, 20), 
             * optional paramter must appear after all required parameters, in case of more than one optional parameter u can use c:2 
             * 4-use optional attribute that's present in System.Runtime.InteropServices nampespace 
             * e.g. addNum(int a, int b, [Optional] int[] c = null)
             */
            #endregion

            #region Dictionary
            /*Dictionary-collection of key value pair
             * keys must be unique, we can retrieve both key and value from Dictornary
             */
            //Manager manager = new Manager()
            //{
            //    id = 101,
            //    name = "Qasim",
            //    salary = 200000
            //};
            //Manager manager2 = new Manager()
            //{
            //    id = 121,
            //    name = "Abdullah",
            //    salary = 200343
            //};
            //Dictionary<int, Manager> dictoinaryManagers = new Dictionary<int, Manager>();
            //dictoinaryManagers.Add(manager.id, manager);
            //dictoinaryManagers.Add(manager2.id, manager2);
            ////Console.WriteLine("Customer name is: {0}", dictoinaryManagers[121].name);
            //foreach (KeyValuePair<int, Manager> keyValuePair in dictoinaryManagers)
            //{
            //    Console.WriteLine("Name is: {0}", dictoinaryManagers[keyValuePair.Key].name);
            //}
            ////e.g u want to search customer then
            //if (dictoinaryManagers.ContainsKey(101))
            //{
            //    Console.WriteLine("Name of manager is: {0}", dictoinaryManagers[101].name);

            //}
            ////Try Get value function is used when u aren't sure if dictonary contains that key, this method returns value
            ////the 2nd arg will receive the value that u will get, the return type is boolean     
            //Manager m;
            //dictoinaryManagers.TryGetValue(101, out m);
            ////Count method returns total number of values inside dictionary, we can also put conditions
            //Console.WriteLine(dictoinaryManagers.Count(kvp => kvp.Value.salary > 200000 ));
            ////remove method will remove one while clear will remove all values from dictionary
            ////to convert array to dictionary
            //Manager[] managers = new Manager[2];
            //managers[0] = manager;
            //managers[1] = manager2;
            //Dictionary<int, Manager> dic = managers.ToDictionary(mng => mng.id, mng => mng);
            #endregion

            #region List
            //List
            //just like arrays but growable in size, e.g. below we set size to 1 but we're still able to add 3 items
            //they are strongly typed
            //Manager m1 = new Manager(1, "ALi", 32200);
            //Manager m2 = new Manager(2, "Asfand", 22200);
            //Manager m3 = new Manager(3, "Yasir", 52200);
            //List<Manager> listManagers = new List<Manager>(1);
            //listManagers.Add(m1);
            //listManagers.Add(m2);
            //listManagers.Add(m3);
            ////m1 will not be overwritten instead pushed by one position
            //listManagers.Insert(0, m3);
            //foreach (Manager manager in listManagers)
            //{
            //    Console.WriteLine("Name of Manager: {0}", manager.name);
            //}
            ////to add multiple items(list) at a time use addRange
            //List<Manager> anotherList = new List<Manager>();
            //anotherList.AddRange(anotherList);
            ////there are many other methods, explore them urself
            ////GetRange allow u to get range of items, take start index and count as input parameters
            ////insertrange take index and list as input
            ////in removeAll u can pass lambda expression as input
            ////removeRange remove range of items and take index and count as input   

            //List Sorting
            //List<int> num = new List<int> {15, 32, 62, 44, 25, 65, 7, 28, 49};
            //for ascending
            //num.Sort();
            //for descending, first sort in ascending then reverse
            //num.Reverse();
            //Sorting for complex types
            //implement Icomparable interface for sorting 
            //List<Manager> managers = new List<Manager>();
            //Manager m1 = new Manager(1, "ALi", 32200);
            //Manager m2 = new Manager(2, "Asfand", 22200);
            //Manager m3 = new Manager(3, "Yasir", 52200);
            //managers.Add(m1);
            //managers.Add(m2);
            //managers.Add(m3);
            //managers.Sort();
            //foreach (Manager manager in managers)
            //{
            //    Console.WriteLine("Salary = {0}", manager.salary);
            //}
            //below we're using delegate to sort by id
            //Comparison<Manager> customerComparer = new Comparison<Manager>(CompareCustomer);
            //managers.Sort(customerComparer);
            //following is shorter way, another way will be to use lambda expression 
            //managers.Sort(delegate (Manager mm1, Manager mm2) { return mm1.id.CompareTo(mm2.id); });
            //managers.Sort((x, y) => x.id.CompareTo(y.id));

            //Some useful methods of list collection class
            //TrueForAll()-return true if every element in list satisfy a condition
            //bool a = managers.TrueForAll(x => x.salary > 4000);
            //AsReadOnly()-return a read only wrapper for current collection. use it if u dont'y want client to modify it
            //ReadOnlyCollection<Manager> readOnlyManagers = managers.AsReadOnly();
            //TrimExcess()-trim capacity to actual number of elements, used  to reduce memory overhead

            //When to use dictionary over list
            //when u want to perform searching on basis of something, because list is going to check every element until target
            //founds
            #endregion
        }

        #region Helper Methods
        public static int CompareCustomer(Manager x, Manager y)
        {
            return x.id.CompareTo(y.id);
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
#endregion
    }

    #region Helper Classes, Interfaces, Enums, Struct
    public partial class SamplePartial
    {
        partial void AMethod();
        public void print()
        {
            Console.WriteLine("Print method invoked");
            AMethod();
        }
    }

    public partial class SamplePartial
    {
        partial void AMethod()
        {
            Console.WriteLine("Sample partial method");
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

    public class Manager : IComparable<Manager>
    {
        public Manager()
        {

        }
        public Manager(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

        public int CompareTo(Manager other)
        {
            //if (this.salary > other.salary)
            //    return 1;
            //else if (this.salary < other.salary)
            //    return -1;
            //else
            //    return 0;
            //since int also implements IComparable so
            return this.salary.CompareTo(other.salary);
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
    #endregion
}

#region Namespace
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
#endregion