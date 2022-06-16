string[] array={"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
Console.WriteLine("Введите номер дня недели ");
int numberOfWeek = Convert.ToInt32(Console.ReadLine());
if(numberOfWeek > 7) Console.WriteLine("Дня недели с таким порядковым номером не существует!");
int index = numberOfWeek - 1;
Console.Write("Этот день недели - ");
Console.WriteLine(array[index]);


