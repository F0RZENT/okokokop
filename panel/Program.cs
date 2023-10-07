using System.Globalization;
using System.Xml.XPath;

int prompt(string message) 
{
  System.Console.WriteLine(message);
  int num = Int32.Parse(Console.ReadLine());
  return num;
}
  void degree() 
{
  int num1 = prompt("Введите Степень: ");
  int num2 = prompt("Введите Степень: ");
  int result = 1;
for (int i = 0; i < num2; i++)
{
  result *= num1;
}
Console.WriteLine(result);
}
degree();
