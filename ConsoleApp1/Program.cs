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
        Console.WriteLine(counter_even > counter_odd ? "У числі більше парних цифр" : "У числі більше непарних цифр");
    }
}

/// task2
static void Task_2()

{
    /* Console.WriteLine("Введіть x, y, z через пробіл");
     string[] numbers = Console.ReadLine().Split();
     double x = double.Parse(numbers[0]);
     double y = double.Parse(numbers[1]);
     double z = double.Parse(numbers[2]);
    */
    Console.Write("Введіть x =");
    double x = double.Parse(Console.ReadLine()) ;
    Console.Write("Введіть y =");
    double y = double.Parse(Console.ReadLine());
    Console.Write("Введіть z =");
    double z = double.Parse(Console.ReadLine());

    double a = (x *x / 2) - (Math.Pow(x,4) / 24) + (Math.Pow(x,6)/ 720);
    double temp = x * Math.Cos(z) - z * Math.Cos(y) + y * Math.Cos(x);//додаткова змінна, через повторення у виразах
    double b = Math.Sin(3 * Math.PI / 4) + temp;
    double c = 5 * temp;
    Console.WriteLine("Відповідь = " + Math.Max(a, Math.Min(b, c)));


}
//Task 3
//Дано матрицю C:5x6. Утворити і надрукувати вектор a,
//елементами якого є максимальні елементи рядків матриці C.
//Знайти номер мінімального елемента вектора a.
static void Task_3() 

{
    int[,] matrix = new int[5, 6];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(-20, 50);
        }
       
    }
    /*int[,] matrix = new int[,] {
            {21, -4, -1, 12, 7, 1}, {-5, 12, -7, 0, 33, -17}, {11, 4, -8, 25, -3, 6},
            {9, 33, -5, -1, 17 ,-22}, {0,13,-6,3,-1,24}
            };
    */


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }

    int[] vector = new int[matrix.GetLength(0)] ; //вектор для зберігання максимальних елементів 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int max_number = matrix[i, 0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            max_number = matrix[i, j] < max_number ? max_number : matrix[i, j];
        }
        vector[i]=max_number;
    }

    Console.Write("Вектор максимальних елементів рядків матриці : ");
    foreach (int i in vector)
    {
        Console.Write($"{i}  ");
    }
   
    Console.WriteLine($"\nНомер мінімального елемента вектора = {Array.IndexOf(vector, vector.Min()) +1}");

}


Task_1();
Task_2();
Task_3();