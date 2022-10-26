using AdvancedAbtraction.abstract_class;
using AdvancedAbtraction.interfaces;

/*
    - Nếu phương thức ở lớp cha mà có từ khóa virtual thì ở lớp con sẽ override
      và khi sử dụng method này thì luôn luôn gọi hàm đó ở lớp con
 
 
 */
/*
Shape s = new Rectangle(129.22d,222d,"Red");
s.Display();
*/
IShape s = new Circle(1528.55d);
Console.WriteLine(s);



