
Console.Write("Nhập số nguyên a: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Nhập số nguyên b: ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Tổng = {a + b}");
Console.WriteLine($"Hiệu = {a - b}");
Console.WriteLine($"Tích = {a * b}");

if (b != 0)
{
    Console.WriteLine($"Thương = {(double)a / b}");
}
else
{
    Console.WriteLine("Không thể chia cho 0.");
}
