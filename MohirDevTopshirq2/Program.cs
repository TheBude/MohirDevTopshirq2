Console.WriteLine("Assalomu allaykum menga uzingizni tanishtiring");

Console.Write("Ismingiz: ");
string name = Console.ReadLine();

Console.WriteLine($"Tanishganimdan Xursandman hurmatli {name} !\n Men +, -, *, / uchun muljalangan kalkulyotor dasturman.");

Console.Write("1-sonni kiriting: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("bu son ustida qaysi amalni bajarmoqchisiz +, -, *, / kiritinhg: ");
char amal = Convert.ToChar(Console.ReadLine());

Console.Write("2-sonni kiriting: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int add = num + num1;
int subtraction = num - num1;
int multiply = num * num1;
int divide = num / num1;

Console.WriteLine($"Qo'shganda: {add}\nAyirganda: {subtraction}\nKo'paytirganda: {multiply}\nBo'lganda: {divide}");
