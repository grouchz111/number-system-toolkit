# Numeral Systems Calculator (Console App)

This is a C# console application that converts numbers between many different numeral systems and performs basic arithmetic both within and across those systems.
The project is intended as an educational tool, with many conversions showing step-by-step output to illustrate how the algorithms work.

## Features

Conversions between many numeral systems:

_Binary, Octal, Hexadecimal_

_Roman numerals_

_Base-N (custom bases)_

_Unary, Duodecimal, Vigesimal_

_Negabinary, Balanced Ternary_

_Factorial number system_

_Bijective numeration (e.g. base-26 without zero)_

_Arithmetic operations within a system_

_Arithmetic across systems (numbers are converted to decimal, computed, then converted back)_

_Input validation using TryParse to prevent crashes on invalid input_

## Project Structure

**Program.cs**
Entry point of the application.
Contains the console menu and dispatch logic for all available operations.

**TryParse.cs**
Helper class for safely parsing user input into int values without throwing exceptions.

**ArithmeticAcrossSystemsOperations.cs**
Handles arithmetic between different numeral systems.
All inputs are converted to decimal, the operation is performed, and results are converted back to the selected systems.

Operation / Conversion Classes
Each numeral system or feature is implemented in its own class:

``Arithmethic.cs``

``Balanced Ternary.cs``

``BaseN Operations.cs``

``Bijective Operations.cs``

``Binary Operations.cs``

``DecimalDoublesToBinatyOperations.cs``

``doublestobinary operations.cs``

``DuoDecimal Operations.cs``

``factorial operations.cs``

``FactorialOperations.cs``

``Hex Operations.cs``

``int shift operation.cs``

``MedianOperations.cs``

``NegaBinary Operations.cs``

``Octal Operations.cs``

``Roman Operations.cs``

``ShiftlntOperations.cs``

``Unary Operations.cs``

``Vigesimal Operations.cs``
