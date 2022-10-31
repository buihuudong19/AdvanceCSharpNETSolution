/*
    Delegate (Uy nhiem/dai dien cho mot viec gi day): 
    - Kiểu dữ liệu 
    - Sẽ đại diện cho một hoặc nhiều function nào đó. Nói cách khác, đối tượng có kiểu
    Delegate sẽ tham chiếu tới địa chỉ của HÀM mà ta muốn => thay vì gọi hàm thì ta
    sẽ gọi thông qua delegate
 */
namespace Programming;
public class Program
{
    public static int Sum(int a, int b) => a + b;
    public static void Main()
    {
        Func<int, int, int> func = (a,b)=>(a+b)*2;
        int result = func.Invoke(10, 11);

        Action<string> action = Console.WriteLine;
        action.Invoke("Hello world");



        Console.WriteLine($"Total is: {result}");  
        Console.ReadLine();
    }
}