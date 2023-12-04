using System.Runtime.InteropServices;
using System;
int heroChooseValue;
Console.WriteLine("Dobrodošli u Dungeons and Crawlesrs.");

do
{
    Console.Clear();
    Console.WriteLine("Birajte svog heroja:");
    Console.WriteLine("1. Gladijator");
    Console.WriteLine("2. Enchanter");
    Console.WriteLine("3. Marskman");
    if (int.TryParse(Console.ReadLine(), out heroChooseValue) && heroChooseValue >= 1 && heroChooseValue <= 3)
        break;

} while (true);
Console.WriteLine("Odabrali ste ...");

//funkcija za random generiranje monstera
for (int i = 0; i < 10; i++)
{
    //naišli ste na taj monster
    //funkcija biraj napad
    //monster choose attack
    //funckija provjere
    //nastavi dok ne umreš
}
Console.WriteLine("Čestitamo završili ste igru");