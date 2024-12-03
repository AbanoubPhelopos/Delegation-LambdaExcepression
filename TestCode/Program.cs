using Delegation.Delegates;

namespace TestCode
{
 

    // Delegate
    delegate void CalculateDelegate(int num1, int num2);
    delegate int CalculateDelegate2(int num1, int num2);

    
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Example 1 Calculator
            int num1 = 10;
            int num2 = 2;
            
            CalculateDelegate dlg = Add;
            Calc(num1, num2, dlg);

            */

            
            /*
                // Filter
                FilterEmp filter = new FilterEmp();
                Console.WriteLine("Filter Emps With High Salary");
                filter.FilterEmpsWithHighSalary(20000);
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("Filter Emps With Low Salary");
                filter.FilterEmpsWithLowSalary(10000);
                Console.WriteLine("-------------------------------------");


                Console.WriteLine("Filter Emps With High Bonus");
                filter.FilterEmpsWithHighBonus(3000);
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("Filter Emps With Low Tax");
                filter.FilterEmpsWithLowTax(1000);
                Console.WriteLine("-------------------------------------");
            */


            /*
            // Code with delegate
            IntoToDelegate filterWithDelegate = new IntoToDelegate(FilteredFunctions.SalaryGreaterThan);

            filterWithDelegate.FilterEmployees(20000);
            Console.WriteLine("-------------------------------------");

            filterWithDelegate.FilterEmployees(10000);
            Console.WriteLine("-------------------------------------");

            */
            
            
            /*
            // Anonymous Function and lambda expression
            // Anonymous Function
            CalculateDelegate del = delegate(int num1, int num2) { Console.WriteLine(num1 + num2); };
            // lambda expression
            //del = (x,y) => Console.WriteLine(x + y);
            //CalculateDelegate2 del2 = (x,y)=>(x + y);
            */
            
            
            /*
            // Code using lambda Expression
            Filter.FilterEmployees(emp => emp.TotalSalary >= 10000);
            Console.WriteLine("-------------------------------------");
            */
            
            
            /*
            // Predicate - Action - Func
            // Predicate
            // take only one parameter and return bool
            Predicate<int> predicate = x => x > 10;
            Console.WriteLine(predicate(9));
            
            //Action
            // take up to 16 parameter and return void
            Action<int,int>action = (x,y) => { Console.WriteLine(x + y); };
            action(1, 2);
            action.Invoke(2,3);
            
            // Func
            // take up to 16 parameter and return the last one datatype
            Func<int, int, int> func = (x, y) => x + y;
            Console.WriteLine(func(1,2));
            */
            
        }

        /*
        // Calculator Helper functions
        static void Add(int num1, int num2)
        {
            Console.WriteLine($"Addition: {num1 + num2}");
        }
        static void Subtract(int num1, int num2)
        {
            Console.WriteLine($"Subtraction: {num1 - num2}");
        }
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine($"Multiplication: {num1 * num2}");
        }
        static void Divide(int num1, int num2)
        {
            if (num2 != 0)
                Console.WriteLine($"Division: {num1 / num2}");
            else
                Console.WriteLine("Cannot divide by zero.");
        }
        static void Calc(int num1, int num2, CalculateDelegate dlg)
        {
            Console.WriteLine("Executing delegate methods:");
            dlg(num1, num2);
        }
        */

    }
}

