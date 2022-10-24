namespace AdvanceCSharpNET.Entities;
public class Person
{
    //Note: lop con ke thua all cac thuoc tinh va filed non private
    private string? _name;
    private DateOnly _dob;
    protected string _address;

    public string? Name { get => _name; set => _name = value; }//Expression-body
    public DateOnly Dob { get => _dob; set => _dob = value; }
    public string Address { get => _address; set => _address = value; }

    public Person()
    {
    }

    public Person(string? name, DateOnly dob, string address)
    {
        Name = name;
        Dob = dob;
        Address = address;
    }

    public virtual string?  Print() => $"Name: {Name}, Dob: {Dob}, Address: {Address}";
 
}

