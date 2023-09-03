
using OOP.EXAMP.classes;

Book kitob = new Book(BookName: "O'tgan kunlar",Name:"O'tkir Hoshimov" ) ;

kitob.betlari = 256;
kitob.narx = 20_000;
Console.WriteLine($" Kitob nomi : {kitob.kitobnomi}\n " +
    $"kitob muallifi : {kitob.kitobmuallifi} \n " +
    $"kitob betlari : {kitob.betlari} \n " +
    $"kitob narxi : {kitob.narx} \n ");
Console.WriteLine(" Narxda o'zgarish bo'lsa iltimos 1 ni bosing : ");
int x = Convert.ToInt32(Console.ReadLine());
if (x==1)
{
    Console.WriteLine("kitobning hozirgi narxi qancha :");
    int yanginarx = Convert.ToInt32(Console.ReadLine());
    kitob.narxOzgarish(yanginarx);
}
Console.WriteLine($" Kitob nomi : {kitob.kitobnomi}\n " +
    $"kitob muallifi : {kitob.kitobmuallifi} \n " +
    $"kitob betlari : {kitob.betlari} \n " +
    $"kitob narxi : {kitob.narx} \n ");