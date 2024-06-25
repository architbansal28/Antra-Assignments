{\rtf1\ansi\ansicpg1252\cocoartf2761
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 using System;\
\
// Test your Knowledge\
\
// 1. Data types for various items\
// A person\'92s telephone number: string\
// A person\'92s height: float or double\
// A person\'92s age: int\
// A person\'92s gender: enum (Male, Female, PreferNotToAnswer)\
// A person\'92s salary: decimal\
// A book\'92s ISBN: string\
// A book\'92s price: decimal\
// A book\'92s shipping weight: float or double\
// A country\'92s population: long\
// The number of stars in the universe: ulong\
// The number of employees in each of the small or medium businesses in the UK: ushort\
\
// 2. Value type vs Reference type variables\
// Value type will directly hold the value while reference type will hold the memory address or reference for the value. \
// Value types are stored in stack memory and reference types are stored in heap memory. \
// Value type will not be collected by garbage collector but reference type will be collected by garbage collector. \
// The value type can be created by struct or enum while reference type can be created by class, interface, delegate or array.\
// Value type can not accept any null values while reference types can accept null values.\
\
// 3. Managed resource vs Unmanaged resource\
// Managed resources are handled by the .NET runtime (e.g., memory), unmanaged resources are not (e.g., file handles, database connections).\
\
// 4. Purpose of Garbage Collector in .NET\
// To automatically release memory occupied by objects that are no longer in use to prevent memory leaks.\
\
// Playing with Console App\
Console.WriteLine("Hello, this is a different message!");\
\
// Console application to generate hacker name\
Console.WriteLine("Enter your favorite color:");\
string color = Console.ReadLine();\
Console.WriteLine("Enter your astrology sign:");\
string sign = Console.ReadLine();\
Console.WriteLine("Enter your street address number:");\
string addressNumber = Console.ReadLine();\
Console.WriteLine($"Your hacker name is \{color\}\{sign\}\{addressNumber\}");\
\
// Practice number sizes and ranges\
Console.WriteLine($"sbyte: \{sizeof(sbyte)\} bytes, min: \{sbyte.MinValue\}, max: \{sbyte.MaxValue\}");\
Console.WriteLine($"byte: \{sizeof(byte)\} bytes, min: \{byte.MinValue\}, max: \{byte.MaxValue\}");\
Console.WriteLine($"short: \{sizeof(short)\} bytes, min: \{short.MinValue\}, max: \{short.MaxValue\}");\
Console.WriteLine($"ushort: \{sizeof(ushort)\} bytes, min: \{ushort.MinValue\}, max: \{ushort.MaxValue\}");\
Console.WriteLine($"int: \{sizeof(int)\} bytes, min: \{int.MinValue\}, max: \{int.MaxValue\}");\
Console.WriteLine($"uint: \{sizeof(uint)\} bytes, min: \{uint.MinValue\}, max: \{uint.MaxValue\}");\
Console.WriteLine($"long: \{sizeof(long)\} bytes, min: \{long.MinValue\}, max: \{long.MaxValue\}");\
Console.WriteLine($"ulong: \{sizeof(ulong)\} bytes, min: \{ulong.MinValue\}, max: \{ulong.MaxValue\}");\
Console.WriteLine($"float: \{sizeof(float)\} bytes, min: \{float.MinValue\}, max: \{float.MaxValue\}");\
Console.WriteLine($"double: \{sizeof(double)\} bytes, min: \{double.MinValue\}, max: \{double.MaxValue\}");\
Console.WriteLine($"decimal: \{sizeof(decimal)\} bytes, min: \{decimal.MinValue\}, max: \{decimal.MaxValue\}");\
\
// Convert centuries to various units\
Console.WriteLine("Enter number of centuries:");\
int centuries = int.Parse(Console.ReadLine());\
long years = centuries * 100;\
long days = years * 36524 / 100;\
long hours = days * 24;\
long minutes = hours * 60;\
long seconds = minutes * 60;\
long milliseconds = seconds * 1000;\
long microseconds = milliseconds * 1000;\
long nanoseconds = microseconds * 1000;\
Console.WriteLine($"\{centuries\} centuries = \{years\} years = \{days\} days = \{hours\} hours = \{minutes\} minutes = \{seconds\} seconds = \{milliseconds\} milliseconds = \{microseconds\} microseconds = \{nanoseconds\} nanoseconds");\
\
// Controlling Flow and Converting Types\
\
// 1. Dividing an int by 0 results in a runtime exception (DivideByZeroException).\
// 2. Dividing a double by 0 results in Infinity.\
// 3. Overflowing an int variable results in wrap around if unchecked, runtime exception if checked.\
// 4. x = y++; assigns x the value of y, then increments y. x = ++y; increments y, then assigns x the value of y.\
// 5. break exits the loop, continue skips to the next iteration, return exits the method.\
// 6. Initialization, condition, and iteration. Only condition is required.\
// 7. = is assignment, == is equality comparison.\
// 8. Yes, it compiles and results in an infinite loop.\
// 9. _ in a switch expression is a discard pattern, matches any value not previously matched.\
// 10. IEnumerable interface must be implemented to use foreach.\
\
// Practice loops and operators\
// FizzBuzz game\
for (int i = 1; i <= 100; i++)\
\{\
    if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("fizzbuzz");\
    else if (i % 3 == 0) Console.WriteLine("fizz");\
    else if (i % 5 == 0) Console.WriteLine("buzz");\
    else Console.WriteLine(i);\
\}\
\
// Simulate the given code and observe the overflow\
int max = 500;\
// for (byte i = 0; i < max; i++)\
// \{\
//     Console.WriteLine(i);\
// \}\
// To warn about the problem, we can check the type before the loop and print a warning\
if (max > byte.MaxValue)\
\{\
    Console.WriteLine("Warning: max exceeds byte.MaxValue, overflow will occur.");\
\}\
\
// Random number guessing game\
int correctNumber = new Random().Next(3) + 1;\
Console.WriteLine("Guess a number between 1 and 3:");\
int guessedNumber = int.Parse(Console.ReadLine());\
if (guessedNumber < 1 || guessedNumber > 3) Console.WriteLine("Out of range!");\
else if (guessedNumber < correctNumber) Console.WriteLine("Too low!");\
else if (guessedNumber > correctNumber) Console.WriteLine("Too high!");\
else Console.WriteLine("Correct!");\
\
// Print a pyramid\
int n = 5;\
for (int i = 1; i <= n; i++)\
\{\
    for (int j = 0; j < n - i; j++) Console.Write(" ");\
    for (int k = 0; k < 2 * i - 1; k++) Console.Write("*");\
    Console.WriteLine();\
\}\
\
// Birthdate and days old calculation\
DateTime birthDate = new DateTime(1999, 7, 28);\
TimeSpan age = DateTime.Now - birthDate;\
Console.WriteLine($"You are \{age.Days\} days old.");\
\
// Date of the next 10,000 day anniversary\
int daysToNextAnniversary = 10000 - (age.Days % 10000);\
DateTime nextAnniversary = DateTime.Now.AddDays(daysToNextAnniversary);\
Console.WriteLine($"Your next 10,000 day anniversary is on \{nextAnniversary.ToShortDateString()\}");\
\
// Greeting based on time of day\
DateTime now = DateTime.Now;\
if (now.Hour >= 5 && now.Hour < 12) Console.WriteLine("Good Morning");\
if (now.Hour >= 12 && now.Hour < 16) Console.WriteLine("Good Afternoon");\
if (now.Hour >= 16 && now.Hour < 20) Console.WriteLine("Good Evening");\
if (now.Hour >= 20 || now.Hour < 5) Console.WriteLine("Good Night");\
\
// Counting using different increments\
for (int i = 1; i <= 4; i++)\
\{\
    for (int j = 0; j <= 24; j += i)\
    \{\
        Console.Write(j + (j == 24 ? "\\n" : ","));\
    \}\
\}\
}