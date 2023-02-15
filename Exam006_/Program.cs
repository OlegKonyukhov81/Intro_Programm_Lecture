// Задача с гирьками

int a = 1;
int b = 6;
int c = 8;
int d = 3;
int e = 4;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Maximum = ");
Console.WriteLine(max);
