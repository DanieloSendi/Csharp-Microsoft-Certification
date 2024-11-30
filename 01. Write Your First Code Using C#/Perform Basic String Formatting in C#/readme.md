# Perform Basic String Formatting in C#

## 1. Introduction

As a software developer, you'll need to write C# code to combine and format literal and variable data to create a new value. That value might be displayed, saved to file, or sent across the network. Fortunately, C# provides many ways to combine and format data.

Suppose you want to display the output of a command-line application you're writing. You want to display values including literal text, text in variables, numeric data, and textual data in other languages. How would you format it correctly so that the user can understand what your application is communicating to them?

### Learning objectives

In this module, you will:

- Create string data containing tabs, new lines, and other special characters
- Create string data containing Unicode characters
- Combine string data into a new string value via concatenation
- Combine string data into a new string value via interpolation

## 2. Exercise - Combine strings using character escape sequences

Suppose you've been asked to create a mockup of a command-line tool that will generate invoices in both English and Japanese. You don't have to build the actual functionality that generates the invoices yet. You only need to provide the command line interface to internal customers in the billing department for their approval. Your manager asked you to make sure you add formatting to make the current progress of the tool clear. Your manager also asked you to provide instructions for the Japanese users on how to generate invoices in Japanese.

### Character escape sequences

An escape character sequence is an instruction to the runtime to insert a special character that will affect the output of your string. In C#, the escape character sequence begins with a backslash `\` followed by the character you're escaping. For example, the `\n` sequence will add a new line, and a `\t` sequence will add a tab.

What if you need to insert a double-quotation mark in a literal string? If you don't use the character escape sequence, you'll confuse the compiler because it will think you want to terminate the string prematurely. The compiler won't understand the purpose of the characters after the second double-quotation mark.

```csharp
Console.WriteLine("Hello "World"!");
```

The .NET Editor will put a red squiggly line under World. But if you attempt to run the code anyway, you would see the following output:

```bash
error CS1003: Syntax error, ',' expected
error CS0103: The name 'World' does not exist in the current context
error CS1003: Syntax error, ',' expected
```

### Verbatim string literal

A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. To create a verbatim string, use the @ directive before the literal string.

### Unicode escape characters

You can also add encoded characters in literal strings using the \u escape sequence, then a four-character code representing some character in Unicode (UTF-16).

There are several caveats here. First, some consoles like the Windows Command Prompt will not display all Unicode characters. It will replace those characters with question mark characters instead. Also, the examples used here are UTF-16. Some characters require UTF-32 and therefore require a different escape sequence. This is a complicated subject, and this module is only aiming at showing you what is possible.

## 3. Exercise - Combine strings using string concatenation

Often, you'll need to combine data from many different sources, including literal strings and variables containing both text and numeric data. In this unit, you'll use string concatenation to combine two or more values into a new string.

### What is string concatenation?

String concatenation is "programmer speak" for simply combining two or more string values into a new string value. Unlike addition, the second value is appended to the end of the first value, and so on. In the following exercise, you'll write code to concatenate string values together.

To concatenate two strings together, you use the string concatenation operator, which is the plus symbol +.

## 4. Exercise - Combine strings using string interpolation

While string concatenation is simple and convenient, string interpolation is growing in popularity in situations where you need to combine many literal strings and variables into a single formatted message.

### What is string interpolation?

String interpolation combines multiple values into a single literal string by using a "template" and one or more `interpolation expressions`. An interpolation expression is indicated by an opening and closing curly brace symbol `{ }`. You can put any C# expression that returns a value inside the braces. The literal string becomes a template when it's prefixed by the $ character.

### Combine verbatim literals and string interpolation

You can use both the verbatim literal prefix symbol @ and the string interpolation $ symbol together.
