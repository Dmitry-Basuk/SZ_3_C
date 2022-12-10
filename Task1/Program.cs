/* 
напишите программу которая на вход принимает координаты  (X , Y) причем X,Y не = 0 и выдает номер четверти плоскости, в которой находится эта точка.
*/

// Получение числа с консоли 
int GetNumber(string massage)
{
  bool isCorrect = false;
  int result = 0;

  while(!isCorrect)
  {
    Console.WriteLine(massage);

    if(int.TryParse(Console.ReadLine(), out result) && result != 0)
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
int GetQuarter(int x , int y)
{
   if(x > 0 && y > 0)
       return 1;
   if(x < 0 && y > 0)
       return 2;
   if(x < 0 && y < 0)
       return 3;
    return 4;
}

int x = GetNumber("Введите x:");
int y = GetNumber("Введите y:");

int quarter = GetQuarter(x,y);

Console.WriteLine($"Точка с координатами ({x},{y}) лежит в {quarter} четверти");