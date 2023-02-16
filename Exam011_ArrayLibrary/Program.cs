// Создаем метод, передаем в него массив, далее с помощью Random заполняем массив нужным колличеством элементов






void FillArray(int[] collection) // Создаем и называем метод
{
    int length = collection.Length; // Задаем то, что нам надо получить размер массива collection
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(coll[position]);
        position ++;
    }
}

int[] array = new int[10]; //  массив array в котором создай создай новый массив в котором будет 10 элементов,
// сейчас он наполнен нулями.

FillArray(array);
PrintArray(array);







