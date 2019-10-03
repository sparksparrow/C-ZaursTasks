namespace C_____learning
{
    class ACipher : ICipher
    {
        public string decode(string str)
        {
            try
            {
                string result = null; ;
                for (int i = 0; i < str.Length; i++)
                {
                    switch (str[i])
                    {
                        case 'A':
                            result += 'Z';
                            break;
                        case 'a':
                            result += 'z';
                            break;
                        default:
                            result += (char)((int)str[i] - 1);
                            break;
                    }

                }
                return result;
            }
            catch(System.NullReferenceException)
            {
                System.Console.WriteLine("Ошибка");
                return null;
            }
        }
        public string encode(string str)
        {
            try { 
                 string result = null; ;
                 for (int i = 0; i < str.Length; i++)
                 {
                     switch (str[i])
                     {
                        case 'Z':
                             result += 'A';
                             break;
                         case 'z':
                             result += 'a';
                             break;
                         default:
                             result += (char)((int)str[i] + 1);
                             break;
                     }

                 }
                 return result;
                 }
                 catch(System.NullReferenceException)
                 {
                    System.Console.WriteLine("Ошибка");
                    return null;
                 }
        }
    }
}
