# Call Methods From the .NET Class Library Using C#

## 1. Introduction

The C# programming language is supplemented by a large library of functionality that enables you to create applications, access data in files or on the Internet, perform advanced mathematical operations, and much more. Understanding how to navigate this library of functionality is a critical skill that will help you build feature-rich applications more quickly.

Suppose you need to generate a daily report that's based on thousands of data files. To save time, your code uses a random sample of the data files to calculate an approximate result without analyzing all the data files. How can you generate a random number? Is this supported by C#? If so, how can you write code to set the value range for a random number, and then generate and retrieve the result?

In this module, you learn about class libraries, and write code that calls methods in the .NET Class Library. You learn the characteristics of methods, and why methods of the .NET Class Library are designed and implemented differently across the .NET Class Library. Most importantly, you write code that uses the .NET Library methods to achieve a specific programming task. Finally, you'll use built-in tools and online documentation to help you gather information about the methods you want to work with.

By the end of this module, you'll know how to find classes and methods in the .NET Class Library, and how to use them to perform common programming tasks.

### Learning Objectives

In this module, you will:

- Write code that calls methods in the .NET Class Library.
- Use an instance of .NET Class Library classes to call methods that maintain state.
- Use Intellisense in Visual Studio Code to learn more about a method, including its overloaded versions, its return value type, and its input parameter data types.
- Use learn.microsoft.com to research what a method does, its overloaded versions, its return value type, its input parameters and what each parameter represents, and more.

## 2. Get started with .NET Libraries

There's more to building a C# application than stringing together lines of code. You'll need the .NET Runtime, which hosts and manages your code as it executes on the end user's computer. You'll also rely on the .NET Class Library, a prewritten collection of coding resources that you can use in your applications. This unit explains what the .NET Class Library is and how it complements the C# programming language.

### What is the .NET Class Library?

When you need to find a book, a public library is a good place to look. After all, libraries contain thousands and thousands of books, and they're organized into sections that help you to find what you're looking for. When you need to implement a programming task, the .NET Class Library is a good place to look, because it's an organized collection of programming resources.

The .NET Class Library is a collection of thousands of classes containing tens of thousands of methods. For example, the .NET Class Library includes the Console class for developers working on console applications. The Console class includes methods for input and output operations such as Write(), WriteLine(), Read(), ReadLine(), and many others.

You can think of a class as a container for methods, kind of like the sections of the public library. Developers typically keep related methods together in a single class. Any methods that can send or receive information from a console window are collected into the System.Console class in the .NET Class Library.

In many cases, these classes and methods enable you to build a specific type of application. For example, one of the larger subsets of classes and methods enable you to create dynamic web applications. There's also several families of classes that enable you to build native desktop applications. Another subset of classes and methods enable you to access a database. There are lots of classes in the .NET Class Library that support specific types of applications.

There are other classes with methods that provide support in a more general way. In other words, their utility spans a wide range of device platforms, application frameworks, and technology areas. For example, if you want to read or write file information, or perform trigonometry or calculus operations, there are general purpose classes that you can use in your code. It doesn't matter whether you're building applications for the web, desktop, mobile device, or the cloud, general purpose classes and methods are there to help.

As you can imagine, having a massive library of functionality available to your applications is a huge time saver for you as a software developer. The classes and methods in the .NET Class Library are created by Microsoft and are available for use in your applications.

#### Even data types are part of the .NET Class Library

C# data types (such as string and int) are actually made available through classes in the .NET Class Library. The C# language masks the connection between the data types and the .NET classes in order to simplify your work. However, behind the scenes, the data types are implemented just like every other class in the .NET Class Library. This connection provides your everyday variables with built-in methods that can be very helpful. The string class has lots of these helpful methods. For example, the string class has methods for converting text to uppercase and lowercase (ToUpper and ToLower).

## 3. Call the methods of a .NET Class

Whether you realized it or not, you've been calling C# methods ever since your first "Hello, World!" application. That application uses the WriteLine() method of the Console class to display the "Hello, World!" message.

However, not all classes and methods are implemented the same way. This unit covers some of the most common variants that you'll need to understand when using methods from the .NET Class Library. More importantly, you'll learn how to find and use the documentation to better understand more about each method.

