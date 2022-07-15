//  С сайта Микрософст https://docs.microsoft.com/en-us/dotnet/api/system.string.tochararray?view=net-6.0 забираем метод преобразования строки в массив
 
Console.WriteLine("Enter the first string");
string str1 = Console.ReadLine();
string str1l = str1.ToLower(); // Переводим все символы в строчные 
string str1lnospaces = str1l.Replace(" ", ""); // Удаляем пробелы
char[] c1 = str1lnospaces.ToCharArray(); // Передаем все символы в массив
Console.WriteLine("Sorted symbols in the first string is:");
for (int i = 0; i< c1.Length; i++)  
{
    Array.Sort(c1); // Сортируем элементы (уже являющиеся строчными буквами) по возрастанию
    Console.Write("{0}\t", c1[i]); // Выведем в консоль для возможности проверки работосопосбности программы
}
Console.WriteLine(" ");

Console.WriteLine("Enter the second string"); // Видимо, рационально было бы сделать из этого куска отдельный метод и не повторять код
string str2 = Console.ReadLine();
string str2l = str2.ToLower(); 
string str2lnospaces = str2l.Replace(" ", "");
char[] c2 = str2lnospaces.ToCharArray(); 
Console.WriteLine("Sorted symbols in the second string is:");
for (int i = 0; i< c2.Length; i++)  
{
    Array.Sort(c2); 
    Console.Write("{0}\t", c2[i]); 
}  
Console.WriteLine(" ");

bool isEqual = Enumerable.SequenceEqual(c1, c2);
Console.WriteLine("The possibility to assemble the first line from the symbols of the second line is:");
Console.Write(isEqual);