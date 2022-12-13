using leetcode;

Console.WriteLine("please enter number");
int s = int.Parse(Console.ReadLine());
int[] n = new int[s]; 
for (int i = 0; i < s; i++)
{
    Console.WriteLine("please enter the list ");
    n[i]=int.Parse(Console.ReadLine());
}
var squares =  msupa.CalculateSq(n);

msupa.PrintArray(squares);