//Задача:
// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше или равна 3 символа.
// Первоночально массив можно ввести склавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string [] Text;
Console.WriteLine("Введите массив через пробел");
string text = Console.ReadLine();
Text = text.Split(' ');
var result = new string[text.Length];
var res = 0;

foreach (var item in Text)
{ 
      
    if(item.Length <= 3)
    {
        result[res] = item;
        res++;
        
    }
    
}
Console.WriteLine(string.Join(",",result,0,res));