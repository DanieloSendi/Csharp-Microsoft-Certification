# Challenge Project - Develop foreach and if-elseif-else Structures to Process Array Data in C#

## 1. Introduction

End users often ask developers to add new features to an application. User requests indicate that your application is being used, and more importantly, that the customer plans to continue using your application. The customer just wants some features updated. The ability to update an existing application based on user requests is very important. A successful update will preserve the integrity of the original application while providing the user with the improved experience that they requested.

Suppose you're a teacher's assistant at a school and that you developed an application to automate the grading process. The application uses arrays to store student names and graded assignments. The application also implements a combination of iteration and selection statements to calculate and report each student's final grade. Your application even differentiates between exam assignments and extra credit assignments when calculating student grades. Although the application does everything that the teacher asked for, you've received a request for new features. The teacher has asked you to update the grading report to show exam and extra credit assignment scores separately from the final numeric score and letter grade.

This module challenges you to add new capabilities to your Student Grading application.

In short, you need to use the teacher's updated grading report specification to:

- update the iteration and selection code to calculate separate final scores for exams, extra credit assignments, and the overall grade.
- update the code that writes the grading report to the console.

- By the end of this module, you'll have an updated version of the Student Grading application that's able to calculate and report student grades in accordance with the teacher's updated requirements.

### Learning Objectives

In this module, you'll demonstrate your ability to:

- Use Visual Studio Code to revise a C# console application based on an updated feature specification.
- Update the variables and if statements in a C# console application to create the code branches and calculations required to satisfy an updated feature specification.

## 2. Project specification

The Starter code project for this module is a C# console application that implements the following code features:

The Starter code project for this module is a C# console application that implements the following code features:

- Uses arrays to store student names and assignment scores.

- Uses a foreach statement to iterate through the student names as an outer program loop.

- Uses an if statement within the outer loop to identify the current student's name and access that student's assignment scores.

- Uses a foreach statement within the outer loop to iterate through the assignment scores array and sum the values.

- Uses an algorithm within the outer loop to calculate the average exam score for each student.

- Use an if-elseif-else construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.

- Integrates extra credit scores when calculating the student's final score and letter grade as follows:

  - Detects extra credit assignments based on the number of elements in the student's scores array.
  - Applies a 10% weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.

Goal in this challenge is to implement the coding updates required to produce the teacher's requested score report.

The current score report lists the student's name followed by the calculated overall grade and letter grade. Here is the existing report format:

```bash
Student         Grade   Letter Grade

Sophia          95.6    A
Andrew          91.6    A-
Emma            89.2    B+
Logan           93      A
```

In addition to the student's final numeric score and letter grade, the teacher wants the updated report to include the exam score and the impact that extra credit work has on the student's final grade. The format of the updated score report should appear as follows:

```bash
Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)
Andrew          89.6            91.38   A-      89 (1.78 pts)
Emma            85.6            90.94   A-      89 (5.34 pts)
Logan           91.2            93.12   A       96 (1.92 pts)
```

### Update your formatted output

The Student Grading application is used to calculate and report student grades based on their graded exam and extra credit assignments. Your goal in this challenge is to update the code that generates a score report in accordance with the teacher's updated requirements.

In this first challenge exercise, you need to instantiate the variables that are required for the updated score report, and then update the Console.WriteLine() statement that writes student grades to the console.

Your updated application must:

- use the existing arrays and array values for all student grade calculations.
- use the nested structure provided by the existing foreach and if statements.
- declare and initialize any other integer variables that are required for calculating sums.
- declare and initialize any other decimal variables that are required for calculations and/or score report values.

The format of the update score report is:

```bash
Student         Exam Score      Overall Grade   Extra Credit

Sophia          0               95.8    A       0 (0 pts)
Andrew          0               91.2    A-      0 (0 pts)
Emma            0               90.4    A-      0 (0 pts)
Logan           0               93      A       0 (0 pts)
```

### Update your calculated values

In this second challenge exercise, you need to instantiate the variables that are required for the updated score report, complete the required calculations, and then update the Console.WriteLine() statement that writes student grades to the console.

Your updated application must:

- use the existing arrays and array values for all student grade calculations.
- use the nested structure provided by the existing foreach and if statements.
- calculate the sum of exam and extra credit assignment scores using variables from the first exercise or the original code.
- calculate the average for exam scores and extra credit scores using variables from the first exercise or the original code.
- calculate the final numeric score as follows: add 10% of the extra credit score sum to the exam score sum, and then divide that value by the number of exams.
- calculate the extra credit points earned as follows: divide 10% of the extra credit score sum by the number of exams.

The required score report format is:

```bash
Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)
Andrew          89.6            91.38   A-      89 (1.78 pts)
Emma            85.6            90.94   A-      89 (5.34 pts)
Logan           91.2            93.12   A       96 (1.92 pts)
```
