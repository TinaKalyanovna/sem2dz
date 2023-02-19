// 10. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

/*


Console.Write("Ввести трехзначное число: ");

var threeDigitNumber = Convert.ToInt32(Console.ReadLine());

var stringNumber = Convert.ToString(threeDigitNumber);

Console.WriteLine("вторая цифра трехзначного  числа " + stringNumber[1]);


//13. Напишите программу, которая выводит третью цифру заданного 
// семизначного числа или сообщает, что третьей цифры нет.



Console.Write("Введи семизначное число: ");

var sevenDigitNumber = Convert.ToInt32(Console.ReadLine());

var stringNumber = Convert.ToString(sevenDigitNumber);

if (stringNumber.Length > 2)
 {
  Console.WriteLine("третья цифра > " + stringNumber[2]);
 }
else 
 {
  Console.WriteLine("> третьей цифры нет");
 }



// ДОП: если третья с конца 


Console.Write("Введи семизначное число: ");

var sevenDigitNumber = Convert.ToInt32(Console.ReadLine());

var stringNumber = Convert.ToString(sevenDigitNumber);

if (stringNumber.Length > 4)
 {
  Console.WriteLine("третья цифра > " + stringNumber[4]);
 }
else 
 {
  Console.WriteLine("> третьей цифры нет");
 }




// 15. Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write("Введи цифру, обозначающую день недели: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber > 5 )
{
    Console.WriteLine("этот день является выходным " + dayNumber);
}
else
{
    Console.WriteLine(" этот день НЕ является выходным " + dayNumber);
}

*/
