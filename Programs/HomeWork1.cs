using static Shares;

public class HomeWork1
{
// Задача 1
// Реализвать перемешивание массива
public static void Ex001Main()
{
 int count = Input("Введите размер массива ");
 int[] numbers = CreateArray(count);
 Print1(numbers);
 FillByUser(numbers);
 Print1(numbers);
 }
}
