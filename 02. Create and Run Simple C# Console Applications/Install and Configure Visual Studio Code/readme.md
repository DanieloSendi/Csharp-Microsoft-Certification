# Install and Configure Visual Studio Code

## 1. Introduction

Software development is more than just writing code, it's a process. Larger coding projects can take months or even years to complete and can be complex. The process of writing, debugging, testing, updating/versioning, and releasing code is a significant undertaking. To help with this process, developers use a specialized tool known as an integrated development environment (IDE).

An IDE typically includes a suite of tools that support the software development process from beginning to end, a process known as the development lifecycle. The IDE tools enable the developer to work more efficiently and can help the developer, or team of developers, to write, debug, test, publish, and version their code more easily. A good IDE is a programmer's best friend.

Suppose you're interested in getting started with C# application development. Your first step is to select a programming environment. After researching the available options online, you determine that Visual Studio Code is one of the most popular code editors among C# developers. You're happy to see that Visual Studio Code is quick and easy to install, and that it supports numerous extensions to enhance developer productivity. You also take a look at the full Visual Studio product, which provides even more features for professional developers. Both products include a free option. After consulting a developer friend, you decide that Visual Studio Code will provide all of the tools that you need to get started. You make plans to begin setting up your development environment with Visual Studio Code.

In this module, you install and configure Visual Studio Code to meet your coding requirements. You learn about the various panels and menus that comprise the Visual Studio Code user interface, as well as how and when to use them. Most importantly, you learn how to configure Visual Studio Code for C# development and how to create, build, run, and update a C# console application in Visual Studio Code.

By the end of this module, you'll be able to use Visual Studio Code to create and run your own C# console applications.

### Learning objectives

In this module, you will:

- Download and install Visual Studio Code.
- Examine the Visual Studio Code user interface.
- Configure Visual Studio Code to use the C# extension.
- Install the .NET runtime library.
- Build and run a console application.

## 2. Download and install Visual Studio Code

