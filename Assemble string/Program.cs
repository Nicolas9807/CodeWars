using System;

namespace Assemble_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] arr = new[] { "a*cde", "*bcde", "abc*e" };
            string res = Assemble(arr);
            
            Console.WriteLine(res);
        }
        
        public static string Assemble(string[] copies) {
            if (copies.Length == 0 || copies[0] == "" && copies[1] == "" && copies[2] == "")
                return "";
            string s1 = copies[0], s2 = copies[1], s3 = copies[2], rezult = "";
            bool z = true;
    
            for (int i = 0; i < s1.Length; i++)
            {
                z = true;
                if (s1[i] != '*')
                {
                    z = false;
                    rezult += s1[i];
                }
                else if (s2[i] != '*' && z)
                {
                    z = false;
                    rezult += s2[i];
                }
                else if (s3[i] != '*' && z)
                {
                    z = false;
                    rezult += s3[i];
                }
                else 
                    rezult += "#";
        
            }
    
            return rezult;
        }
    }
}