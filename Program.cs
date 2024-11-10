namespace Lab_uppgift_7_OOP_Generic_Joel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("001", "Bob", "Male", 32000m);
            Employee employee2 = new Employee("002", "Anders", "Male", 40000m);
            Employee employee3 = new Employee("003", "Hanna", "Female", 24000m);
            Employee employee4 = new Employee("004", "Martin", "Male", 30000m);
            Employee employee5 = new Employee("005", "Linda", "Female", 27000m);
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);
            int totalEmployees = stack.Count;
            foreach (Employee emp in stack)
            {
                Console.WriteLine(emp.ToString());

                Console.WriteLine($"There is {totalEmployees} in the stack.");
            }

            Console.WriteLine();

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
                Console.WriteLine($"There is {stack.Count} left in the stack.");
            }

            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);
            Console.WriteLine($"There is {stack.Peek()} in the stack. ");

            Console.WriteLine();
            if (stack.Contains(employee3))
            {
                Console.WriteLine($"{employee3.ToString()} is in the stack.");
            }
            else
            {
                Console.WriteLine($"{employee3.ToString()} is not in the stack.");
            }

            List<Employee> employees = new List<Employee>
            {
                employee1, employee2, employee3, employee4, employee5
            };

            Console.WriteLine();
            if (employees.Contains(employee2))
            {
                Console.WriteLine($"{employee2.ToString()} is in the list.");
            }
            else
            {
                Console.WriteLine($"{employee2.ToString()} is not in the list.");
            }
            Console.WriteLine();
            var firstMaleEmployee = employees.Find(e => e.Gender == "Male");

            Console.WriteLine($"The first male employee in the list is {firstMaleEmployee}. ");
            Console.WriteLine();
            var allMaleEmployees = employees.FindAll(m => m.Gender == "Male");

            Console.WriteLine("All men in the list.");
            foreach (Employee employee in allMaleEmployees)
            { Console.WriteLine(employee.ToString()); };
        }
    }
}
