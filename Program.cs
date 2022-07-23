// See https://aka.ms/new-console-template for more information

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N, КРАТНЫЕ ТРЕМ.

/*void Zadacha64()
{
    Console.WriteLine("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Recursion();

    void Recursion()
    {
        if (M>N) return;
        M++;
        if (M%3==0)
        Console.Write(M + "\t");
        Recursion();
    }      
}    
Zadacha64();*/


// Задача 66: Задайте значения M и N. Напишите программу, которая найдет сумму 
// натуральных элементов в промежутке от M до N.

/*void Zadacha66()
{
    Console.WriteLine("Введите число M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Recurcion(M, N);

    void Recurcion(int M, int N, int sum = 0)
    {
        if (M>N)
        { 
        Console.WriteLine(sum);
        return;
        }
        sum += M;
        M++;
        Recurcion(M, N, sum);        
    }   
}    
Zadacha66();*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

void Zadacha68()
{
int m = 3;
int n = 2;
int FunctionAkkerman = A (m, n);

Console.Write("Функция Аккермана; результат расчета: " + FunctionAkkerman);

int A(int m, int n)
{
  if (m == 0) return n + 1;
  else if (m > 0 && n == 0) return A(m - 1, 1);
  else return A(m - 1, A(m, n - 1));
}

}
Zadacha68();






