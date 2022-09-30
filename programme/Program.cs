// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

string[] arrayStart = new string[14] {"Hello", "world", "!", "My", "name", "is", "Marina", "!", "And", "I", "have", "done", "it", ":)"};
string[] arrayFinal = new string[arrayStart.Length];
void ShortArray(string[] arrayStart, string[] arrayFinal)

{
    int count = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
    if(arrayStart[i].Length <= 3)
        {
        arrayFinal[count] = arrayStart[i];
        count++;
        }
    }
}

