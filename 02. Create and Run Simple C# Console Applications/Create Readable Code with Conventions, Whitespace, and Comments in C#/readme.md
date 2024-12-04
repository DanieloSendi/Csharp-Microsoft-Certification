# Create Readable Code with Conventions, Whitespace, and Comments in C#

## 1. Introduce

The code that you write should communicate your intent to both the compiler and other developers who may need to read your code. And since you're the developer who will be reading your code most often, sometimes months after you originally wrote it, it's in your best interest to write code that's clear and easy to understand. Remember, you may write code once, but you will need to read it many times.

Suppose you've been asked to write some code for another group of developers. You meet with them to discuss the specification and the assignment is clear. After the meeting they tell you that you'll be working independently during development. Once you're done, you'll hand off your code to the other group. The coding task isn't beyond your skill level, but you've never had to write code that someone else will be maintaining. The team told you that as long as you follow the standard coding conventions for C#, there should be no problem. You make plans to review the C# coding conventions that relate to the code you're going to work on.

In this module, you'll learn how to choose names for your variables that describe their purpose and intent. You'll learn how to add code comments that document the higher-level requirements and your approach in code, as well as to temporarily instruct the compiler to ignore lines of code. Finally, you'll learn how whitespace can be used to help convey the relationship of individual lines of code.

By the end of this module, you'll write code more purposefully, focusing on the readability and quality of the code to communicate to both the compiler and other developers.

### Learning objectives
In this module, you will:

- Choose a descriptive name for variables that describe their purpose and intent.
- Use code comments to temporarily instruct the compiler to ignore lines of code.
- Use code comments to describe higher-level requirements or purpose for a passage of code.
- Write code that effectively uses whitespace to convey the relationship of lines of code.

## 2. Choose variable names that follow rules and conventions

A software developer once famously said, "The hardest part of software development is naming things." Not only does the name of a variable have to follow certain syntax rules, it should also be used to make the code more human-readable and understandable. That's a lot to ask of one line of code!

### Variable name rules

There are some variable naming rules that are enforced by the C# compiler.

- Variable names can contain alphanumeric characters and the underscore (_) character. Special characters like the pound #, the dash -, and the dollar sign $ are not allowed.
- Variable names must begin with an alphabetical letter or an underscore, not a number. Using an underscore character to start a variable name is typically reserved for private instance fields. A link to further reading can be found in the module summary.
- Variable names must NOT be a C# keyword. For example, these variable name declarations won't be allowed: float float; or string string;.
- Variable names are case-sensitive, meaning that string MyValue; and string myValue; are two different variables.

### Variable name conventions

Conventions are suggestions that are agreed upon by the software development community. While you're free to decide not to follow these conventions, they're so popular that it might make it difficult for other developers to understand your code. You should practice adopting these conventions and make them part of your own coding habits.

- Variable names should use camel case, which is a style of writing that uses a lower-case letter at the beginning of the first word and an upper-case letter at the beginning of each subsequent word. For example: string thisIsCamelCase;.
- Variable names should be descriptive and meaningful in your application. You should choose a name for your variable that represents the kind of data it will hold (not the data type). For example: bool orderComplete;, NOT bool isComplete;.
- Variable names should be one or more entire words appended together. Don't use contractions because the name of the variable may be unclear to others who are reading your code. For example: decimal orderAmount;, NOT decimal odrAmt;.
- Variable names shouldn't include the data type of the variable. You might see some advice to use a style like string strMyValue;. It was a popular style years ago. However, most developers don't follow this advice anymore and there are good reasons not to use it.
The example string firstName; follows all of these rules and conventions, assuming I want to use this variable to store data that represents someone's first name.

### Other naming conventions

The rules and conventions described above are for local variables. A local variable is a variable that is scoped within the body of a method, or a variable in a console application that uses top-level statements (like the code in this module).

There are other types of constructs that you can use in your applications, and many have their own conventions. For example, classes are often used in C# programming, and have associated conventions. Although you won't be creating classes in this module, it's important for you to know that the naming conventions you just learned about fit into a larger naming framework.

## 3. Create effective code comments

A code comment is an instruction to the compiler to ignore everything after the code comment symbols in the current line.

This may not seem useful at first, however it's useful in three situations:

- When you want to leave a note about the intent of a passage of code. It can be helpful to include code comments that describe the purpose or the thought process when you're writing a particularly challenging set of coding instructions. Your future self will thank you.
- When you want to temporarily remove code from your application to try a different approach, but you're not yet convinced your new idea will work. You can comment out the code, write the new code, and once you're convinced the new code will work the way you want it to, you can safely delete the old (commented code).
- Adding a message like TODO to remind you to look at a given passage of code later. While you should use this judiciously, it's a useful approach. You may be working on another feature when you read a line of code that sparks a concern. Rather than ignoring the new concern, you can mark it for investigation later.

Block comments are great if you need to write a long comment or remove many lines of code. Block comments use a /* at the beginning of the code and a */ at the end. Using a block comment is the quickest and easiest way to disable three or more lines of code.

## 4. Use whitespace to make your code easier to read

Print and web designers understand that putting too much information in a small space overwhelms the viewer. So, they strategically use whitespace, or negative space, to break up information to maximize the viewer's ability to consume the primary message of their work.

Developers can use a similar strategy when writing code in an editor. By using white space to convey meaning, developers can increase the clarity of their code's intent.

### What is whitespace?

The term "whitespace" refers to individual spaces produced by the space bar, tabs produced by the tab key, and new lines produced by the enter key.

The C# compiler ignores whitespace. To understand how whitespace is ignored, and how to maximize clarity using white space, work through the following exercise.