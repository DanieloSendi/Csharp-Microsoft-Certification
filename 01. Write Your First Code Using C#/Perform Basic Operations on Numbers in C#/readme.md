# Perform Basic Operations on Numbers in C#

## 1. Introduction

The applications you'll build in C# will require that you operate on literal and variable numeric data. Examples might include:

- Performing simple mathematical operations including addition, subtraction, multiplication, and division
-Performing multi-step operations that must be completed in a certain order
- Determining the remainder after performing division
- Incrementing or decrementing a value, and so on

- Suppose you want to perform a calculation that converts a value from one unit of measure to another. For example, what if you needed to convert the current temperature from Fahrenheit to Celsius? Once you've calculated the temperature in degrees Celsius, you need to display that information in a formatted message to the user. To accomplish this, you'll need to learn to use operators to act on operands like literal and variable values.

In this module, you'll perform basic string and numeric operations on your data. As you'll learn, the compiler will perform different tasks depending on the data types of the values around the given operator. More importantly, you'll come to understand how operators perform actions on operands. Learning how to work with operators and operands correctly will help you formulate meaningful instructions in your code.

By the end of this module, you will be able to write code that performs basic operations on literal and variable values.

### Learning objectives

In this module, you will:

- Perform mathematical operations on numeric values
- Observe implicit type conversion between strings and numeric values
- Temporarily convert one data type into another

## 2. Exercise - Perform addition with implicit data conversion

Often, you'll want to perform mathematical operations on numeric data. You'll start with addition in this unit, and expand to other operations in the next unit because there's an important lesson to learn about how the C# compiler parses and interprets your code.

### Add two numeric values

To add two numbers together, you'll use the addition operator, which is the plus symbol +. Yes, the same plus symbol + that you use for string concatenation is also used for addition. The reuse of one symbol for multiple purposes is sometimes called "overloading the operator" and happens frequently in C#.

In this instance, the C# compiler understands what you're attempting to do. The compiler parses your code and sees that the + (the operator) is surrounded by two numeric values (the operands). Given the data types of the variables (both are ints), it figures out that you intended to add those two values.

### Mix data types to force implicit type conversions

In this case, the C# compiler understands that you want to use the + symbol to concatenate the two operands. It deduces this because the + symbol is surrounded by operands of string and int data types. So, it attempts to implicitly convert the int variable widgetsSold into a string temporarily so it can concatenate it to the rest of the string. The C# compiler tries to help you when it can, but ideally, you would be explicit about your intentions.

The compiler treats everything as a string and concatenates it all together.

### Add parentheses to clarify your intention to the compiler

The parentheses symbol `()` becomes another overloaded operator. In this case, the opening and closing parentheses form the order of operations operator, just like you might use in a mathematical formula. You indicate that you want the inner-most parentheses resolved first resulting in the addition of int values widgetsSold and the value 7. Once that is resolved, then it will implicitly convert the result to a string so that it can be concatenated with the rest of the message.

## 3. Exercise - Perform math operations

Now that you understand the basics of addition and more importantly, implicit type conversion between numeric and string data types, let's look at several other common mathematical operations on numeric data.

### Write code to perform addition, subtraction, multiplication, and division with integers

- (+) is the addition operator
- (-) is the subtraction operator
- (*) is the multiplication operator
- (/)is the division operator

However, the resulting quotient of the division example may not be what you may have expected. The values after the decimal are truncated from the quotient since it is defined as an int, and int cannot contain values after the decimal.

The quotient (left of the assignment operator) must be of type decimal and at least one of numbers being divided must also be of type decimal (both numbers can also be a decimal type).

### Add code to cast results of integer division

What if you are not working with literal values? In other words, what if you need to divide two variables of type int but do not want the result truncated? In that case, you must perform a data type cast from int to decimal. Casting is one type of data conversion that instructs the compiler to temporarily treat a value as if it were a different data type.

To cast int to decimal, you add the cast operator before the value. You use the name of the data type surrounded by parentheses in front of the value to cast it. In this case, you would add (decimal) before the variables.

### Write code to determine the remainder after integer division

The modulus operator % tells you the remainder of int division. What you really learn from this is whether one number is divisible by another. This can be useful during long processing operations when looping through hundreds or thousands of data records and you want to provide feedback to the end user after every 100 data records have been processed.

When the modulus is 0, that means the dividend is divisible by the divisor.

### Order of operations

As you learned in the previous exercise, you can use the () symbols as the order of operations operators. However, this isn't the only way the order of operations is determined.

In math, PEMDAS is an acronym that helps students remember the order of operations. The order is:

1. Parentheses (whatever is inside the parenthesis is performed first)
2. Exponents
3. Multiplication and Division (from left to right)
4. Addition and Subtraction (from left to right)
1. 
C# follows the same order as PEMDAS except for exponents. While there's no exponent operator in C#, you can use the [System.Math.Pow](https://learn.microsoft.com/en-us/dotnet/api/system.math.pow?view=net-9.0) method. The module "Call methods from the .NET Class Library using C#" will feature this method and others.

## 4. Exercise - Increment and decrement values

The final basic operations you'll learn about in this module is how to increment and decrement values using special operators that are combinations of symbols.

### Increment and decrement

Frequently, you'll need to increment and/or decrement values, especially when you're writing looping logic or code that interacts with a data structure.

The `+=` operator adds and assigns the value on the right of the operator to the value on the left of the operator.

Operators like `+=`, `-=`, `*=`, `++`, and -- are known as `compound assignment operators` because they compound some operation in addition to assigning the result to the variable. The += operator is specifically termed the addition assignment operator.

### Position the increment and decrement operators

Both the increment and decrement operators have an interesting quality — depending on their position, they perform their operation before or after they retrieve their value. In other words, if you use the operator before the value as in `++value`, then the increment will happen before the value is retrieved. Likewise, `value++` will increment the value after the value has been retrieved. While not strictly necessary, you added parenthesis around the expression (++value) to improve readability.
