/*
 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели ->");
int ChoosingDayWeek = int.Parse(Console.ReadLine());
if (ChoosingDayWeek < 6)
{
    Console.WriteLine("День не является выходным");
}
else if (ChoosingDayWeek < 8)
{
    Console.WriteLine("Ура! Этот день выходной");

}
else
{
    Console.WriteLine("Ошибка. Нет такого дня");
}