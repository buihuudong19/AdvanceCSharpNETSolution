namespace OOP.SOLID.SRP;
public class EmployeeStore
{
    private static int _lastId = default;//c#7.1 
    private static List<Employee> _employees { get; }//LinkedList, SortedSet,...
    public static int NextId => ++_lastId;//++a|a++ <=> a = a+1; (unary)

    static EmployeeStore()
    {
        /*object initalizer*/
        Employee e1 = new Employee();
        e1.Id = NextId;
        e1.Name = "Ma va Meo";
        e1.Address = "Quan 10, TPHCM";
        e1.Dob = new DateOnly(1982, 09, 02);
        e1.WorkHour = 26;
        e1.SalaryRate = 250_000;

        _employees = new List<Employee>
        {
            e1,
            new Employee(NextId, "Nguyen Cong Phuong", new DateOnly(1985, 05, 19),"Nghe An", 30, 300_000)

        };

    }
    public IEnumerable<Employee> Employees => _employees; //expression-bodied

    public void Save(Employee e)
    {
        //1. check xem e no co ton tai ko?
        //if(_employees.Any()
        
    }

   
    
}
