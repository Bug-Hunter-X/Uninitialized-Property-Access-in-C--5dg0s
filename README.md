# Uninitialized Property Access in C#

This repository demonstrates a subtle bug in C# related to accessing class properties that haven't been explicitly initialized in the constructor or elsewhere.  While the code may compile and even run without immediate exceptions, it can lead to unpredictable behavior and hard-to-debug issues.

The `bug.cs` file shows the problematic code.  The `bugSolution.cs` file provides a corrected version.

## Problem

The `ExampleClass` in `bug.cs` has a property `MyProperty`.  The constructor sets the property, but there is no guarantee the property is always initialized if you create an instance without using the constructor (e.g., using reflection). Accessing `MyProperty` before ensuring its initialization can lead to unexpected behavior, particularly if you are not using the constructor to instantiate this class. 

## Solution

The `bugSolution.cs` file demonstrates the solution:  Always initialize the property in the constructor or provide a default value in the property definition.  In this example, the default value is chosen so that it is clear that the property is initialized to a known value.