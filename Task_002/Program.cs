Console.Write("Введите начальное число (M): ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конечное число (N): ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат функции Аккермана {M} до {N}: ");
Console.WriteLine(AkermanFunctions(M, N));

int AkermanFunctions(int M, int N)

{
  if (M == 0) return N + 1;
  else if (N == 0) return AkermanFunctions(M - 1, 1);
  else return AkermanFunctions(M - 1, AkermanFunctions(M, N - 1));
}