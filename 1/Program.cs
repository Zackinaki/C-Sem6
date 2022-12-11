Console.Clear();
// Генерация случайных дробных чисел
//                                        * (end - begin) + begin
double number = new Random().NextDouble() * (50 - 10) + 10; // [0, 1]
// [begin; end]
Console.WriteLine(number);


// Console.Clear();
// // Генерация случайных дробных чисел
// //                                        * (end - begin) + begin
// double number = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2); // [0, 1]
// // [begin; end]
// Console.WriteLine(number);
