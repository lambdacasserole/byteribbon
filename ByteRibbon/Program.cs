using System;
using System.IO;

namespace ByteRibbon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure tokenizer.
            var tokenizer = new Tokenizer();
            tokenizer.Add(@">", TokenType.MoveRight);
            tokenizer.Add(@"<", TokenType.MoveLeft);
            tokenizer.Add(@"\+", TokenType.Increment);
            tokenizer.Add(@"-", TokenType.Decrement);
            tokenizer.Add(@"\.", TokenType.Output);
            tokenizer.Add(@",", TokenType.Input);
            tokenizer.Add(@"\[", TokenType.StartLoop);
            tokenizer.Add(@"\]", TokenType.EndLoop);
            tokenizer.Add(@".+?", TokenType.Noop);

            // Check file exists.
            var filepath = args[0];
            if (!File.Exists(filepath))
            {
                Console.WriteLine("Error opening input file.");
                return;
            }

            // Tokenize source.
            var tokens = tokenizer.Tokenize(File.ReadAllText(filepath));

            // Execute program.
            var machine = new TuringMachine(tokens);
            machine.Run();
        }
    }
}
