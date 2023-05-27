Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
bool status=true;
if (num<100) {
    Console.WriteLine("третьей цифры нет");
    status=false;
}

while (num>1000){
    num=num/10;
}
if (status) Console.WriteLine(num  % 10);