### How to call methods in the .NET Class Library

> **Note**
>
> From your previous experience with the Console.WriteLine() method, you should already know the basics:

- Start by typing the class name. In this case, the class name is Console.
- Add the member access operator, the . symbol.
- Add the method's name. In this case, the method's name is WriteLine.
- Add the method invocation operator, which is a set of parentheses ().
- Finally, specify the arguments that are passed to the method, if there are any, between the parentheses of the method invocation operator. In this case, you specify the text that you want the Console.WriteLine() method to write to the console (for example, "Hello World!").

Optionally, depending on how the developers designed and implemented the given method, you may also need to:

- Pass additional values as input parameters.
- Accept a return value.

### Stateful versus stateless methods

In software development projects, the term `state` is used to describe the condition of the execution environment at a specific moment in time. As your code executes line by line, values are stored in variables. At any moment during execution, the current state of the application is the collection of all values stored in memory.

Some methods don't rely on the current state of the application to work properly. In other words, `stateless methods` are implemented so that they can work without referencing or changing any values already stored in memory. Stateless methods are also known as static methods.

For example, the Console.WriteLine() method doesn't rely on any values stored in memory. It performs its function and finishes without impacting the state of the application in any way.

Other methods, however, must have access to the state of the application to work properly. In other words, `stateful methods` are built in such a way that they rely on values stored in memory by previous lines of code that have already been executed. Or they modify the state of the application by updating values or storing new values in memory. They're also known as `instance methods`.

Stateful (instance) methods keep track of their state in fields, which are variables defined on the class. Each new instance of the class gets its own copy of those fields in which to store state.

A single class can support both stateful and stateless methods. However, when you need to call stateful methods, you must first create an instance of the class so that the method can access state.

### Creating an instance of a class

An instance of a class is called an `object`. To create a new instance of a class, you use the `new` operator. Consider the following line of code that creates a new instance of the `Random` class to create a new object called `dice`:

```csharp
Random dice = new Random();
```

The `new` operator does several important things:

- It first requests an address in the computer's memory large enough to store a new object based on the Random class.
- It creates the new object, and stores it at the memory address.
- It returns the memory address so that it can be saved in the dice object.

From that point on, when the `dice` object is referenced in code, the .NET Runtime performs a lookup behind the scenes to give the illusion that you're working directly with the object itself.

Your code uses the dice object like a variable that stores the state of the Random class. When you call the Next() method on the dice object, the method uses the state stored in the dice object to generate a random number.

The latest version of the .NET Runtime enables you to instantiate an object without having to repeat the type name (target-typed constructor invocation).

For example, the following code will create a new instance of the Random class:

```csharp
Random dice = new();
```

The intention is to simplify code readability. You always use parentheses when writing a target-typed new expression.

### Why is the Next() method stateful?

You might be wondering why the `Next()` method was implemented as a stateful method? Couldn't the .NET Class Library designers figure out a way to generate a random number without requiring state? And what exactly is being stored or referenced by the `Next()` method?

hese are fair questions. At a high level, computers are good at following specific instructions to create a reliable and repeatable outcome. To create the illusion of randomness, the developers of the Next() method decided to capture the date and time down to the fraction of a millisecond and use that to seed an algorithm that produces a different number each time. While not entirely random, it suffices for most applications. The state that is captured and maintained through the lifetime of the dice object is the seed value. Each subsequent call to the Next() method is rerunning the algorithm, but ensures that the seed changes so that the same value isn't (necessarily) returned.

To use the Random.Next() method, however, you don't have to understand how it works. The important thing to know is that some methods require you to create an instance of a class before you call them, while others do not.

### How can you determine whether you need to create an instance of a class before calling its methods?

One approach for determining whether a method is stateful or stateless is to consult the documentation. The documentation includes examples that show whether the method must be called from the object instance or directly from the class. You may need to scroll down on the documentation page to find the code examples.

As an alternative to searching through product documentation, you can attempt to access the method directly from the class itself. If it works, you know that it's a stateless method. The worst that can happen is that you'll get a compilation error.

Try accessing the Random.Next() method directly and see what happens with the following line of code:

