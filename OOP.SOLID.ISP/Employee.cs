namespace OOP.SOLID.OCP;
public class Employee
{
    
    public int Id { get; set; }
    public int WorkHour { get; set; } = 0;
    public double SalaryRate { get; set; } = 1.0d;
    public string? Name { get ; set ; }//Expression-body
    public DateOnly Dob { get ; set ; }
    public string Address { get ; set ; }
    public string Type { get ; set ; } //Fresher, Junior, Senior, Major, TeamLeader...

    public Employee()
    {
    }

    public Employee(int id, string? name, DateOnly dob, string address, int workHour, double salaryRate )
    {
        Id = id;
        WorkHour = workHour;
        SalaryRate = salaryRate;
        Name = name;
        Dob = dob;
        Address = address;
    }

    public override string? ToString() => $"Id: {Id}, Name: {Name}, Dob: {Dob}, Address: {Address}, Work Hourly: {WorkHour}, Salary Rate: {SalaryRate}";
    
}
