//можно вводить число вручную или брать рандомное
//int numA = Convert.ToInt32(Console.ReadLine());
int numA = new Random().Next(100, 1000);
Console.WriteLine($"Ваше число {numA}");
int n = numA%100/10;
Console.WriteLine($"{n}");