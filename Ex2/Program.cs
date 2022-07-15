Console.WriteLine("Set the size of the array"); // Для простоты предположим, что массив будет квадратным
int a = int.Parse(Console.ReadLine());            
int[,] matrix = new int[a,a];
int i = 0, j = 0, i1, j1, mini=0, minj=0; // Служебные переменные-контейнеры
Random rnd = new Random();

Console.WriteLine("Created array: ");
for (i = 0; i < a; i++)
{
    for (j = 0; j < a; j++)
    {
        matrix[i,j] = rnd.Next(0, 500); // Предположим, что элементы сгенерируются без повторов
        Console.Write("{0} ", matrix[i, j]);
    }
Console.Write("\n");
}

for (i = 0; i < a; i++)
{
    for (j = 0; j < a; j++)
    {
    if (matrix[i, j] < matrix[mini, minj]) // Находим наименьший элемент и его координаты, сохраняем координаты
        {
        mini = i;
        minj = j;
        }                    
    }
}

Console.WriteLine("\nMin element is: {0}", matrix[mini, minj]);
Console.WriteLine("New array: ");

// Наверняка как-то можно преобразовать исходный массив, однако, фактически будет работать создание нового со стороной a-1
int[,] matrix2 = new int[a-1, a-1];
// Заполним его "оставшимися" значениями из нашего предыдущего, смещая индексы

for (i = 0; i < a-1; i++)
{
    if (i >= mini)
    {
    i1 = i + 1;
    }
    else
    {
    i1 = i;
    }
        for (j = 0; j < a-1; j++)
        {
            if (j >= minj)
            {
            j1 = j + 1;
            }
                else
                {
                j1 = j;
                }
                    matrix2[i, j] = matrix[i1, j1];
                    Console.Write("{0} ", matrix2[i, j]);
        }
Console.Write("\n");
}