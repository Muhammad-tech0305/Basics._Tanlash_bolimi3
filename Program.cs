using System;
using System.Linq;
using System.Text;
// 1-topshiriq
Console.WriteLine("\n < PALINDROM TEKSHIRUVI > ");

Console.Write("Biror matn-so'z kiriting:\n>>> ");
string word = Console.ReadLine().ToLower();
string teskari = "";

for (int i = word.Length - 1; i >= 0; i--)
{
    teskari += word[i];
}

string natija = (teskari == word)
    ? "Bu so'z Palindrom."
    : "Bu so'z Palindrom emas.";
Console.WriteLine(natija);

// 2-topshiriq
Console.WriteLine("\n < TEMPERATURA O'GIRISH > ");

Console.Write("Selsiy bo'yicha gradusni kiriting : ");
float selsiy = float.Parse(Console.ReadLine());

switch (selsiy)
{
    default:
        Console.WriteLine($"Selsiy: {selsiy}'C");
        Console.WriteLine($"Farangeyt: {(selsiy * 9 / 5) + 32}'F");
        Console.WriteLine($"Kelvin: {selsiy + 273.15}'K");
        break;   
};

// 3-topshiriq
Console.WriteLine("\n < SONLARNI TARTIBLASH > ");

Console.Write("Nechta son kiritmoqchisiz? >>> ");
int size = int.Parse(Console.ReadLine());

Console.WriteLine("Butun sonlarni kiriting: ");
int[] sonlar = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"{i+1}-son: ");
    sonlar[i] = int.Parse((Console.ReadLine()));
}
Array.Sort(sonlar);

switch (sonlar)
{
    default:
        Array.Sort(sonlar);
        Console.Write("Tartiblangan: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{sonlar[i]}, ");
        }
        Array.Reverse(sonlar);
        Console.Write("\nTeskari tartib: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{sonlar[i]}, ");
        }
        break;
}
// 4-topshiriq
Console.WriteLine("\n < BERILGAN MATNNING SIMVOL SONINI HISOBLASH > ");

Console.Write("Istalgan matn kiriting: ");
string text= Console.ReadLine();
char[] symbols = new char[text.Length];
int[] counts = new int[text.Length];
int Count = 0;
        
foreach (char c in text)
{
    bool found = false;
    for (int i = 0; i < Count; i++)
    {
        if (symbols[i] == c)
        {
            counts[i]++;
            found = true;
            break;
        }
    }
            
    if (!found)
    {
        symbols[Count] = c;
        counts[Count] = 1;
        Count++;
    }
}
        
for (int i = 0; i < Count; i++)
{
    Console.WriteLine($"'{symbols[i]}': {counts[i]} marta");
}
