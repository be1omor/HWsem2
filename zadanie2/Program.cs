//можно вводить число вручную или брать рандомное
//int numA = new Random().Next(1, 1000000);
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ваше число {numA}");
int z = numA/1%10;
int x = numA/10%10;
int c = numA/100%100%10;
int v = numA/1000%100%10%10;

if ((numA>100) && (numA<1000)) Console.WriteLine($"{z}");
else if ((numA>=1000) && (numA<10000)) Console.WriteLine($"{x}");
else if ((numA>=10000) && (numA<100000)) Console.WriteLine($"{c}");
else if ((numA>=100000) && (numA<1000000)) Console.WriteLine($"{v}");
else Console.WriteLine($"третьей цифры нет");