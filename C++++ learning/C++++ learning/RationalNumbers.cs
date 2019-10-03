namespace C_____learning
{
    [AttributeInfo("Алексей", "25.09.2019")]
    class RationalNumbers
    {
        int numerator;
        int denominator;

        internal RationalNumbers(int i, int k)
        {
            this.numerator = i;
            this.denominator = k;
        }

        public static bool operator ==(RationalNumbers First, RationalNumbers Second) // Переопределение ==   (== по умолчанию возвращает true если обе ссылки указывают на один объект )
        {
            return First.numerator == Second.numerator && First.numerator == Second.numerator;
        }
        public static bool operator !=(RationalNumbers First, RationalNumbers Second) // Переопределение !=
        {
            return First.numerator != Second.numerator || First.numerator != Second.numerator;
        }
        public override bool Equals(object obj)
        {
            try
            {
                if (obj == null)
                    return false;
                RationalNumbers rationalnumber= obj as RationalNumbers; // возвращает null если объект нельзя привести к типу Bank          
                return rationalnumber.numerator == this.numerator && rationalnumber.denominator == this.denominator;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }//переопределение Equals
        public override int GetHashCode()
        {            
            return numerator+denominator;
        } //возвращает код (сумма numerator и denominator)
        public override string ToString()
        {
            return this.numerator+"/"+this.denominator;
        }//Возвращает информацию о счете

        public static bool operator <(RationalNumbers First, RationalNumbers Second) // Переопределение <   
        {
            return First.numerator < Second.numerator && First.denominator == Second.denominator || First.numerator == Second.numerator && First.denominator > Second.denominator || First.numerator < Second.numerator && First.denominator > Second.denominator;
        }
        public static bool operator >(RationalNumbers First, RationalNumbers Second) // Переопределение >   
        {
            return First.numerator > Second.numerator && First.denominator == Second.denominator || First.numerator == Second.numerator && First.denominator < Second.denominator || First.numerator > Second.numerator && First.denominator < Second.denominator;
        }
        public static bool operator <=(RationalNumbers First, RationalNumbers Second) // Переопределение <=
        {
            return First.numerator <= Second.numerator && First.denominator == Second.denominator || First.numerator == Second.numerator && First.denominator >= Second.denominator || First.numerator <= Second.numerator && First.denominator >= Second.denominator;
        }
        public static bool operator >=(RationalNumbers First, RationalNumbers Second) // Переопределение >=
        {
            return First.numerator >= Second.numerator && First.denominator == Second.denominator || First.numerator == Second.numerator && First.denominator <= Second.denominator || First.numerator >= Second.numerator && First.denominator <= Second.denominator;
        }
        public static RationalNumbers operator +(RationalNumbers First, RationalNumbers Second) // Переопределение +
        {
            if (First.denominator == Second.denominator)
            {
                First.numerator += Second.numerator;
                return First;
            }
            int save = First.denominator;
            First.numerator*=Second.denominator;
            First.denominator *= Second.denominator;
            Second.numerator *= save;            
            First.numerator += Second.numerator;
            return First;
        }
        public static RationalNumbers operator -(RationalNumbers First, RationalNumbers Second) // Переопределение -
        {
            if (First.denominator == Second.denominator)
            {
                First.numerator -= Second.numerator;
                return First;
            }
            int save = First.denominator;
            First.numerator *= Second.denominator;
            First.denominator *= Second.denominator;
            Second.numerator *= save;            
            First.numerator -= Second.numerator;          
            return First;
        }
        public static RationalNumbers operator ++(RationalNumbers First) // Переопределение ++
        {
            First.numerator += First.denominator;
            return First;
        }
        public static RationalNumbers operator --(RationalNumbers First) // Переопределение --
        {
            First.numerator -= First.denominator;
            return First;
        }
    }
}
