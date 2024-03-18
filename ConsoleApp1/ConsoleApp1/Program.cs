// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
for (var i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine(2+2*2);
for (var i = 0; i < 5; i++)
{
    Console.WriteLine('a'+i);
}

static int Srednia(List<int> list)
{
    int sum = 0;
    foreach (var i in list)
    {
        sum += i;
    }

    int average = sum / list.Capacity;
    return average;
}

static int max(List<int> List)
{
    return List.Max();
}