//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Примеры: 645 -> 5
//         78 -> третьей цифры нет
//         32679 -> 6

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

string s = a.ToString();                //переводим числовое представление "а" в строковое
char[] ar = s.ToCharArray();            //создаем массив "ar" из значений каждого символа полученной строки
Array.Reverse(ar);                      //записываем полученный массив в обратном порядке
s = new String(ar);                     //присваиваем нашей строке её значение, равное значениям из обратного массива
int b = Convert.ToInt32(s);             //конвертируем строковый тип данных в числовой

if (a >= 100)
{
    int c = b % 1000;
    int result = c / 100;
    Console.WriteLine($"{a} -> {result}");
}
else   
    Console.WriteLine($"{a} -> третьей цифры нет");