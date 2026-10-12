using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;

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


Console.WriteLine("Вариант А");
int[] numbers = [34, 5, 4, 6, 7];
int total = 0;
foreach (int number0 in numbers)
{
    Console.WriteLine(number0);
    total += number0;
}
Console.WriteLine(total);


Console.WriteLine("Вариант Г");
int[] grade0 = [2, 3, 5, 4];
int maxGrade = 0;
foreach (int grades0 in grade0)
{
    if (maxGrade < grades0)
    {
        maxGrade = grades0;
    }

}
Console.WriteLine(maxGrade);


Console.WriteLine("Вариант 5");
string[] booksName = ["Белые ночи", "Ночь в Лиссабоне", "Онегин"];
string word = "Онегин";
bool found = false;   
foreach (string book in booksName)
{
    if (word == book)
    {
        Console.WriteLine("Найдено");
        found = true;
        break;
    }
    
}
if (!found)
{
    Console.WriteLine("Не найдено");
}


Console.WriteLine("Вариант 9");
int[] numbers1 = [9, 8, 7];
for (int num = 0; num < numbers1.Length; num++)
{
    numbers1[num] = numbers1[num] + 1;
    Console.WriteLine(numbers1[num]);
}