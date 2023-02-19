public class Shares 
{
  // Метод "Создать массив"

public static int[] CreateArray(int size)
{
  return new int[size];
}
// Метод "Ввод данных"
public static int Input(string text)
{
  Console.Write(text + " ");
  return Convert.ToInt32(Console.ReadLine());
}

// Заполнение руками

public static void FillByUser(int[] array)
{
  int length = array.Length;
  int index = 0;
  while (index < length)
  {
    array[index] = Input ("Введите array[" + index + "]: ");
    index++;
  }
  }

// Печать
public static void Print1(int[] array)
{
  int length = array.Length;
  int index = 0;
  while (index < length)
  {
    Console.Write(array[index] + " ");
    index++;
  }
  System.Console.WriteLine();
  }

}
