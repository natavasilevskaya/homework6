//Программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

// метод принимает на вход значения коэффициентов
void InputCoefficients()
{
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Input the coefficients equation of {i+1} (y = k * x + b):\n");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) 
      {
        Console.Write($"Input the coefficient k: ");
      }
      else Console.Write($"the coefficient b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

//метод выполняет решение и возвращает его
double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}
    
InputCoefficients();
Console.Write($"Point of intersection of lines ({crossPoint[0]}, {crossPoint[1]})" + Decision(coeff));
