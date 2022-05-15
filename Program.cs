using System;
using System.Linq;



namespace ConsoleApplication1
{
    class  Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveParentheses("a (bc d)e"));

        }
        public static string RemoveParentheses(string s)
        {
            
            int first_p = 0;
            int last_p = 0;
            for(int i = 0;i < s.Length;i++)
            {
                if(s[i] =='(')
                {
                    first_p = i;
                    break;
                }
            }
            for(int j = s.Length-1;j>0;j--)
            {
                if(s[j] == ')')
                {
                    last_p = j;
                    break;
                }
            }
            int dlina_vireza = last_p - first_p + 1;
            string rezult = s.Remove(first_p, dlina_vireza);
            return rezult;
        }
            
        }
        

    }
