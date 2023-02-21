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

}
Task_1();
Task_2();