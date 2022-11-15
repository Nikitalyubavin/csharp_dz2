//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
//Пример вывода: 6 -> да
//               7 -> да
//               1 -> нет

int a;

while (true)
{
    Console.Write("Введите цифру от 1 до 7, обозначающую день недели: ");
        if (int.TryParse(Console.ReadLine(), out a))
            break;
    Console.WriteLine("Ошибка ввода!");
}

if (a == 6 ^ a == 7)
    Console.WriteLine($"{a} -> да");
else if (a > 7)
    Console.WriteLine($"{a} -> нет такого дня недели!");
else
    Console.WriteLine($"{a} -> нет");