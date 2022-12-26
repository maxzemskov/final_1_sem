# Итоговая проверочная работа
## разбор программного кода

в первой части кода вводим массив с типом данных "string".
```
Console.Write("Введите массив: ");
string[] input = Console.ReadLine().Split(" ");
```
Создаем массив output.
```
string[] final = new string[input.Length];
```
Проходим по всему массиву, пока не дойдем до последнего элемента.
```
while (i < input.Length)
```
Если длина элемента массива меньше 4, то записываем этот элемент в массив output.
```
if (input[i].Length < 4)
    {
        final[j] = input[i];
        i++;
        j++;
    }
```
Если длина элемента массива больше 3, то переходим к следующему элементу.
```
   else
    {
        i++;
    }
```
Выводим output
```
Console.Write("Output: ");
Console.WriteLine(string.Join(" ", final));
```