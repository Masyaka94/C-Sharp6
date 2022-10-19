/*41. Пользователь вводит с клавиатуры M чисел. Сколько чисел больше 0 ввел пользователь.*/

void FillArray(int[] massive)
{
for (int index = 0; index<massive.Length; index++)
{
Console.Write($"Введите число для формирования массива:  ");
massive[index]= int.Parse(Console.ReadLine()!);
}
}

Console.Write($"Введите размер массива:  ");
int x = int.Parse(Console.ReadLine()!);
int[] array = new int [x];
int count = 0;
FillArray(array);

for (int i = 0; i<array.Length; i++)
 	{
	if (array [i] > 0) count ++;
	}
Console.Write($"Количество чисел больше нуля равно {count}");