// Найти нужный элемент используя метод.

void FillArray(int[] collection)
{
    int length = collection.Length;
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

// Будем создавать метод отличный от void, он будет возвращать позицию (нам нужен индекс). 

int IndexOf(int[] collection, int find) //Назовем этот метод IndexOf, приходить будет массив  collection и элемент find
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index ++;
    }
    return position;
}


int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine(); // Разделительная пустая полоса, чтобы разделить массив array от pos.

int pos = IndexOf(array, 4); // создаем переменную pos и присваиваем ей результат работы IndexOf, 
                             // который будет работать с нашим массивом array и искать 4.
Console.WriteLine(pos);
