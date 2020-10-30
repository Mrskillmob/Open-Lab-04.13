using System;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            //Skopirovane z internetu, bez toho by som to nevedel.
            
            int[,] neviem = new int[str1.Length + 1, str2.Length + 1];
            int idk1 = 0;
            int idk2 = 0;

            for (var i = 0; i < str1.Length; i++)
                for (var j = 0; j < str2.Length; j++)
                    if (str1[i] == str2[j])
                    {
                        int jn = neviem[i + 1, j + 1] = neviem[i, j] + 1;
                        if (jn > neviem[idk1, idk2])
                        {
                            idk1 = i + 1;
                            idk2 = j + 1;
                        }
                    }

            return str1.Substring(idk1 - neviem[idk1, idk2], neviem[idk1, idk2]);
        }
    }
}