```csharp
int result = Random.Next();
```

You already know that Next() is a stateful method, however this example demonstrates how the Editor reacts when you try to access a method incorrectly. Notice that a red squiggly line appears under Random.Next, indicating that you have a compilation error.

If the method that you're interested in using is stateless, no red squiggly line will appear.

Hover your mouse pointer over the red squiggly line. A popup window should appear with the following message:

```bash
error CS0120: An object reference is required for the non-static field, method, or property 'Random.Next()'
```

 You can fix this error by creating an instance of the Random class before accessing the Next() method.

## 4. Return values and parameters of methods

In the previous unit, you used a "roll dice" coding scenario to illustrate the difference between stateful (instance) and stateless (static) methods. That same scenario can help you to understand other important concepts about calling methods. For example:

- handling the return value of a method.
- method parameters and passing arguments to a method.
- choosing an overloaded version of a method.

### Return values

Some methods are designed to complete their function and end "quietly". In other words, they don't return a value when they finish. They are referred to as void methods.

Other methods are designed to return a value upon completion. The return value is typically the result of an operation. A return value is the primary way for a method to communicate back to the code that calls the method.

You saw that the Random.Next() method returns an int type containing the value of the randomly generated number. However, a method can be designed to return any data type, even another class. For example, the String class has some methods that return a string, some that return an integer, and some that return a Boolean.

When calling a method that returns a value, you'll often assign the return value to a variable. That way, you can use the value later in your code.

In some cases, you might want to use the return value directly, without assigning it to a variable.

Even though a method returns a value, it's possible to call the method without using the return value.For example, you could ignore the return value by calling the method as follows:

```csharp
dice.Next(1, 7);
```

However, ignoring the return value would be pointless. The reason you're calling the Next() method is so that you can retrieve the next random value.

### Method parameters and arguments in the calling statement

When you call a method, you can pass in values that the method will use to complete its task. These values are called `arguments`. The method uses the arguments to assign values to the `parameters` that are defined in the method's signature. A method can require one or more parameters to accomplish its task, or none at all.

Often times, the terms 'parameter' and 'argument' are used interchangeably. However, 'parameter' refers to the variable that's being used inside the method. An 'argument' is the value that's passed when the method is called.

Most methods are designed to accept one or more parameters. The parameters can be used to configure how the method performs its work, or they might be operated on directly. For example, the Random.Next() method uses parameters to configure the upper and lower boundaries of the return value. However, the Console.WriteLine() uses the parameter directly by printing the value to the console.

Methods use a `method signature` to define the number of parameters that the method will accept, as well as the data type of each parameter. The coding statement that calls the method must adhere the requirements specified by the method signature. Some methods provide options for the number and type of parameters that the method accepts.

When a caller invokes the method, it provides concrete values, called arguments, for each parameter. The arguments must be compatible with the parameter type. However, the argument name, if one is used in the calling code, doesn't have to be the same as the parameter name defined in the method.

The arguments passed to a method must be the same data type as the corresponding parameters defined by the method. If you attempt to pass an incorrectly typed argument to a method, the C# compiler will catch your mistake and force you to update your calling statement before your code will compile and run. Type checking is one way that C# and .NET use to prevent end-users from experiencing errors at runtime.

Although parameters are often used, not all methods require parameters to complete their task. For example, the Console class includes a Console.Clear() method that doesn't use parameters. Since this method is used to clear any information displayed in the console, it doesn't need parameters to complete it's task.

### Overloaded methods

Many methods in the .NET Class Library have `overloaded method` signatures. Among other things, this enables you to call the method with or without arguments specified in the calling statement.

An overloaded method is defined with multiple method signatures. Overloaded methods provide different ways to call the method or provide different types of data.

In some cases, overloaded versions of a method are used to define a parameter using different data types. For example, the `Console.WriteLine()` method has 19 different overloaded versions. Most of those overloads allow the method to accept different types and then write the specified information to the console. Consider the following code:

In other cases, overloaded versions of a method define a different number of parameters. The alternative parameters can be used to provide more control over desired result. For example, the `Random.Next()` method has overloaded versions that enable you to set various levels of constraint on the randomly generated number.

