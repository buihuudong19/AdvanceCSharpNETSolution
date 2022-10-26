namespace AdvanceCSharpNET;
public class Program
{
    public static void Main()
    {
        Person person = new Employee();//dependency Injection (library)
        Person student = new Student();//polymorphis

        Person[] people = new Person[] { person, student };

        Console.WriteLine(person.Print() + "abc");


        var run = true;
        do
        {
            Console.Clear();
            //string interpolations
            Console.WriteLine($"Choises:");
            Console.WriteLine($"1. Fetch and display the employee with id=1");
            Console.WriteLine($"2. Add new employee");
            Console.WriteLine($"3. Show all employees");
            Console.WriteLine($"4. Exit");
            dynamic input = Console.ReadLine();//"4"
            Console.Clear();
            try
            {

                switch (input)
                {
                    case "1":

                        break;
                    case "2":
                        CreateEmployee();
                        break;
                    case "3":
                        ListAllEmployees();
                        break;
                    case "4":
                        run = false;
                        break;
                    default:
                        Console.WriteLine($"Invalid option when you choose...");
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"==================================");
            Console.WriteLine($"Press the enter to go back to the main menu");
            Console.ReadLine();

        } while (run);//while(condition){..}, for.., forEach, recursive
        /*
             n!=n(n-1)(n-2)..(1)

         */
    }

    private static void CreateEmployee()
    {
        Console.Clear();
        Console.Write($"Please enter the name: ");
        var name = Console.ReadLine();
        Console.Write($"Please enter the address: ");
        var address = Console.ReadLine();
        Console.Write($"Please enter the Work Hourly: ");
        string? workHourkly = Console.ReadLine();
        Console.Write($"Please enter the Work Rate: ");
        var workHourkRate = Console.ReadLine();
        //object initalize
        var emp = new Employee
        {
            Id = Employee.NextId,
            Name = name,
            Address = address,
            Dob = new DateOnly(1982, 05, 03),
            WorkHour = int.Parse(workHourkly ?? default),
            SalaryRate = double.Parse(workHourkRate ?? default),
        };
        emp.Save();
    }

    private static void ListAllEmployees()
    {
        foreach (Employee e in Employee.Employees)
        {
            Console.WriteLine(e);
        }
    }
}
