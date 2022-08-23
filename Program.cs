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
int i1 = 0;
int sum = 0;
while (numbers.Length > i1) {sum += int.Parse(Convert.ToString(numbers[i1])); i1++;}
Console.WriteLine(sum);
//Задача 29
Console.WriteLine("Введите длину масива");
int N = Convert.ToInt32(Console.ReadLine());
int[] NArray = new int[N];
int i2 = 0;
string Znak = ",";
Console.Write("[");
while ( i2 < NArray.Length)
{
 NArray[i2] = new Random().Next(1,99);
 if (i2 == NArray.Length-1) {Znak = "]";}
 Console.Write(NArray[i2] + Znak);
  i2++;
}
