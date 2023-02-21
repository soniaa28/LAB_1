///1.Дано натуральне число n. Яких цифр –парних чи непарних –більше у його записі?///
Console.OutputEncoding = System.Text.Encoding.UTF8;
static void Task_1()
{
    Console.Write("Введіть натуральне число ");
    string n = Console.ReadLine();
    char[] ch = n.ToCharArray();
    int counter_even = 0;//лічильник для парних цифр
    int counter_odd = 0;//лічильник для непарних цифр
    for (int i = 0; i < ch.Length; i++)
    {

        if (ch[i] % 2 == 0)
        {
            counter_even++;
        }
        else
        {
            counter_odd++;
        }
    }
    if (counter_even == counter_odd)
    {
        Console.WriteLine("парних і непарних цифр порівну");
    }
    else
    {
        Console.WriteLine(counter_even > counter_odd ? "більше парних цифр" : "більше непарних цифр");
    }
}

/// task2
static void Task_2()

{
    Console.WriteLine("Введіть x,y,z через пробіл");
    string[] numbers = Console.ReadLine().Split();
    int x = int.Parse(numbers[0]);
    int y = int.Parse(numbers[1]);
    int z = int.Parse(numbers[2]);

    double a = (x ^ 2 / 2) - (x ^ 4 / 24) + (x ^ 6 / 720);
    double temp = x * Math.Cos(z) - z * Math.Cos(y) + y * Math.Cos(x);
    double b = Math.Sin(3 * Math.PI / 4) + temp;
    double c = 5 * temp;
    double result = Math.Max(a, Math.Min(b, c));
    Console.WriteLine("Відповідь = " + result);


}
//Task 3
//Дано матрицю C:5x6. Утворити і надрукувати вектор a,
//елементами якого є максимальні елементи рядків матриці C.
//Знайти номер мінімального елемента вектора a.
static void Task_3() 
{
    int[,] matrix = new int[,] {
            {21, -4, -1, 12, 7, 1}, {-5, 12, -7, 0, 33, -17}, {11, 4, -8, 25, -3, 6},
            {9, 33, -5, -1, 17 ,-22}, {0,13,-6,3,-1,24}
            };

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine("\n");
    }
    int[] vector = new int[6] ;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int max_number = matrix[0, j];
        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            max_number = matrix[i, j] < max_number ? max_number : matrix[i, j];
        }
        vector[j]=max_number;
    }

    Console.Write("Вектор максимальних елементів рядків матриці : ");
    foreach (int i in vector)
    {
        Console.Write($"{i}  ");
    }
    int min_index = 0;
    for (int i = 0; i < vector.Length; i++) 
    {
        if (vector[i] < min_index)
        {
            min_index=i;
        }
    }
    Console.WriteLine($"\nНомер мінімального елемента вектора = {min_index +1}");

}
Task_1();
Task_2();
Task_3();