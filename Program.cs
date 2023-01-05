// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
int[] ConvertArray(int[] result, string[] strArr)
{
    int num = 0;
    for (int i = 0; i < result.Length; i++)
    {
       if(Convert.ToInt32(strArr[i]) != 0)
       {
        result[i] = Convert.ToInt32(strArr[i]);
        num++;
       }
    }
    int[] newResult = new int[num];
    int numNew = 0;
    int countPrint = 0;
    foreach(int item in result){
        if(item != 0){
             newResult[numNew] = item;
             numNew++;
             if(item > 0){
                countPrint++;
             }
        }
    }
    Console.WriteLine("В массиве [{0}] , символов больше 0:  " + countPrint, string.Join(", ", newResult));
    return newResult;
}

Console.WriteLine("Введите числа через запятую:");
string? numStr = Console.ReadLine();


if (!string.IsNullOrEmpty(numStr))
{
    string[] arrNumbers = new string[numStr.Length];
    // количество символов
    int key = 0;
    for (int i = 0; i < arrNumbers.Length; i++)
    {
        if (numStr[i] == ',' || numStr[i] == ' ')
        {
            key++;
        }
        else // Иначе
        {
            arrNumbers[key] = arrNumbers[key] + numStr[i];
        }
    }
    key++;
    int[] result = new int[key];
    int[] arreyNums = ConvertArray(result, arrNumbers);
    
}
else
{
    Console.WriteLine("Пожалуйста, введите строку из чисел, пример: 1, 2, 3, 4 или числа через пробел");
}