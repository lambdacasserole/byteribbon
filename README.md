# ByteRibbon
A simple little Brainfuck interpreter in C#.

For absolutely no reason at all, I present a very hasty and slow Brainfuck interpreter in C#. Maybe I'll get around to optimising it one day.

Here's a hello world program in Brainfuck:

```
++++++++[>++++[>++>+++>+++>+<<<<-]>+>+>->>+[<]<-]>>.>---.+++++++..+++.>>.<-.<.+++.------.--------.>>+.>++.
```

The following table is straight from [Wikipedia's table of Brainfuck commands](https://en.wikipedia.org/wiki/Brainfuck#Commands):

|  Brainfuck  | Meaning                                                                                                                                                                           |
|-------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `>`         | Increment the data pointer (to point to the next cell to the right).                                                                                                              |
| `<`         | Decrement the data pointer (to point to the next cell to the left).                                                                                                               |
| `+`         | Increment (increase by one) the byte at the data pointer.                                                                                                                         |
| `-`         | Decrement (decrease by one) the byte at the data pointer.                                                                                                                         |
| `.`         | Output the byte at the data pointer.                                                                                                                                              |
| `,`         | Accept one byte of input, storing its value in the byte at the data pointer.                                                                                                      |
| `[`         | If the byte at the data pointer is zero, then instead of moving the instruction pointer forward to the next command, jump it forward to the command after the matching ] command. |
| `]`         | If the byte at the data pointer is nonzero, then instead of moving the instruction pointer forward to the next command, jump it back to the command after the matching [ command. |
| `N/A`       | Denotes a single-line comment.                                                                                                                                                    |

You're essentially manipulating a [Turing machine](https://en.wikipedia.org/wiki/Turing_machine) to produce output.

## Usage
Compile the project in Visual Studio, run it like this:

```
ByteRibbon.exe "examples/hello.b"
```

## Limitations
Largely untested and very unoptimized, the Turing machine underlying the language is a very hasty port from the PHP version in [my ancient Brainfony repository](https://github.com/lambdacasserole/brainfony). It's gonna be buggy and slow.

Also, random inline text will break the tokenizer. It's easy to change this so you can stick non-instructions wherever you like (like I believe Urban Muller's [original Brainfuck implementation](https://gist.github.com/rdebath/0ca09ec0fdcf3f82478f) does) by changing the regular expressions that the tokenizer is initialized with.

## Contributing
If you find a bug and would really like to contribute for whatever reason, feel free to fork and submit a pull request.
