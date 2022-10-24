/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2             1, -7, 567, 89, 223-> 3     */


void InputArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
        Console.Write($"Введите {i + 1}-е число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
   }
}
int PositiveNumbers(int[] array)
{
   int numberP = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i]  > 0)
         numberP++;
   }

   return numberP;
}
Console.Clear();
Console.Write("\nВведите количество чисел:\t ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"\n{string.Join(", ", array)}\t");
Console.WriteLine($"\nКоличество чисел > 0 равно: {PositiveNumbers(array)}\t");

