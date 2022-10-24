namespace AdvanceCSharpNET.Entities;//namespace, class, interface, delegate
public class Employee
{
    //fields/data
    private int _id;
    private static int _lastId = default;//c#7.1 
    public static int NextId => ++_lastId;//++a|a++ <=> a = a+1; (unary)
    private string? _name;
    private DateOnly _dob;
    private string _address;
    //properties
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string? Name { get => _name; set => _name = value; }//Expression-body
    public DateOnly Dob{ get => _dob; set => _dob = value; }
    public string Address { get => _address; set => _address = value; }
    //toi uu
    public int WorkHour { get; set; } = 0;
    public double SalaryRate { get; set; } = 1.0d;

    //Mảng 1 chiều cho phép chứa nhiều employees
    public static Employee[] Employees { get;}//read-only => mang tinh
    private int _size = 0;

    //constructors
    //static constructor
    static Employee()
    {
        Employees = new Employee[10];
       
    }
    public Employee() { }//explicit
    
    public Employee(int id, string? name, DateOnly dob, string? address, int workHour, double salaryRate)
    {
        Id = id;
        Name = name;
        Dob = dob;
        Address = address;
        WorkHour = workHour;
        SalaryRate = salaryRate;
    }
   
    //Top Level
    public override string? ToString() => Print();

    //methods (functions/behaviors)
    private string Print() => $"Id: {Id}, Name: {this._name}, Dob: {Dob}, Address: {Address}, Work Hour: {WorkHour}, Salary rate: {SalaryRate}";

    //method save 1 employee neu nhung emp do chua co, neu co thi update
    public void Save()
    {
        //Lam the nào để lưu 1 emp vào trong mảng 1 chiều
    }

    //display all employee (procedure)
    public void Display()
    {
        for(int i = 0; i < this._size; i++)
        {
            Console.WriteLine(Employees[i]);
        }
    }
}
