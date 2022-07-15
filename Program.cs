
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных 
// координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти: ");
int part = Convert.ToInt32(Console.ReadLine());

if (part == 1){
    Console.WriteLine("Диапазон первой четверти: x > 0, y > 0");
}
if (part == 2){
    Console.WriteLine("Диапазон второй четверти: x < 0, y > 0");
}
if (part == 3){
    Console.WriteLine("Диапазон третьей четверти: x < 0, y < 0");
}
if (part == 4){
    Console.WriteLine("Диапазон четвертой четверти: x > 0, y < 0");
}