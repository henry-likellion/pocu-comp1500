using System.Text;

namespace Lab8
{
    public static class Lab8
    {
        public static string PrettifyList(string s)
        {
            if (s == "" || s == null)
            {
                return null;
            }

            if (s.Replace(" ", "") == "")
            {
                return null;
            }

            char[] SECOND_LIST_ALPHABETS = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int count_level_1 = 0;
            
            string[] strArrayLevel1 = s.Split('|');

            int count_number_lines = strArrayLevel1.Length;

            string concatString = "";

            StringBuilder concatSB = new StringBuilder(2048);

            for (int i = 0; i < count_number_lines; ++i)
            {
                count_level_1++;
                strArrayLevel1[i] = $"{count_level_1}) {strArrayLevel1[i]}";

                string[] strArrayLevel2 = strArrayLevel1[i].Split("_");

                int count_level_2 = 0;

                for (int j = 0; j < strArrayLevel2.Length; ++j)
                {
                    if (j == 0)
                    {
                        strArrayLevel2[j] = $"{strArrayLevel2[j]}\r\n";
                        concatSB.Append(strArrayLevel2[j]);
                    }
                    else
                    {
                        strArrayLevel2[j] = $"    {SECOND_LIST_ALPHABETS[count_level_2]}) {strArrayLevel2[j]}";
                        count_level_2++;

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

            concatString = concatSB.ToString();
            
            return concatString;
        }
    }
}