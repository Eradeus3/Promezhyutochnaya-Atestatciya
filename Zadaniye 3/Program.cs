// Задача 3
// void Main()
// {
//     int[] num = new int[] { 1, 2, 5, 0, 10, 34 };
//     Print2(num);
// }
// Main();
//   static void Print2(int[] num)
//         {
//             if (num.Length == 0) return;
//             else
//             {
//                 Print2(num.Skip(1).ToArray());
//                 Console.Write(" " + num[0]);
//             }
//         }