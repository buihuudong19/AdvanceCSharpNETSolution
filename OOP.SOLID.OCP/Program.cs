/*
    Them moi chuc nang tinh luong theo tung loai nhan vien
 */
using OOP.SOLID.OCP;
namespace Programming;
public class Program
{
    private static readonly EmployeePresenter _employeePresenter = new();
    private static readonly EmployeeStore _employeeStore = new();
    public static void Main()
    {
        var run = true;
        do
        {
            Console.Clear();
            //string interpolations
            Console.WriteLine($"Choises:");
            Console.WriteLine($"1. Fetch and display the employee with id=1");
            Console.WriteLine($"2. Add new employee");
            Console.WriteLine($"3. Show all employees");
            Console.WriteLine($"4. Show all salary");
            Console.WriteLine($"5. Exit");
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
                        ShowSalaryAll();
                        break;
                    case "5":
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

    private static void ShowSalaryAll()
    {
        //1. khoi tao mot collection cac  nhan vien di cung voi cong thuc tinh luong
        var empCalcualtions = new List<BaseSalaryCalculator>
        {
            new FresherEmployeeSalaryCalculator(
                new Employee
                {
                    Id = EmployeeStore.NextId,
                    Name ="Dong",
                    Address ="Quan 10",
                    Type ="Fresher",
                    WorkHour =300,
                    SalaryRate=250_000
                }   
             ),
             new JuniorEmployeeSalaryCalculator(
                new Employee
                {
                    Id = EmployeeStore.NextId,
                    Name ="Dung Pham",
                    Address ="Quan 11",
                    Type ="Junior",
                    WorkHour =250,
                    SalaryRate=300_000
                }
             ),
             new SeniorEmployeeSalaryCalculator(
                new Employee
                {
                    Id = EmployeeStore.NextId,
                    Name ="Dung Pham",
                    Address ="Quan 11",
                    Type ="Senior",
                    WorkHour =350,
                    SalaryRate=350_000
                }
             )

        };
        //tinh tong luong cua n nhan vien
        SalaryCalculatorOCP calculatorSalary = new(empCalcualtions);
        Console.WriteLine($"Tong luong cua tat ca cac nhan vien la: {calculatorSalary.CalculateTotalSalaries()}");  

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
            Id = EmployeeStore.NextId,
            Name = name,
            Address = address,
            Dob = new DateOnly(1982, 05, 03),
            WorkHour = int.Parse(workHourkly ?? default),
            SalaryRate = double.Parse(workHourkRate ?? default),
        };
        _employeeStore.Save(emp);
    }

    private static void ListAllEmployees()
    {
        foreach (Employee e in _employeeStore.Employees)
        {
            _employeePresenter.Display(e);
        }
    }
}
