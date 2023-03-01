int digit = Convert.ToInt32(Console.ReadLine());
int digit_tmp = digit;
int i = 0;

while(digit_tmp > 0) {
    i++;
    digit_tmp = digit_tmp / 10;
}
if(i == 3)
    Console.WriteLine(Convert.ToString(digit) + " -> " + Convert.ToString(digit % 10));
else
    Console.WriteLine(Convert.ToString(digit) + " -> Такого числа нет");