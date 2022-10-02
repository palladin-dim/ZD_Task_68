/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */

Console.Clear();
int m = InputNumbers("Введите неотрицательное число m: ");
int n = InputNumbers("Введите неотрицательное число n: ");

int functionAkkerman = Akkerman(m, n);
Console.Write($"A(m,n) = {functionAkkerman} ");

int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;
    else if(m > 0 && n == 0)
    {
        return Akkerman(m-1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n -1));
    }
    return Akkerman(m, n);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}