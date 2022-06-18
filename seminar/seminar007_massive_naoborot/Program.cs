string[] array = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string[] resultArray = new string[array.Length];
for (int i = 0; i < array.Length; i++)
    resultArray[array.Length - 1 - i] = array[i];
for (int i = 0; i < array.Length; i++)
    Console.WriteLine(resultArray[i]);


