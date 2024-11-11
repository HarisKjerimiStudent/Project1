# Project1
Currency Converter Console Application

Project Overview

Welcome to the Currency Converter,a console application designed to effortlessly switch between over global currencies, with a special focus on the currencies of Bosnia and Herzegovina, Albania, Kosovo, North Macedonia, Serbia, and Croatia. Each calculation is recorded in a .TXT file, ensuring you never lose track of your financial calculations.

Description

    Python: Python handles user input, asks the user for the currencies and amount, and then calls JavaScript to perform the conversion. Afterward, it invokes C# to save the conversion history to a .TXT file.

    JavaScript: JavaScript manages the exchange rate calculations based on pre-configured conversion rates, returning the result to Python.

    C#: C# is responsible for saving the conversion data to the conversion_history.txt file, ensuring every conversion is logged.

Key Features

    Multi-Currency Conversion: converts between over major currencies, including preset exchange rates, with a simple command. From the US Dollar to the Euro, from the Bosnian Convertible Mark to the Croatian Kuna..
    History Tracking: Every conversion is recorded in conversion_history.txt, creating a valuable log that you can revisit at any time.
    Integration: Python collects the user input, calls JavaScript for the conversion, and C# saves the conversion history in a file.

The following tools are installed and configured on your system:

    .NET SDK (for C#)
    Node.js (for JavaScript)
    Python (for handling user input and saving conversion history)

Setup

    Download or clone the project repository to your local machine.
    Make sure that all core files (currencyConverter.js, save_conversion.py, CurrencyConverter.cs) reside in the same directory.
    Open a terminal and verify your setup by running the following commands:
        dotnet --version
        node --version
        python --version

How to Run the App

    Open your project folder in the terminal.
    Run the following command to launch the app:
        dotnet run


Once the app is up and running:
    Pick Your Starting Currency: Enter the currency code of the currency you want to convert from (BAM,USD,EUR).
    Pick Your Target Currency: Enter the currency code for the destination currency.
    Enter the Amount: Enter the amount you like to covert.
    Save Your Conversion: Every conversion is automaticaly saved in conversion_history.txt, providing a digital trail of your financial transactions.

File Breakdown

    CurrencyConverter.cs (C#)

        Main Function: Saves the conversion data into the conversion_history.txt file.

    currencyConverter.js (JavaScript)

        Main Function: convertCurrency, gets the appropriate exchang rate, performs the calculation, and returns the result to Python.

    conversion.py (Python)

        Main Function: Collects user input and coordinates with JavaScript and C# to perform the conversion and save the result.

License

This project is open-source and free for anyone to use, modify.

Haris Kjerimi
Student ID: 21030215
