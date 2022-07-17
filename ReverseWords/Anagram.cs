using System;

namespace ReverseWords
{
    public class Anagram
    {
        private static string ReverseWord(string word)
        {
            char[] arr1 = word.ToCharArray();
            for (int i = 0, j = arr1.Length - 1; (i < arr1.Length || j >= 0);)
            {
                if (char.IsLetter(arr1[i]) && char.IsLetter(arr1[j]))
                {
                    char curChar = arr1[i];
                    arr1[i] = arr1[j];
                    arr1[j] = curChar;
                    i++;
                    j--;
                }
                else if (!char.IsLetter(arr1[i]))
                    i++;
                else if (!char.IsLetter(arr1[j]))
                    j--;

                if (i == j || i - j == 1)                
                    break;               
            }
            return new string(arr1);
        }

        public string ReversePhrase(string phrase)
        {
            if (string.IsNullOrEmpty(phrase))
                return string.Empty;

            string[] strArray = phrase.Split(' ');

            for (int i = 0; i < strArray.Length; i++)
                strArray[i] = ReverseWord(strArray[i]);
            
            return string.Join(" ", strArray);
        }

        public string Similar()
        {
            int[] a = new int[] {46, 6, 23, 1, 46, 12, 22, 76, 32, 65, 34, 7, 98 };
            bool result = false;
            int cur = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = a[i]+1; j < a.Length; j++)
                {
                    if (cur == a[j] && i != j)
                        return "Алярм";
                }
            }
            return "Нот алярм!";
        }
    }
}
