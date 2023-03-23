// Собрать строку с числами от а до b, a <= b.


// string NumbersFor (int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }
 
// string NumbersRec (int a, int b)
// {
//     if (a < b) return $"{a} " + NumbersRec (a + 1, b);
//     else return $"{b}";
// }

//  Console.WriteLine(NumbersFor(1, 10));
//  Console.WriteLine(NumbersRec(1, 10));

// От большего к меньшему

// string NumbersFor (int a, int b)
// {
//     string result = String.Empty;
//     for (int i = b; i >= a; i --)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec (int a, int b) // рекурсия
// {
//     if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }

//  Console.WriteLine(NumbersFor(1, 10));
//  Console.WriteLine(NumbersRec(1, 10));

// Требуется найти сумму чисел от 1 до N :

// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++) result +=i;
//     return result;
// }

// int SumRec(int n) // рекурсия
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));

// Факториал числа

// int FaktorialFor(int n)
// {
//     int factorial = 1;
//     for (int i = 1; i <= n; i ++) factorial *= i;
//     return factorial;
// }

// int FaktorialRec(int n)
// {
//     if (n == 1) return 1;
//     else return n * FaktorialRec(n - 1);
// }

// Console.WriteLine(FaktorialFor(10));
// Console.WriteLine(FaktorialRec(10));

// Вычислить А в степени n.

// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *=a;
//     return result;
// }

// int PowerRec (int a, int n)
// {
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));

// Метод для определения количества буквенных сочетаний.
// Этот метод для двух букв, если нужно больше букв нужно добавить еще циклы.
// Но это неудобно для длинных слов :) , поэтому нужна рекурсия.

// char[] s = {'а', 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         Console.WriteLine($"{n++, -5}{s[i]}{s[j]}");
//     }
// }

// int n = 1;

// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}");  return;
//     }

//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }
// FindWords("аисв", new char[2]); // количество букв можно увеличить без добавления циклов.

// Как посмлтреть содержимое папки?

// string path = "D:/Lecture_Intro_programm/Examples/Exam007_Magic";
// DirectoryInfo di = new DirectoryInfo(path); // Для того, чтобы работать с директориями есть класс DirektoryInfo
// Console.WriteLine(di.CreationTime); // Показывает дату создания файла

// FileInfo[] fi = di.GetFiles(); // обратившись к di. хотим посмотреть файлы, находящиеся в этой папке.
//                              // результат работы этого метода (по умолчанию) есть массив типа FileInfo[]
// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);   
// }

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = "D:/Lecture_Intro_programm/Examples/Exam005_HelloMasha";
CatalogInfo(path);

// Игра в пирамидки

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with}>>{on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();