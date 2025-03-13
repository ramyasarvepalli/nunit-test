using NUnitDemo;

//Get percentage from user
Console.WriteLine("Enter your percentage: ");
int percentage = Convert.ToInt32(Console.ReadLine());

//Create an object of GradeCalculator
GradeCalculator gradeCalculator = new GradeCalculator();
var grade = gradeCalculator.GetGradeByPercentage(percentage);

//Display the grade
Console.WriteLine($"Student grade: {grade}");

