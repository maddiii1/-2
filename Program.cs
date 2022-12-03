// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
/*
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

    
if (number < 100 || number > 1000)
{
    Console.Write("Число не трёхзначное");
}
else
{
    Console.Write("Вторая цифра: "+ (number/10)%10);
}
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
/*
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number<100){
    Console.Write("Третьей цифры нет");
} 
else{
    for(;number>=1000;number/=10);{
        number%=10;
    }
    Console.Write("Третье число: "+ number);
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
   
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 7 || number == 6)
{
    Console.Write("Этот день выходной");
}
else
{
    if (number>0 && number<6){
        Console.Write("Число " + number+ " не является выходным днём");
    }
    else if (number<1 || number > 7 ){
         Console.Write("Нет такого дня недели :)");
    }
    
}


