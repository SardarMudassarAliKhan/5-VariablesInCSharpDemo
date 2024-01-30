In C#, a variable is a named storage location in the computer's memory where you can store data that can be manipulated and used in your program. Before you can use a variable in C#, you must declare it, specifying the type of data it will hold.

Here's how you declare a variable in C#:

```csharp
<type> <variableName>;
```

For example:

```csharp
int age;
```

In this example, `int` is the data type for integer numbers, and `age` is the name of the variable.

You can also assign a value to the variable at the time of declaration:

```csharp
<type> <variableName> = <value>;
```

For example:

```csharp
int age = 30;
```

Once a variable is declared, you can assign new values to it later in your program:

```csharp
age = 35;
```

C# supports various data types for variables, including:

- **Numeric Types:** `int`, `float`, `double`, `decimal`, etc.
- **Boolean Type:** `bool`
- **Character Type:** `char`
- **String Type:** `string`

You can also declare variables as reference types, such as classes, interfaces, arrays, delegates, and enumerations.

Variables in C# are case-sensitive, meaning `age`, `Age`, and `AGE` would be considered different variables.

It's important to note that variables in C# have a scope, which determines where in your code they can be accessed. The scope of a variable is defined by the code block in which it is declared.

Finally, C# also supports constants, which are variables whose values cannot be changed once they are assigned. Constants are declared using the `const` keyword.

```csharp
const double Pi = 3.14;
```

This declaration creates a constant named `Pi` with a value of `3.14`, and you cannot assign a different value to `Pi` later in your program.

Understanding variables is fundamental to programming in C# as they are used to store and manipulate data throughout your code.
