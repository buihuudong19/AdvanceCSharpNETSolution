/*
    Extension Method: 
      - Trong C# cho phep add mot ham vao trong mot class, kieu du lieu built-in (int, long,double...) tai thoi diem run-time
      - Cach tao ra mot Extension Method:
        + No phai nam trong mot static class
        + Ban than method do phai la static va tham so dau tien (first) phai co tu khoa
        "this"
 */
namespace Programming;
static class UtilExtensionMethod
{
    public static int Sub(this int a, int b) => a - b;
}
public class Program
{
    public static void Main()
    {
        int x = 10, y = 6;
        int z = x.Sub(y);
        Console.WriteLine(z);
    }
}

