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

            int asciiNumber = input.ReadByte();
            byte counter = 1;

            using (var writer = new BinaryWriter(output))
            {
                for (int i = 1; i <= input.Length; ++i)
                {
                    int value = input.ReadByte();

                    if (i == input.Length)
                    {

                        writer.Write(counter);
                        writer.Write((byte)asciiNumber);
                    }

                    if (asciiNumber == value)
                    {
                        ++counter;
                    }
                    else
                    {
                        writer.Write(counter);
                        writer.Write((byte)asciiNumber);

                        asciiNumber = value;
                        counter = 1;
                    }
                }
            }

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

            using (var writer = new StreamWriter(output))
            {
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
            }

            input.Seek(0, SeekOrigin.Begin);
            output.Seek(0, SeekOrigin.Begin);

            return true;
        }
    }
}