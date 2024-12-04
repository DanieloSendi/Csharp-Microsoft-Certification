# Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#

## 1. Introduction

C# arrays allow you to store sequences of values in a single data structure. In other words, imagine a single variable that can hold many values. Once you have a single variable that stores all the values, you can sort the values, reverse the order of the values, loop through each value and inspect it individually, and so on.

Suppose you work in the security department of a company that matches online sellers with commission-based advertisers. You've been asked to write C# code that will iterate through the Order IDs of incoming orders. You need to inspect each Order ID to identify orders that may be fraudulent. You'll need to implement arrays to accomplish this programming task.

In this module, you'll create and initialize arrays. You'll set and retrieve values from elements in an array accessing each element using its index. You'll create looping logic that allows you to work with each element in an array.

By the end of this module, you'll have worked with your first structure to hold multiple data values. Later, in other modules, you'll learn how to sort, filter, query, aggregate, and perform other operations on your data.

### Learning objectives

In this module you will:

- Create and initialize a new array.
- Assign and retrieve the values of array elements.
- Iterate through each element of an array using the foreach statement.

## 2. Get started with array basics

Arrays can be used to store multiple values of the same type in a single variable. The values stored in an array are generally related. For example, a list of student names could be stored in a string array named students.

Your work in the security department is focused on finding a pattern for fraudulent orders. You want your code to review past customer orders and identify markers associated with fraudulent orders. Your company hopes the markers can be used to identify potential fraudulent purchase orders in the future before they're processed. Since you don't always know in advance how many orders you need to review, you can't create individual variables to hold each Order ID.

### What is an array?

An array is a collection of individual data elements accessible through a single variable name. You use a zero-based numeric index to access each element of an array. Arrays allow you to create a collection of data values that shares a common purpose or characteristics under a single variable name for easier processing.

### Declaring arrays and accessing array elements

An array is a special type of variable that can hold multiple values of the same data type. The declaration syntax is slightly different for an array because you have to specify both the data type and the size of the array.

### Assign values to elements of an array

At this point, you've declared an array of strings, but each element of the array is empty. To access an element of an array, you use a numeric zero-based index inside of square brackets. You can assign a value to an array element using the = as if it were a regular variable.

### Attempt to use an index that is out of bounds of the array

It might not seem intuitive at first, but it's important to remember that you're declaring the count of elements in the array. However, you access each element of the array starting with `zero`. So, to access the second item in the array, you use `index 1`.

It's common for beginners to forget that arrays are zero-based and attempt to access an element of the array that doesn't exist. If you make this mistake, a runtime exception occurs informing you that you attempted to access an element that is outside the boundary of the array.

### Retrieve values from elements of an array

Accessing the value of an array element works the same way as assigning a value to an array element. You just specify the index of the element whose value you want to retrieve.

### Reassign the value of an array

The elements of an array are just like any other variable value. You can assign, retrieve, and reassign a value to each element of the array.

### Use the Length property of an array

Depending on how the array is created, you may not know in advance how many elements an array contains. To determine the size of an array, you can use the `Length` property.

## 3. Implement the foreach statement

Suppose you work for a manufacturing company. The company needs you to complete an inventory of your warehouse to determine the number of products that are ready to ship. In addition to the total number of finished products, you need to report the number of finished products stored in each individual bin in your warehouse, along with a running total. This running total will be used to create an audit trail so you can double-check your work and identify "shrinkage".

### Looping through an array using foreach

The `foreach` statement provides a simple, clean way to iterate through the elements of an array. The foreach statement processes array elements in increasing index order, starting with index 0 and ending with index Length - 1. It uses a temporary variable to hold the value of the array element associated with the current iteration. Each iteration will run the code block that's located below the foreach declaration.

## 4. Challenge - report the Order IDs that need further investigation

Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.

