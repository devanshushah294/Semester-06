using ConsoleApp1;
using System.Net;

public class Employee
{
    public int? Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Salary { get; set; }

    public static List<Employee> GetEmployees()
    {
        List<Employee> list = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Devanshu", LastName="Shah", Salary=200000},
            new Employee { Id = 2, FirstName = "Divyank", LastName="Raja", Salary=20000},
            new Employee { Id = 3, FirstName = "Mubin", LastName="Seta", Salary=2000},
            new Employee { Id = 4, FirstName = "Karan", LastName="Khunt", Salary=200},
            new Employee { Id = 5, FirstName = "Kishan", LastName="Moliya", Salary=20}
        };

        return list;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Message");
        List<Employee> basicQuery1 = (from emp in Employee.GetEmployees() select emp).ToList();
        foreach(Employee emp in basicQuery1)
        {
            Console.WriteLine(emp.FirstName);
        }
        IEnumerable<Employee> basicMethod1 = Employee.GetEmployees().ToList();
        Console.WriteLine("Using method syntax");
        List<Employee> list = Employee.GetEmployees();
        List<Employee> employees = list.Where(s => s.FirstName.Contains("ev")).ToList();
        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp.FirstName);
        }
        /*Console.ReadKey();*/

    }
}