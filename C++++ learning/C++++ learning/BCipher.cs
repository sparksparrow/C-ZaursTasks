namespace C_____learning
{
    class BCypher : ICipher
    {
        public string decode(string str)
        {
            try
            {
                string result = null; ;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= (int)'A' && str[i] <= 'Z')
                        result += (char)((((int)'Z' - (int)'A') - ((int)str[i] - (int)'A')) + (int)'A');
                    else
                       if (str[i] >= (int)'a' && str[i] <= 'z')
                        result += (char)((((int)'z' - (int)'a') - ((int)str[i] - (int)'a')) + (int)'a');
                    else
                   if (str[i] >= (int)'А' && str[i] <= 'Я')
                        result += (char)((((int)'Я' - (int)'А') - ((int)str[i] - (int)'А')) + (int)'А');
                    else
                   if (str[i] >= (int)'а' && str[i] <= 'я')
                        result += (char)((((int)'я' - (int)'а') - ((int)str[i] - (int)'а')) + (int)'а');

                }
                return result;
            }
            catch (System.NullReferenceException)
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
                if (str[i] >= (int)'A' && str[i] <= 'Z')
                    result += (char)((((int)'Z' - (int)'A') - ((int)str[i] - (int)'A')) + (int)'A');
                else
                    if (str[i] >= (int)'a' && str[i] <= 'z')
                    result += (char)((((int)'z' - (int)'a') - ((int)str[i] - (int)'a')) + (int)'a');
                else
                if (str[i] >= (int)'А' && str[i] <= 'Я')
                    result += (char)((((int)'Я' - (int)'А') - ((int)str[i] - (int)'А')) + (int)'А');
                else
                if (str[i] >= (int)'а' && str[i] <= 'я')
                    result += (char)((((int)'я' - (int)'а') - ((int)str[i] - (int)'а')) + (int)'а');
            }
            return result;
            }
            catch (System.NullReferenceException)
            {
                System.Console.WriteLine("Ошибка");
                return null;
            }
        }
    }
}
