using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

string subject = "Программирование";

foreach (char letter in subject)
{
    Console.WriteLine(letter);
}
Console.WriteLine($"Количество букв в слове: {subject.Length}");

int[] grades = { 4, 5, 3, 5, 4 };
int sum = 0;
foreach (int grade in grades)
{
    Console.WriteLine(grade);
    sum += grade;
}
Console.WriteLine($"Средний балл: {(double)sum / grades.Length}");


string[] students = { "Аня", "Ярослав", "Вика" };
int count = 0;
foreach (string student in students)
{
    Console.WriteLine(student);
    count += 1;
}
Console.WriteLine($"Всего учеников: {count}");


int[] points = { 10, 20, 15 };
for (int i = 0; i < points.Length; i++)
{
    points[i] = points[i] + 5;
    Console.WriteLine(points[i]);
}


string[] students2 = { "Аня", "Борис", "Вика" };
int number = 1;

foreach (string student in students2)
{
    Console.WriteLine($"{number}. {student}");
    number++;
}


Console.WriteLine("Задача А");
int[] exA = { 5, 7, 5, 9, 1 };
int sum2 = 0;
foreach (int exA2 in exA)
{
    Console.WriteLine(exA2);
    sum2 += exA2;
}
Console.WriteLine($"Сумма чисел: {sum2}");


Console.WriteLine("Задача В");
string texts = "Фамилия";
int sum3 = 0;
foreach (char text in texts)
{
    
}
Console.WriteLine();