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


## How to use:
1. Open the app.<img width="1505" height="813" alt="image" src="https://github.com/user-attachments/assets/d7b484d6-4c87-4192-baf1-2418a51c055e" />
2. Choose which function you want to use: The app has 22 different options, type the number corresponding with your desired choice.<img width="635" height="678" alt="image" src="https://github.com/user-attachments/assets/a0ad6bbf-10ca-4e93-9e56-da281bf4fbfd" /> (As an example, 2 will lead us to the second choice, ``Binary to Decimal``
3. Press enter once you've selected a function and typed its' corresponding number
4. You will now receive instructions what to type, example (continuing from the previously selected choice 2:) <img width="1104" height="703" alt="image" src="https://github.com/user-attachments/assets/02fd825a-669b-40f5-af4f-66b28fd76ad5" />, let's type 1100 as an example
5. Once typed, press "Enter"
6. You will now see the steps which the program took to get to the answer, and the answer itself

<img width="660" height="241" alt="image" src="https://github.com/user-attachments/assets/78981757-f02a-42e2-94d5-a2540bd42121" />

7. Press any key to enter the Main Menu


### Bonus menu commands:
1. "Menu" or "M": Typing those commands in certain input lines will allow you to go back to the Main Menu, and start the selection process again
2.  "Exit" or "Q" or "X": Typing those commands in certain input lines will allow you to exit the program
3.  Control+C, acts the same way as Command 2, but more reliably as it works on all input lines.




