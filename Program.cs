//Задача 25
Console.WriteLine("число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("число B");
int B = Convert.ToInt32(Console.ReadLine());
int i = 1;
int st = A;
while (i < B) {st = st * A; i++;} 
Console.WriteLine(st);
//Задача 27