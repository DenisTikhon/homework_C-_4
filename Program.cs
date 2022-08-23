Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("число B");
int B = Convert.ToInt32(Console.ReadLine());
int i = 1;
int st = A;
while (i < B) {st = st * A; i++;} 
Console.WriteLine(st);
//Задача 27
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string numbers = Convert.ToString(num);
int i = 0;
int sum = 0;
while (numbers.Length > i) {sum += int.Parse(Convert.ToString(numbers[i])); i++;}
Console.WriteLine(sum);
//Задача 29
Console.WriteLine("Введите длину масива");
int N = Convert.ToInt32(Console.ReadLine());
int[] NArray = new int[N];
int i = 0;
string Znak = ",";
Console.Write("[");
while ( i < NArray.Length)
{
 NArray[i] = new Random().Next(1,99);
 if (i == NArray.Length-1) {Znak = "]";}
 Console.Write(NArray[i] + Znak);
  i++;
}

