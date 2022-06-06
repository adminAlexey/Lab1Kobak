List<int> list = new List<int>();
Console.WriteLine("ЛАБА 1, Вариант 7");
Console.WriteLine("20-25 заданий с диапазоном сложности 20-35");
Console.WriteLine("Введите количество заданий");
int kol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сложность для каждого задания");

for (int i = 0; i < kol; i++)
{ 
    list.Add(Convert.ToInt32(Console.ReadLine()));
}
Console.Clear();
Console.WriteLine("До сортировки");
for (int i = 0; i < list.Count; i++)
{
    Console.Write(list[i]+" ");
}
list.Sort();
Console.WriteLine();
Console.WriteLine("После сортировки");
for (int i = 0; i < list.Count; i++)
{
    Console.Write(list[i] + " ");
}


int a = list[list.Count-1];
int b = list[list.Count - 2];
List<int> cpu1 = new List<int>();
cpu1.Add(list[list.Count - 1]);
List<int> cpu2 = new List<int>();
cpu2.Add(b);
for (int i = list.Count-3; i >=0 ; i--)
{
    if (a <= b)
    {
        cpu1.Add(list[i]);
        a+=list[i];
    }
    else
    {
        cpu2.Add(list[i]);
        b += list[i];
    }
}
Console.WriteLine();
Console.WriteLine("Первый процессор");
for (int i = 0; i < cpu1.Count; i++)
{
    Console.WriteLine(cpu1[i]);
}
Console.WriteLine("Второй процессор");
for (int i = 0; i < cpu2.Count; i++)
{
    Console.WriteLine(cpu2[i]);
}