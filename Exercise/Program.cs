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
