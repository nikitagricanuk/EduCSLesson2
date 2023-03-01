int digit = Convert.ToInt32(Console.ReadLine());
int digit_tmp = digit / 10;
digit_tmp = digit_tmp % 10;

Console.WriteLine(Convert.ToString(digit) + " -> " + Convert.ToString(digit_tmp));