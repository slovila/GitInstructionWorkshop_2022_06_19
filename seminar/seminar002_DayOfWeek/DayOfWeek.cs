string[] array = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

/*Console.WriteLine("Введите номер дня недели ");
int numberOfWeek = Convert.ToInt32(Console.ReadLine());
if (numberOfWeek > 7) Console.WriteLine("Дня недели с таким порядковым номером не существует!");
int count = 0;
int index = numberOfWeek - 1;
Console.Write("Этот день недели - ");
Console.WriteLine(array[index]);
Console.WriteLine("Количество символов в названии дней недели: ");
while (count < array.Length)
{

    Console.WriteLine(array[count] + "  " + array[count].Length + "   символов");
    count++;

}*/

int count = 0;
while (count < array.Length)
{
    if (array[count] == "п" || array[count] == "с")
    {
        Console.WriteLine($"Day Of Week {array[count]}" );
        count++;
    }
}

// Console.WriteLine(array[0] + array[4] + array[2] + array[5]);
