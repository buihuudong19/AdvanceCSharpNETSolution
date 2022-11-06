using System.Collections.ObjectModel;
namespace OOP.SOLID.OCP;


public interface IEmployeeStore
{
    IEnumerable<Employee> GetAll();
    Employee? Get(int? id);
    void Create(Employee e);
    void Replace(Employee e);
    void Delete(Employee e);
}

public class EmployeeStoreInitISP:IEmployeeStore
{
    private static int _lastId = default;//c#7.1 

    //database
    private static List<Employee> _employees { get; }//LinkedList, SortedSet,...
    private static int NextId => ++_lastId;//++a|a++ <=> a = a+1; (unary)

    static EmployeeStoreInitISP()
    {
        /*object initalizer*/
        Employee e1 = new Employee();
        e1.Id = NextId;
        e1.Name = "Ma va Meo";
        e1.Address = "Quan 10, TPHCM";
        e1.Dob = new DateOnly(1982, 09, 02);
        e1.WorkHour = 26;
        e1.Type = "Fresher";
        e1.SalaryRate = 250_000;

        _employees = new List<Employee>
        {
            e1,
            new Employee(NextId, "Nguyen Cong Phuong", new DateOnly(1985, 05, 19),"Nghe An", 30, 300_000)

        };

    }
    public IEnumerable<Employee> Employees => new ReadOnlyCollection<Employee>(_employees);


    public IEnumerable<Employee> GetAll() => _employees;
    

    public Employee? Get(int? id)
    {
        //return _employees.FirstOrDefault(e => e.Id == id);
        //return _employees.Find(e=>e.Id == id);
        return _employees.Where(x => x.Id == id).FirstOrDefault();
      
    }

    public void Create(Employee e)
    {
        //1. check e 
        if(e.Id == default)
        {
            throw new Exception("A new employee cannot be created with an id...");
        }
        else
        {
            e.Id = NextId;
            _employees.Add(e);
        }
    }

    public void Replace(Employee e)
    {
        if (!_employees.Any(n => n.Id == e.Id))
        {
            throw new Exception($"The Employee {e.Id} does not exit...");
        }
       var index = _employees.FindIndex(n=> n.Id == e.Id);  
        _employees[index] = e; //update
    }

    public void Delete(Employee e)
    {
        if (!_employees.Any(n => n.Id == e.Id))
        {
            throw new Exception($"The Employee {e.Id} does not exit...");
        }
        var index = _employees.FindIndex(n => n.Id == e.Id);
        _employees.RemoveAt(index); 
    }
}
