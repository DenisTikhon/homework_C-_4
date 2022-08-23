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

