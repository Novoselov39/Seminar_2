﻿Console.Clear();
Console.WriteLine("Введите номер дня в неделе");
int num = int.Parse(Console.ReadLine());

if (num==6 || num==7) {
    Console.WriteLine("да");
    
}

else{
    Console.WriteLine("нет");
}