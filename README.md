# Итоговая проверочная работа

## Задание

*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.*


 * Блок-схема
<image src="flowchart.png" alt="Текст с описанием картинки">

 * Код

```
string[] stringArray1 = { "he", "llo", "world", "-2", "123" };
string[] stringArray2 = new string[5];

GetStringArray(stringArray1);
System.Console.WriteLine(string.Join(" ", stringArray2));


void GetStringArray(string[] str)
{
    int count = 0;
    for (int i = 0; i < stringArray1.Length; i++)
    {
        if (stringArray1[i].Length < 4)
        {
            stringArray2[count] = stringArray1[i];
            count++;
        }
    }
}

```