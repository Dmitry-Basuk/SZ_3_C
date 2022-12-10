/* напишите программу, которая на вход принимает координаты 2-х точек и находит расстояние между ними в 2-d пространстве.
A(3,6); B(2,1) --> 5,09
A(7,-5); B(1,-1) --> 7,21
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
        Console.WriteLine("Ввели не число, введите число");
    }
  }
  return result;
} 
double GetDistance(int x1, int x2, int y1, int y2)
{
    // корень((x2-x1)^2+(y2-y1)^2)
    return Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2-y1,2));
}
int x1 = GetNumber("Введите координату x для первой точки");
int y1 = GetNumber("Введите координату y для первой точки");
int x2 = GetNumber("Введите координату x для второй точки");
int y2 = GetNumber("Введите координату y для второй точки");

double distance = GetDistance(x1,x2,y1,y2);

Console.WriteLine($"Расстояние между точками составляет {distance}");