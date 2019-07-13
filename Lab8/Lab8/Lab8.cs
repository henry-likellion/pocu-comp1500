using System;
using System.Text;

namespace Lab8
{
    public static class Lab8
    {
        public static string PrettifyList(string s)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                return null;
            }

            char[] secondListAlphabets = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int countLevel1 = 0;
            
            string[] strArrayLevel1 = s.Split('|');

            StringBuilder concatSB = new StringBuilder(2048);

            for (int i = 0; i < strArrayLevel1.Length; ++i)
            {
                countLevel1++;
                strArrayLevel1[i] = $"{countLevel1}) {strArrayLevel1[i]}";

                string[] strArrayLevel2 = strArrayLevel1[i].Split("_");

                int countLevel2 = 0;

                for (int j = 0; j < strArrayLevel2.Length; ++j)
                {
                    if (j == 0)
                    {
                        strArrayLevel2[j] = $"{strArrayLevel2[j]}\r\n";
                        concatSB.Append(strArrayLevel2[j]);
                    }
                    else
                    {
                        strArrayLevel2[j] = $"    {secondListAlphabets[countLevel2]}) {strArrayLevel2[j]}";
                        countLevel2++;

                        string[] strArrayLevel3 = strArrayLevel2[j].Split("/");

                        for (int k = 0; k < strArrayLevel3.Length; ++k)
                        {
                            if (k == 0)
                            {
                                strArrayLevel3[k] = $"{strArrayLevel3[k]}\r\n";
                            }
                            else
                            {
                                strArrayLevel3[k] = $"        - {strArrayLevel3[k]}\r\n";
                            }
                            concatSB.Append(strArrayLevel3[k]);
                        }
                    }
                }
            }

            string concatString;

            concatString = concatSB.ToString();
            
            return concatString;
        }
    }
}