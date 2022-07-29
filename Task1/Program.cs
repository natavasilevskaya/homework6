// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь




//Программа считает количество чисел больше 0

int AmountOfNaturalN(int[] arrayM)
{

    int[] array = new int[arrayM.Length];

    int sum = 0;

    for (int i = 0; i < arrayM.Length; i++)
    {
        if(arrayM[i] > 0 ) 
        {
            sum = sum + 1; 
        }
    }
    return sum;
}

Console.Write("Input numbers: ");
int[] myArray = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);

Console.WriteLine("Amount of numbers which > 0 is  " + AmountOfNaturalN(myArray));




