# Guided Project - Calculate Final GPA

## Introduction

Developers perform some tasks nearly every day. Tasks including declaring string and numeric variables, assigning and extracting values, and performing calculations are not only routine, but essential. Equally important is the task of communicating results to the application user. Mastering the ability to apply these skills to solve a given problem is something that every developer must learn to do.

Suppose you're a teacher's assistant at a university. You're tasked with developing an application that helps calculate students' grade point average. The application uses the students' grades and credit hours taken to calculate their overall GPA. You're also provided a required format for reporting the students' GPA.

This module will guide you through the steps required to develop your GPA Calculator application. Your code will declare and assign values to variables based on course information, perform various numeric calculations, and format and display the results. Calculations include determining the sum of the grade points earned and total credit hours. To display the results in the required format, you'll need to manipulate a decimal value to display a total of three digits. You'll also use Console.WriteLine() methods as well character escape sequences that help to format your results.

By the end of this module, you'll be able to write code that uses various variable types, performs numeric calculations, and displays formatted data for the user.

### Learning objectives

In this module, you’ll practice how to:

- Work with variables to store and retrieve data
- Perform basic math operations
- Format strings to present results

## 2. Prepare for guided project

You'll be writing code that uses string and numeric variables, performs calculations, then formats and displays the results to a console.

### Project overview

You're developing a Student GPA Calculator that will help calculate students' overall Grade Point Average. The parameters for your application are:

- You're given the student's name and class information.
- Each class has a name, the student's grade, and the number of credit hours for that class.
- Your application needs to perform basic math operations to calculate the GPA for the given student.
- Your application needs to output/display the student’s name, class information, and GPA.

To calculate the GPA:

- Multiply the grade value for a course by the number of credit hours for that course.
- Do this for each course, then add these results together.
- Divide the resulting sum by the total number of credit hours.
- 
You're provided with the following sample of a student's course information and GPA:

```bash
Student: Sophia Johnson

Course              Grade   Credit Hours	
English 101         4       3
Algebra 101         3       3
Biology 101         3       4
Computer Science I  3       4
Psychology 101      4       3

Final GPA:          3.35
```
