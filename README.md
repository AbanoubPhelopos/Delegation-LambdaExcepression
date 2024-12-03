# Delegation Project

## Overview

This project demonstrates the use of delegates in C# to implement filtering and conditional logic for employees' data. The application generates a list of employees with various attributes like salary, bonus, and tax. It provides multiple ways to filter and display employee information using both traditional methods and delegates, including anonymous functions and lambda expressions.

---

## Project Structure

### **Namespaces and Classes**

1. **Delegation.Model**
   - `Employee`: Represents an employee with properties for ID, name, basic salary, bonus, tax, and total salary.

2. **Delegation.Data**
   - `ApplicationDb`: Generates and stores an array of employees with random salaries, bonuses, and tax values.

3. **Delegation.Delegates**
   - `FilteredFunctions` : Contains reusable static methods for conditions such as salary, bonus, and tax comparisons.
   - `Filter`: Uses a delegate to filter and display employees based on dynamic conditions.
   - `FilterEmp`: Contains hardcoded filtering methods for specific conditions.
   - `IntoToDelegate`: Demonstrates the use of custom delegates to implement filtering dynamically.

4. **TestCode**
   - Contains the `Program` class with examples and test cases for demonstrating:
     - Basic delegate usage.
     - Filtering employees with and without delegates.
     - Anonymous functions and lambda expressions.
     - Built-in delegate types: `Predicate`, `Action`, and `Func`.

---
## Student Hands-on
1. Implement Filter By Bonus and Filter By Tax Methods


## Students Task
1. **Implement the Filter example using `Built in Delegates ..` 
