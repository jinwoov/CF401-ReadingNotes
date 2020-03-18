# System.IO

- File and stream I/O refers to the transfer of data either to or from storage medium.
- System.IO namespace contain types that enable reading and writing, both synchronously and asynchronously.
- Files and commonly used classes are 
    - file: provide copying, deleting, moving and oning files and helps create file stream object
    - fileinfo: provide instance methods for creating copying deleting, moving and opening files.

---
System IO is name space which you can include on top of your `using` statement
ie.
```
using System.IO;
```
`System.IO` can perform
1. Reading
2. Writing 
    - Both can be perform synchronously and asynchronously on data streams and files.
3. Compress
4. Decompress

Using the `System.IO`, you can use files and directories and retrieve information from designated path.

Class `Stream` can use to support reading and writing.

To synchronously write text with streamwriter
ie.
```
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
    
    // Create a string array with the lines of text
        string[] lines = { "First line", "Second line", "Third line" };

    // Set a variable to the Documents path.
        string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

     // Write the string array to a new file named "WriteLines.txt".
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
        {
            foreach (string line in lines)
                outputFile.WriteLine(line);
        }
    }
}
```
The outout put of previous code block will insert in WritLine.txt file with contents of First line, Second line and Third line, respectively.

The Text is from sting[] lines array and this was instantiated using `foreach` loop.

`outputFile.WriteLine(x)` is what writes in the contents from lines array.

To append the text from pre existing text you can have put `true` boolean when object is instantiated  

To write `asynchronousy`, without having the user wait, you can write in `WriteAsync` instead of `WriteLine` with `await` in front of that same line.
    - Also include asyn to the method to flag the compiler to run this asynchronously

