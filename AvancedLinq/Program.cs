using System.Linq;
string[] data = { "Dong", "Binh", "Hau", "Dung", "Anh Duc", "Danh", "Ma Van Meo","Kheo" };

/*Standard Query Operators */
/*Sap xep tang dan theo mang data*/

dynamic dataSorted = data.OrderBy(s => s.Length);

/*Lay ra tat ca name ma khong chua 'n'*/
/*string, bool*/
bool fn(string s) => !s.Contains('n');
dataSorted = data.Where(fn);

dataSorted = data.Where(s => !s.Contains('n'))
               .OrderBy(e=>e);


foreach (var item in dataSorted)
{
    Console.WriteLine(item);
}

/*Query Expression*/
/*Lay ra tat ca cac name ma chua "n"*/
Console.WriteLine(new String('*',50));

var dataString = from n in data
                 where n.Contains("n")
                 select n;

/*
    select *
    from data
    where data.name like '%n%';
 
 */
/*decorator/decoration*/
foreach (var item in dataString)
{
    Console.WriteLine(item);
}
/*Fluent API/ anotations => check trong Entity Framework Core*/