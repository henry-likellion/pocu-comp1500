using System.Diagnostics;
using System.IO;

namespace Lab11
{
    class Program
    {
        private const string ENCODE_TEST1 = "encode1.txt";

        static void Main(string[] args)
        {
            setup();

            

            using (Stream read = File.OpenRead(ENCODE_TEST1))
            using (Stream write = File.OpenWrite($"{ENCODE_TEST1}.output.bin"))
            {
                bool bEncoded = Encoder.TryEncode(read, write);
                Debug.Assert(bEncoded);
            }
        }

        private static void setup()
        {
            if (File.Exists($"{ENCODE_TEST1}.output.bin"))
            {
                File.Delete($"{ENCODE_TEST1}.output.bin");
            }
        }
    }
}