// Перепутал порядок упражнений, это упражнение 1 из семинара 10

Console.Write("Number of lines are: ");

int n = int.Parse(Console.ReadLine());
           
int[][] triangle = new int[n][]; // Задаем массив массивов, в каждой "строке" которого будет "строка" треугольника Паскаля

triangle[0] = new int[] { 1 }; // Вершина
 
for (int i = 1; i < triangle.Length; i++)
{
    triangle[i] = new int[i + 1];  
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 || j == i) // Приравнием к 1 любые "граничные" элементы
        triangle[i][j] = 1;
        else
        {
            triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j]; // Получение значения через сумму 
        }
    }
}
 
for (int i = 0; i < triangle.Length; i++) // Выводим
{
    for (int j = 0; j < triangle[i].Length; j++)
    {  
        Console.Write("{0} ", triangle[i][j]); // Видимо, каким-то образом нужно добавить "счетчик пробелов", добавляя их определенное кол-во перед выводом 
    }
        Console.WriteLine();
}