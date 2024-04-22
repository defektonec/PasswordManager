using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorV2
{
    public class PasswordGenerator
    {
        private const string PasswordCharsLcase = "qwertyuiopasdfghjklzxcvbnm";
        private const string PasswordCharsUcase = "QWERTYUIOPASDFGHJKLZXCVBNM";
        private const string PasswordCharsNumeric = "12345678901234567890123456";
        private const string PasswordCharsSpecial = "@#$[]@#$[]@#$[]@#$[]@#$[]}";
        static public string Generate(int lenght, bool useLcase, bool useUcase, bool useNums, bool useSpecific)
        {
            Random rand = new Random();
            string GeneratedPassword = string.Empty;
            for (int i = 0; i < lenght; i++)
            {
                int groupUse = rand.Next(4);
                int charUse = rand.Next(0, 26);

                switch (groupUse)
                {
                    case (0):
                        {
                            if (!useLcase) { i--; continue; }
                            GeneratedPassword += PasswordCharsLcase[charUse];
                            break;
                        }
                    case (1):
                        {
                            if (!useUcase) { i--; continue; }
                            GeneratedPassword += PasswordCharsUcase[charUse];
                            break;
                        }
                    case (2):
                        {
                            if (!useNums) { i--; continue; }
                            GeneratedPassword += PasswordCharsNumeric[charUse];
                            break;
                        }
                    case (3):
                        {
                            if (!useSpecific) { i--; continue; }
                            GeneratedPassword += PasswordCharsSpecial[charUse];
                            break;
                        }
                }
            }
            return GeneratedPassword;
        }
    }
}
