using ConsoleApp1;
using System.Linq;
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
    static List<Employee> Employees;
    public static void GetAllEmployees()
    {
        Employees = Employee.GetEmployees();
        foreach (Employee emp in Employees)
        {
            Console.WriteLine(emp.FirstName);
        }
        Console.WriteLine("---------------------------------------------------");
    }
    public static void Main(string[] args)
    {
        /*List<String> students = Student.GetStudents().SelectMany(s=>s.Programming).Distinct().ToList();
        foreach(String student in students)
        {
            Console.WriteLine(student);
        }
        //int ans = Student.GetStudents().Sum(s => s.Id);
        //int ans = Student.GetStudents().Aggregate<Student,int>((s1, mulID) => mulID =  mulID * s1.Id);
        int ans = Student.GetStudents().Aggregate(1, (acc, s) => acc * s.Id);
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int ans2 = numbers.Aggregate((n1, n2) => n1 * n2);*/
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var ordd = numbers.Select((num, index) => new { ind1 = num, ind2 = index }).Where(x => x.ind1 % 2 != 0).ToList();
        foreach(var item in ordd)
        {
            Console.WriteLine(item.ind1+"  -  "+item.ind2);
        }
        Console.ReadLine();
    }
}