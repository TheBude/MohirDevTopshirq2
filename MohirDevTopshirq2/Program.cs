Console.Write("Sonni kiriting: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= N; i++)
{
    sum += i;
}

Console.WriteLine("Natija: " + sum);