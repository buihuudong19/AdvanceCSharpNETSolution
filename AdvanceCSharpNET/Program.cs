using AdvanceCSharpNET.Entities;
namespace Manager.Employees;
public class Program
{
    public static void Main()
    {
        //Tao ra 1 doi tuong Employee 
        Employee e = new Employee();
        e.Id = 1;
        e.Name = "Bui Huu Dong";
        e.Address = "Quan 10, TPHCM";
        e.Dob=new DateOnly(1983,03,19);//Overloading (nap chong/qua tai)
        e.WorkHour = 25;
        e.SalaryRate = 250_000; //number literal

        Employee e2 = new Employee(2,"Tran Hau Binh",new DateOnly(2002,10,10), "Quan 2, TPHCM", 23, 300_000);

        Employee e3 = new Employee();
        //var/dynamic

        int[] array = null;
        Console.WriteLine(array?.Length);

        Console.ReadLine();
        
    }
}
