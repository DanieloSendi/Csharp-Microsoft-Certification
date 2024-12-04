# Add Decision Logic to Your Code Using if, else, and else if statements in C#

## 1. Introduction

The C# programming language allows you to build applications that employ decision-making logic.

Suppose you want to display different information to the end user depending on some business rules. For example, what if you want to display a special message on a customer's bill based on their geographic region? What if you want to give a customer a discount based on the size of their order? Or what if you want to display an employee's title based on their level in the company. In each case, you would need to add decision logic.

By the end of this module, you'll be able to write code that can change the flow of your code's execution based on some criteria.

### Learning objectives

In this module, you will:

- Write code that evaluates conditions by using the statements if, else, and else if.
- Build Boolean expressions to evaluate a condition.
- Combine Boolean expressions using logical operators.
- Nest code blocks within other code blocks.

## 2. Create decision logic with if statements

Most applications include a large number of execution paths. For example, an application could implement different execution paths based on which menu option a user selects. Developers refer to the code that implements different execution paths as code branches.

The most widely used code branching statement is the if statement. The if statement relies on a Boolean expression that is enclosed in a set of parentheses. If the expression is true, the code after the if statement is executed. If not, the .NET runtime ignores the code and doesn't execute it.

In this exercise, you'll practice writing if statements by creating a game. First you'll define the rules of the game, then you'll implement them in code.

You'll use the Random.Next() method to simulate rolling three six-sided dice. You'll evaluate the rolled values to calculate the score. If the score is greater than an arbitrary total, then you'll display a winning message to the user. If the score is below the cutoff, you'll display a losing message to the user.

- If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
- If all three dice you roll result in the same value, you get six bonus points for rolling triples.
- If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.

### What is a Boolean expression?

A Boolean expression is any code that returns a Boolean value, either `true` or `false`. The simplest Boolean expressions are simply the values true and false. Alternatively, a Boolean expression could be the result of a method that returns the value true or false.

Simple Boolean expressions can be created by using operators to compare two values. Operators include:

- (==), the "equals" operator, to test for equality
- (>), the "greater than" operator, to test that the value on the left is greater than the value on the right
- (<), the "less than" operator, to test that the value on the left is less than the value on the right
- (>=), the "greater than or equal to" operator
- (<=), the "less than or equal to" operator and so on

### What is a code block?

A code block is a collection of one or more lines of code that are defined by an opening and closing curly brace symbol { }. It represents a complete unit of code that has a single purpose in your software system. In this case, at runtime, all lines of code in the code block are executed if the Boolean expression is true. Conversely, if the Boolean expression is false, all lines of code in the code block are ignored.

You should also know that code blocks can contain other code blocks. In fact, it's common for one code block to be "nested" inside another code block in your applications. 
