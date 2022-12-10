/*
Напишите программу, котороя принимает на вход число (N) и выдает таблицу квадратов чисел
от 1 до N.
5 -> 1,4,9,16,25
2 -> 1,4
*/
int GetNumber(string massage)
{
  bool isCorrect = false;
  int result = 0;

  while(!isCorrect)
  {
    Console.WriteLine(massage);

    if(int.TryParse(Console.ReadLine(), out result))
    {
        isCorrect = true;
    }
    else
    {
        Console.WriteLine("Ввели не число или 0, введите корректное число");
    }
  }
  return result;
}

void PrintSquareTable(int number)
{
    for (int i = 1; i <= number; i++)
    {
       Console.Write($"{i*i},"); 
    }
}
int number = GetNumber("Введите число");
PrintSquareTable(number);