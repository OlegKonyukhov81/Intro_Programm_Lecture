// // Вид 1 (Ничего не принимает и ничего не возвращает)
// void Method1( )
// {
//     Console.WriteLine("  ");
// }
// // Как вызывается метод
// Metod1();



// // Вид2 (Ничего не возвращает, но может принимать какие-нибудь аргументы(данные))
 
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");
// // Есть аргументы именованные, это означает какому аргументу какое значение хотим задать

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i ++;
//     }
// }
// Method21(msg: "Текст", count: 4); // 4 - означает сколько раз выводить результат
// Method21(count: 4, msg: "новый текст");

// // Вид 3  - что-то возвращают, но ничего не получают

// int Method3() // если метод, что-то возвращает мы обязательно должны указать какой тип данных мы ожидаем получить
//     {
//         return DataTime.Now.Year;
//     }
// int year = Method3(); // создаем новую переменную и присваиваем ей значение результата Method3()
// Console.WriteLine(year); // - то, что возвращает метод (показывает)


// Вид 4 - методы, которые что-то принимают и что-то возвращают.
// string Method4(int count, string text)// дословно: возвращаем строку, в метод передаем int count и тип данных char
// {
//     int i=0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i ++;
//     }
//     return result;
// }
// // Чтобы вызвать метод, необходимо создать нужную переменную,

// string rez = Method4(10, "z");
// Console.WriteLine(rez);

// Работа с текстом
// Дан текст. В тексте нужно заменить все пробелы звездочками, 
// маленькие буквы к заменить на большие К, а большие С заменить 
// маленькими с.

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//      string s = "qwerty"
//                  0123...
//      s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; //создаем пустую строку (String.Empty) result
    int length = text.Length; // text.Length - свойство, показывающее кол-во символов в строке
    for (int i = 0; i < length; i ++)
     {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
     }
    return result;
}

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array) // в качестве аргумента будет приходить массив (array)
{
    int count = array.Length;
    for (int i = 0; i < count; i +=1)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i +=1) // -1, чтобы j невышло за пределы массива.
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j ++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array [minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);