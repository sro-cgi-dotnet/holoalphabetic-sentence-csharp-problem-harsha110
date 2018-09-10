using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
           int[] hash_sentence = new int[26];
           int i=0,count,position=0,alphabets_check=0;
        int length = input.Length;

        for (int j=0; j<26; j++)
        {
            hash_sentence[j]=0;
        }
         while(i<length)
           {
               count = input[i];
               if(count>=65&&count<=90)
               {
                   position=count-65;
                   goto start;
               }
               else if(count>=97&&count<=122)
               {
                   position=count-97;
                   goto start;
               }

               start:
                 if(hash_sentence[position]!=1)
                {
                   alphabets_check++;
                   hash_sentence[position]=1;
                }

                 i++;
               
           }
          if(alphabets_check==26)
          {
           return true;
          }
          else
          {
              return false;
          }
            
        }
    }
}
