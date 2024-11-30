string studentName = "Sophia Johnson";

string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

// Store the numeric grade values for each course

// declare an integer variable for each numeric grade value
int gradeA = 4;
int gradeB = 3;

// create variables that will store the grades for each course
int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

// declare and initialize variable that will store the total number of credit hours
int totalCreditHours = 0;

// increment the sum to represent the total number of credit hours
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

// create a variable that will store the total number of grade points earned for each course
int totalGradePoints = 0;

// increment the sum by the grade points earned for the course
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

// initialize a variable that will store the final GPA
decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

// initialize a variable that will store the leading digit of the GPA
int leadingDigit = (int)gradePointAverage;

// initalize a variable that will store the first two digits after the decimal
int firstDigit = (int)(gradePointAverage * 10) % 10;

int secondDigit = (int)(gradePointAverage * 100) % 10;

// display the student's course information and GPA
Console.WriteLine($"Student: {studentName}\n");

Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t{course1Grade}\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{course2Grade}\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{course3Grade}\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");
