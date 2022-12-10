/* Напишите программу, которая по заданному номеру четверти, показывает диапозон возможных коодинат точек в этой четверти (х и у).
*/

int GetNumber(string massage)
{
  bool isCorrect = false;
  int result = 0;

  while(!isCorrect)
  {
    Console.WriteLine(massage);

    if(int.TryParse(Console.ReadLine(), out result) && result >= 1 && result <= 4)
    {
        isCorrect = true;
    }
    else
    {
        Console.WriteLine("Ввели не корректное число");
    }
  }
  return result;
}

string GetQuarter(int number)
{
    if(number == 1)
    {
        return "Первая четверть x > 0, y > 0";
    }
    if(number == 2)
    {
        return "Вторая четверть x < 0, y > 0";    
    }
    if(number == 3)
    {
        return "Третья четверть x < 0, y < 0";
    } 
    return "Четвертая четверть x > 0, y < 0";
}
int number = GetNumber("Введите номер четверти: ");
string quater = GetQuarter(number);
Console.WriteLine(quater);
