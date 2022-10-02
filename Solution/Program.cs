// Наптсать программу, которая из имеющегося массива строк формирует массив строк
// длина которых меньше или равна три символа
Console.Write("Введите сколько слов будете вводить: ");
int n= Convert.ToInt32(Console.ReadLine());
string[] Created(int n)
{
    string[] array = new string[n];
    Console.Write("Введите первое слово: ");
    for (int i=0; i<n; i++)
        {
            if (i<n-1) 
            {
                array[i]= Console.ReadLine();
                Console.Write("Следующее: ");
            }
            else array[i]= Console.ReadLine();
        }
    return array;
}
string[] mas = Created(n);
string len=""; int m=1;
for (int i = 0; i < mas.Length; i++)
    {
        len=mas[i];
        if (len.Length<=3) m=m+1;
    }
string[] mas1 = new string[m];int j=0;
for (int i = 0; i < mas.Length; i++)
    {
        len=mas[i];
        if (len.Length<=3) 
            {
                mas1[j]=len;j++;
            }
    }
Console.WriteLine("Слова состоящие из трех или меньше символов:");
for (int i=0; i < mas1.Length; i++)
    {
        Console.Write($" {mas1[i]} ");
    }