
// задание 1
// PrintHeader("2");
// PrintHeader("1");

//задание 2.1
// Console.WriteLine(Max(3, 5));    
// Console.WriteLine(Max(10, 4));   
// Console.WriteLine(Max(-7, -2));  

// задание 2.2 
// Console.WriteLine(IsEven(4));    
// Console.WriteLine(IsEven(7));    
// Console.WriteLine(IsEven(0));    

// задание 3
// int[] marks = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(Average(marks));           
// Console.WriteLine(CountGreater(marks, 100));

// задание 4 
// Console.WriteLine($"{ToFahrenheit(0)} °F");  
// Console.WriteLine($"{ToFahrenheit(100)} °F"); 
// Console.WriteLine($"{ToFahrenheit(37)} °F"); 

// задание 5
// Console.WriteLine(Factorial(5)); 
// for (int i = 2; i <= 50; i++)
// {
//     if (IsPrime(i)) Console.Write(i + " ");
// }
// Console.WriteLine();

// задание 6
// int a6 = ReadPositive("первое число: ");
// int b6 = ReadPositive("второе число: ");
// Console.WriteLine($"cумма: {a6 + b6}");

// доп
// Console.WriteLine(Gcd(48, 18)); 
// Console.WriteLine(Lcm(4, 6));   



// задание 1
// static void PrintLine()
// {
//      Console.WriteLine("------------");
//  }

//  static void PrintHeader(string title)
//  {
//      PrintLine();
//      Console.WriteLine(title);
//      PrintLine();
//  }

// // задание 2.1
// static int Max(int a, int b)
// {
//     if (a > b) {
//         return a;
//     } else {
//         return b;
//     }
// }

// // задание 2.2
// static bool IsEven(int n)
// {
//     return n % 2 == 0;
// }

// // задание 3
// static int SumArray(int[] arr)
// {
//     int sum = 0;
//     foreach (int x in arr)
//     {
//         sum += x;
//     }
//     return sum;
// }

// static double Average(int[] arr)
// {
//     return (double)SumArray(arr) / arr.Length;
// }

// static int CountGreater(int[] arr, int limit)
// {
//     int count = 0;
//     foreach (int x in arr)
//     {
//         if (x > limit)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// // задание 4
// static double ToFahrenheit(double celsius)
// {
//     return celsius * 9 / 5 + 32;
// }

// // задание 5
// static long Factorial(int n)
// {
//     long result = 1;
//     for (int i = 2; i <= n; i++)
//     {
//         result *= i;
//     }
//     return result;
// }

// static bool IsPrime(int n)
// {
//     if (n < 2) return false;
//     for (int i = 2; i * i <= n; i++)
//     {
//         if (n % i == 0) return false;
//     }
//     return true;
// }

// // задание 6
// static int ReadPositive(string message)
// {
//     int a;
//     do
//     {
//         Console.Write(message);
//         a = int.Parse(Console.ReadLine());

//     } while (a <= 0);

//     return a;
// }

// // доп
// static int Gcd(int a, int b)
// {
//     while (b != 0)
//     {
//         int temp = b;
//         b = a % b;
//         a = temp;
//     }
//     return a;
// }

// static int Lcm(int a, int b)
// {
//     return a / Gcd(a, b) * b;
// }
// меню 
int choice;
do
{
    Console.WriteLine("\n1 - сумма двух чисел");
    Console.WriteLine("2 - большее из двух чисел");
    Console.WriteLine("3 - факториал");
    Console.WriteLine("0 - выход");
    Console.Write("выберите пункт: ");
    
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            int a = ReadPositive("первое число: ");
            int b = ReadPositive("второе число: ");
            Console.WriteLine($"рез: {Sum(a, b)}");
            break;
        case 2:
            int c = ReadPositive("первое число: ");
            int d = ReadPositive("второе число: ");
            Console.WriteLine($"рез: {Max(c, d)}");
            break;
        case 3:
            int n = ReadPositive("число: ");
            Console.WriteLine($"рез: {Factorial(n)}");
            break;
        case 0:
            Console.WriteLine("выход из программы.");
            break;
        default:
            Console.WriteLine("нет такого пункта");
            break;
    }
} 
while (choice != 0);


static int Sum(int a, int b)
{
    return a + b;
}

static int Max(int a, int b)
{
    return a > b ? a : b;
}

static long Factorial(int n)
{
    long result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

static int ReadPositive(string message)
{
    int num;
    do
    {
        Console.Write(message);
        num = int.Parse(Console.ReadLine());
    } while (num <= 0);
    return num;
}