namespace OOP.SOLID.OCP;

public abstract class BaseSalaryCalculator
{
    protected Employee Employee { get;private set; }

    protected BaseSalaryCalculator()
    {
    }

    public BaseSalaryCalculator(Employee employee)
    {
        Employee = employee;
    }
    public abstract double CalculateSalary();

}

/*Dinh nghia viec tinh luong theo tung loai nhan vien*/
public class FresherEmployeeSalaryCalculator : BaseSalaryCalculator
{
    public FresherEmployeeSalaryCalculator(Employee emp) : base(emp)
    {

    }
    public override double CalculateSalary()
    {
        return Employee.SalaryRate * Employee.WorkHour * 1.05; //fresher => +5%
    }
}

public class JuniorEmployeeSalaryCalculator : BaseSalaryCalculator
{
    public JuniorEmployeeSalaryCalculator(Employee emp) : base(emp)
    {

    }
    public override double CalculateSalary()
    {
        return Employee.SalaryRate * Employee.WorkHour * 1.1; //Junior => +10%
    }
}

public class SeniorEmployeeSalaryCalculator : BaseSalaryCalculator
{
    public SeniorEmployeeSalaryCalculator(Employee emp) : base(emp)
    {

    }
    public override double CalculateSalary()
    {
        return Employee.SalaryRate * Employee.WorkHour * 1.15; //senior => +15%
    }
}

//add-on them tinh nang tinh luong cho tung loai nhan vien

public class SalaryCalculatorOCP
{
    //Muon tinh tong luong cua n nhan vien => collections chua n nhan vien

    private readonly IEnumerable<BaseSalaryCalculator> _baseSalaryCalculators;

    public SalaryCalculatorOCP(IEnumerable<BaseSalaryCalculator> baseSalaryCalculators)
    {
        _baseSalaryCalculators = baseSalaryCalculators;
    }

    //Phuong thuc tinh luong
    public double CalculateTotalSalaries()
    {
        double total = 0d;
        foreach(var empCalc in _baseSalaryCalculators)
        {
        
            total += empCalc.CalculateSalary();
        }

        return total;
    }
}



