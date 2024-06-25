{\rtf1\ansi\ansicpg1252\cocoartf2761
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
{\*\expandedcolortbl;;}
\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural\partightenfactor0

\f0\fs24 \cf0 using System;\
using System.Collections.Generic;\
using System.Linq;\
\
// Test your Knowledge\
\
// 1. When to use String vs. StringBuilder in C#?\
// Use String for immutable text, StringBuilder for mutable text.\
\
// 2. What is the base class for all arrays in C#?\
// System.Array\
\
// 3. How do you sort an array in C#?\
// Use Array.Sort(array)\
\
// 4. What property of an array object can be used to get the total number of elements in an array?\
// Length\
\
// 5. Can you store multiple data types in System.Array?\
// No, System.Array is of a single data type.\
\
// 6. What\'92s the difference between the System.Array.CopyTo() and System.Array.Clone()?\
// CopyTo() copies elements to an existing array, Clone() creates a shallow copy of the array.\
\
// Practice Arrays\
\
// 1. Copying an Array\
int[] originalArray = \{1, 2, 3, 4, 5, 6, 7, 8, 9, 10\};\
int[] copiedArray = new int[originalArray.Length];\
for (int i = 0; i < originalArray.Length; i++)\
\{\
    copiedArray[i] = originalArray[i];\
\}\
Console.WriteLine("Original array: " + string.Join(", ", originalArray));\
Console.WriteLine("Copied array: " + string.Join(", ", copiedArray));\
\
// 2. Manage a list of elements (Grocery List)\
List<string> groceryList = new List<string>();\
while (true)\
\{\
    Console.WriteLine("Enter command (+ item, - item, or -- to clear):");\
    string input = Console.ReadLine();\
    if (input == "--")\
    \{\
        groceryList.Clear();\
        break;\
    \}\
    else if (input.StartsWith("+"))\
    \{\
        groceryList.Add(input.Substring(2));\
    \}\
    else if (input.StartsWith("-"))\
    \{\
        groceryList.Remove(input.Substring(2));\
    \}\
    Console.WriteLine("Current list: " + string.Join(", ", groceryList));\
\}\
\
// 3. Find Primes in Range\
static int[] FindPrimesInRange(int startNum, int endNum)\
\{\
    List<int> primes = new List<int>();\
    for (int i = startNum; i <= endNum; i++)\
    \{\
        bool isPrime = true;\
        if (i < 2) isPrime = false;\
        for (int j = 2; j <= Math.Sqrt(i); j++)\
        \{\
            if (i % j == 0) isPrime = false;\
        \}\
        if (isPrime) primes.Add(i);\
    \}\
    return primes.ToArray();\
\}\
// Example usage\
int[] primes = FindPrimesInRange(10, 50);\
Console.WriteLine("Primes: " + string.Join(", ", primes));\
\
// 4. Rotate and Sum Arrays\
Console.WriteLine("Enter array elements (space separated):");\
int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);\
Console.WriteLine("Enter number of rotations:");\
int k = int.Parse(Console.ReadLine());\
int[] sum = new int[array.Length];\
for (int r = 1; r <= k; r++)\
\{\
    int[] rotated = new int[array.Length];\
    for (int i = 0; i < array.Length; i++)\
    \{\
        rotated[(i + r) % array.Length] = array[i];\
    \}\
    for (int i = 0; i < array.Length; i++)\
    \{\
        sum[i] += rotated[i];\
    \}\
\}\
Console.WriteLine("Sum array: " + string.Join(", ", sum));\
\
// 5. Longest Sequence of Equal Elements\
Console.WriteLine("Enter array elements (space separated):");\
int[] sequenceArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);\
int maxLength = 1, length = 1, bestElement = sequenceArray[0];\
for (int i = 1; i < sequenceArray.Length; i++)\
\{\
    if (sequenceArray[i] == sequenceArray[i - 1])\
    \{\
        length++;\
        if (length > maxLength)\
        \{\
            maxLength = length;\
            bestElement = sequenceArray[i];\
        \}\
    \}\
    else\
    \{\
        length = 1;\
    \}\
\}\
Console.WriteLine("Longest sequence: " + string.Join(" ", Enumerable.Repeat(bestElement, maxLength)));\
\
// 7. Most Frequent Number\
Console.WriteLine("Enter sequence of numbers (space separated):");\
int[] freqArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);\
var freqDict = new Dictionary<int, int>();\
foreach (int num in freqArray)\
\{\
    if (!freqDict.ContainsKey(num))\
        freqDict[num] = 0;\
    freqDict[num]++;\
\}\
int mostFrequent = freqArray[0];\
foreach (var pair in freqDict)\
\{\
    if (pair.Value > freqDict[mostFrequent])\
        mostFrequent = pair.Key;\
\}\
Console.WriteLine($"Most frequent number is \{mostFrequent\}");\
\
// Practice Strings\
\
// 1. Reverse String\
Console.WriteLine("Enter a string:");\
string inputString = Console.ReadLine();\
char[] charArray = inputString.ToCharArray();\
Array.Reverse(charArray);\
Console.WriteLine("Reversed string (method 1): " + new string(charArray));\
Console.Write("Reversed string (method 2): ");\
for (int i = inputString.Length - 1; i >= 0; i--)\
\{\
    Console.Write(inputString[i]);\
\}\
Console.WriteLine();\
\
// 2. Reverse Words in a Sentence\
Console.WriteLine("Enter a sentence:");\
string sentence = Console.ReadLine();\
string[] words = sentence.Split(new char[] \{ ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\\"', '\\'', '\\\\', '/', '!', '?' \}, StringSplitOptions.RemoveEmptyEntries);\
Array.Reverse(words);\
Console.WriteLine("Reversed sentence: " + string.Join(" ", words));\
\
// 3. Extract and Print Palindromes\
Console.WriteLine("Enter a text:");\
string text = Console.ReadLine();\
string[] textWords = text.Split(new char[] \{ ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\\"', '\\'', '\\\\', '/', '!', '?' \}, StringSplitOptions.RemoveEmptyEntries);\
HashSet<string> palindromes = new HashSet<string>();\
foreach (string word in textWords)\
\{\
    string reversedWord = new string(word.Reverse().ToArray());\
    if (word.Equals(reversedWord))\
    \{\
        palindromes.Add(word);\
    \}\
\}\
Console.WriteLine("Palindromes: " + string.Join(", ", palindromes.OrderBy(p => p)));\
\
// 4. Parse URL\
Console.WriteLine("Enter a URL:");\
string url = Console.ReadLine();\
Uri uri = new Uri(url);\
string protocol = uri.Scheme;\
string server = uri.Host;\
string resource = uri.AbsolutePath;\
Console.WriteLine($"[protocol] = \\"\{protocol\}\\"\\n[server] = \\"\{server\}\\"\\n[resource] = \\"\{resource.TrimStart('/')\}\\"");\
}