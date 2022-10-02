// генератор псевдослучайных чисел new Random().Next(min,max)
// даст случайное целое число от min до  max-1 [min, max] или [min, max)
int numberA = new Random().Next(1,10) ;// 0 1 2...9
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