Visual Studio Code is a lightweight but powerful source code editor that runs on your desktop and is available for Windows, macOS and Linux. It comes with built-in support for JavaScript, TypeScript and Node.js and has a rich ecosystem of extensions for other languages and runtimes (such as C++, C#, Java, Python, PHP, Go, .NET).

Getting up and running with Visual Studio Code is quick and easy. It's a small download, so you can install it in a matter of minutes:

1. Open a new browser window, and then navigate to: [Visual Studio Code](https://code.visualstudio.com).
2. In the browser window, select Download for Windows. The Download page for Visual Studio Code automatically detects your operating system. It displays the version to download for your operating system, such as Linux, macOS, or Windows.
3. Wait for the installer file to finish downloading. The name of the installer file will be similar to the following (for a Windows PC): VSCodeUserSetup-x64-1.81.0.exe. The file name depends on the current version of Visual Studio Code and your computer�s operating system.

### Install Visual Studio Code

Visual Studio Code is lightweight and should run on most available hardware and platform versions. You can review the [System Requirements](https://code.visualstudio.com/docs/supporting/requirements) to check whether your computer configuration is supported.

1. On your PC, open a file explorer application, and then navigate to your computer�s downloads folder.

2. In your file explorer application, select and run the Visual Studio Code installer file.

On a Windows PC, you can double-click the installer file to begin the install process. For example, double-click VSCodeUserSetup-x64-1.81.0

For detailed, see the following Visual Studio Code documentation page: [installation instruction](https://code.visualstudio.com/docs/setup/windows).

## 3. Examine the Visual Studio Code user interface

At its heart, Visual Studio Code is a code editor, with a user interface and layout that's similar to many other code editors. On the left side of the interface is a side bar that you'll use to access the files and folders in your code project. On the right side is an editor area that displays the contents of the application files.

### Main areas of user interface

The following diagram shows the six main sections included in the Visual Studio Code user interface.

![sdss](https://learn.microsoft.com/en-us/training/modules/install-configure-visual-studio-code/media/visual-studio-code-user-interface-labels.png)

A - The `Activity Bar` is the narrow vertical bar located on the far left-hand side of the window. The Activity bar lets you switch between views (such as Explorer or Extensions) and gives you other context-specific indicators.

B - The `Side Bar` contains views that provide tools and resources. The Side Bar views (such as EXPLORER) are very helpful when you're working on a code project.

C - The `Editor` is the area used to edit your files. You can open as many editors as you like side by side vertically and horizontally.

D - The `Panel` area is used to display different panels below the editor region for output or debug information, errors and warnings, or an integrated terminal.

E - The `Status Bar` is the horizontal bar along the bottom of the window that displays information about the opened project and the files you edit.

F - The `Main Menu` is the menu interface at the top of the application window. The menu options enable you to save, edit, and run your code (and much more).

## 4. Configure Visual Studio Code Extensions

You can extend the capabilities of Visual Studio Code using extensions. Extensions are add-ons that provide additional functionality to Visual Studio Code. There are language extensions, theme extensions, and extensions that add new features to Visual Studio Code. Visual Studio Code supports the development of C# applications using C# language extensions and the .NET Software Development Kit (SDK).

### The .NET SDK and .NET Runtime

.NET is a cross-platform, open-source developer platform that's used to develop different types of applications. It includes the software languages and code libraries used to develop .NET applications. You can write .NET applications in C#, F#, or Visual Basic. The .NET platform is used to develop and run applications on Windows, macOS, and Linux. The .NET platform provides a runtime environment for running applications.

The .NET runtime is the code library that's required to run your C# applications. You may also see the .NET runtime referred to as the Common Language Runtime, or CLR. The .NET runtime isn't required to write your C# code, but it's required to actually run your C# applications.

Visual Studio Code uses the .NET SDK and C# extensions to provide a development environment for writing, running, and debugging C# applications.

### Configure Visual Studio Code Extensions

From search extension textbox install C# Dev Kit. For now, the important thing to know is that this extension helps you to develop, edit, and debug C# code in Visual Studio Code.

Notice that installing the C# Dev Kit installs the following extensions:

- .NET Install Tool. This extension installs and manages different versions of the .NET SDK and Runtime.
- C# - Base language support for C#.
- C# Dev Kit - Official C# extension from Microsoft.

The final extension you need is named IntelliCode for C# Dev Kit. This extension provides AI-assisted development for the C# Dev Kit.

## 5. Install the .NET SDK

The C# Dev Kit extension for Visual Studio Code helps you to install the .NET Software Development Kit (SDK). The .NET SDK is required to run and debug C# applications.

At the command prompt, type: 

```bash
`dotnet --version`.
```

This command displays the version number if .NET is installed on your PC.

## 6. Create, build, and run your application

The .NET software development kit (SDK) includes a command-line interface (CLI) that can be accessed from Visual Studio Code's integrated Terminal. During this training, you use .NET CLI commands to create new console applications, build your project code, and run your applications.

For example, the following .NET CLI command will create a new console application in the specified folder location:

```bash
dotnet new console -o ./CsharpProjects/TestProject
```

The structure of a CLI command consists of the following three parts:

- The driver: `dotnet` in this example.
- The command: `new console` in this example.
- The command arguments: `-o` `./CsharpProjects/TestProject` in this example.

To compile a build of your application, enter the following command at the Terminal command prompt:

```bash
dotnet build
```

The `dotnet build` command builds the project and its dependencies into a **set of binaries**. The binaries include the project's code in `Intermediate Language (IL)` files with a `.dll` extension. Depending on the project type and settings, other files may also be included. If you're curious, you can find the .dll file in the EXPLORER panel at a folder location in bin\Debug\net9.0

To run your application, enter the following command at the Terminal command prompt:

```bash
dotnet run
```

The dotnet run command runs source code without any explicit compile or launch commands. It provides a convenient option to run your application from the source code with one command. It's useful for fast iterative development from the command line. The command depends on the dotnet build command to build the code.
