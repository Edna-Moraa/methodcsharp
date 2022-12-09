using leetcode;
Console.WriteLine("please enter the dob in the format yyyy/mm/dd:");
DateTime dob = DateTime.Parse(Console.ReadLine());
var age = msupa.CalculateDate(dob);

Console.WriteLine($"Your age Edna is:{age}");

int[] numbers = msupa.ArrIntergers(10);
int sum = msupa.Sum(numbers);
Console.WriteLine($"sum = {sum}");

//ask user to enter the number of items 
//based on the number of items ask the user to input the intergers into a list
//write a method in msupa class that will take that list and calculate the square of each item in the list
//write a function that will take a list of intergers and output it on the console
//this assignment should be pushed to github before 6pm tomorrow


msupa.Main();
//msupa.CalculateSq();

