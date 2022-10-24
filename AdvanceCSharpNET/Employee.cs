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
    public static Employee[] Employees { get;  private set; }//read-only => mang tinh
    private static int _size = 0;

    //constructors
    //static constructor
    static Employee()
    {
        Employees = new Employee[2];
        //add 2 phan tu vao mang
       Employee e1 = new Employee();
        e1.Id = NextId;
        e1.Name = "Ma va Meo";
        e1.Address = "Quan 10, TPHCM";
        e1.Dob = new DateOnly(1982,09,02);
        e1.WorkHour = 26;
        e1.SalaryRate = 250_000;
        Employees[0] = e1;
        Employees[1] = new Employee(NextId,"Nguyen Cong Phuong",new DateOnly(1985,05,19),
            "Nghe An",30,300_000
            );
        _size = 2;
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
        //0. check xem can phai noi mang khong?
        var index = CheckExitsEmployee();
        if (index != -1)//tuc la da co phan tu
        {
            Employees[index] = this;
        }else
        {
            //1. thuc hien noi rong mang ra
            if(_size >= Employees.Length)
            {
                Employee[] temp = new Employee[_size*2];
                Array.Copy(Employees, 0, temp, 0, _size);
                Employees = temp;//reference
            }
            //2. add phan tu vao mang 
            Employees[_size++] = this;
           
        }

    }
    /*Kiem tra xem id cua employee da ton tai chua*/
    private int CheckExitsEmployee()
    {
        if(Employees.Length != 0) //mang co phan tu
        {
            for(int i = 0; i < Employees.Length; i++)
            {
                if(Employees[i] is not null && Employees[i].Id == Id)
                {
                    return i;
                }
            }
        }
        return -1;//khong tim thay employee nao co id da co
    }


    //display all employee (procedure)
    public void Display()
    {
        for(int i = 0; i < _size; i++)
        {
            Console.WriteLine(Employees[i]);
        }
    }
}
