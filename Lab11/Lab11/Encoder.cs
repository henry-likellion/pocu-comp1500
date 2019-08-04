using System.IO;
using System;


namespace Lab11
{
    public static class Encoder
    {
        public static bool TryEncode(Stream input, Stream output)
        {
            if (input.Length == 0)
            {
                return false;
            }

            var writer = new BinaryWriter(output, System.Text.Encoding.ASCII, false);
            
            int asciiNumber = input.ReadByte();
            int counter = 1;

            for (int i = 1; i <= input.Length; ++i)
            {
                int value = input.ReadByte();

                if (asciiNumber == value)
                {
                    ++counter;
                    if (counter > 255)
                    {
                        writer.Write((byte)255);
                        writer.Write((byte)asciiNumber);
                        counter = 1;
                    }
                }
                else
                {             
                    writer.Write((byte)counter);
                    writer.Write((byte)asciiNumber);

                    asciiNumber = value;
                    counter = 1;
                }
            }

            writer.Flush();

            input.Seek(0, SeekOrigin.Begin);
            output.Seek(0, SeekOrigin.Begin);

            return true;
        }

        public static bool TryDecode(Stream input, Stream output)
        {
            if (input.Length == 0)
            {
                return false;
            }

            var writer = new StreamWriter(output, System.Text.Encoding.ASCII, 512, false);

            int counter = input.ReadByte();

            for (int i = 1; i < input.Length; ++i)
            {
                if (i % 2 == 0)
                {
                    counter = input.ReadByte();
                }
                else
                {
                    int characterInt = input.ReadByte();
                    char character = (char)characterInt;

                    for (int j = 0; j < counter; ++j)
                    {
                        writer.Write(character);
                    }
                }
            }

            writer.Flush();

            input.Seek(0, SeekOrigin.Begin);
            output.Seek(0, SeekOrigin.Begin);
            
            return true;
        }
    }
}