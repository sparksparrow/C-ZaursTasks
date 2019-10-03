using System;
using System.Collections.Generic;
using System.IO;   //потокu
using System.Diagnostics;

namespace C_____learning
{
    enum Tip { Sber, Cur };  
    class Bank : Attribute
    {
        static Queue<BankTransaction> arr = new Queue<BankTransaction>();
        int number;
        int balance;
        Tip tip;
        string name;
        static int i = 0;
        internal Bank() //только номер
        {
            puls();
            number = i;
        }
        internal Bank(int bal) // номер и баланс
        {
            puls();
            number = i;
            this.balance = bal;
        }
        internal Bank(Tip t) //номер и тип счета
        {
            puls();
            number = i;
            this.tip = t;
        }
        internal Bank(int bal, Tip t) //номер и тип счета
        {
            puls();
            number = i;
            this.balance = bal;
            this.tip = t;
        }
        void puls()
        {
            i++;
        }  //метод для уникального номера
        public void setN(int i)
        {
            this.number = i;

        }// сеттер номера
        public void setB(int j)
        {
            this.balance = j;
        }//сеттер баланса
        public void setT(Tip tip)
        {
            this.tip = tip;
        }  //сеттер типа             

        public int getB()
        {
            return this.balance;
        } //геттер баланса

        public int Nubmer => number; // свойства номера (только для чтения)

        public Tip Tip
        {
            get
            {
                return this.tip;
            }
        }// свойства типа (только для чтения)
        public string Name { get { return name; } set { name = value; } }
        public void withdraw(int dig)
        {
            if (dig <= this.balance)
            {
                this.balance -= dig;
                BankTransaction i = new BankTransaction(-dig);
                arr.Enqueue(i);
            }
            else
                Console.WriteLine("Средств не хватает!");
        } //снять деньги
        public void replenish(int dig)
        {
            this.balance += dig;
            BankTransaction i = new BankTransaction(dig);
            arr.Enqueue(i);
        } //пополнить баланс
        public void transfer(ref Bank i, int dig)//перевод денег (i - с какого счета снимаем) ( dig - количество денег)
        {

            if (i.balance >= dig)
            {
                i.balance -= dig;
                this.balance += dig;
                BankTransaction k = new BankTransaction(dig);
                arr.Enqueue(k);
            }
            else
                Console.WriteLine("Недостаточно стредств");
        }
        public void showtransfers()
        {
            if (arr.Count == 0)
                Console.WriteLine("Никаких транзакций не было совершено!");
            else
                foreach (BankTransaction k in arr)
                {
                    Console.WriteLine($"Дата {k.Datetime} : {k.Sum} рублей.");
                }//Показать перевод
        }

        public void Dispose()
        {
            string file_name = "Переводы.txt";
            var Writer = new StreamWriter(file_name);
            foreach (BankTransaction k in arr)
            {
                Writer.Write($"Дата {k.Datetime} : {k.Sum} рублей.\n");
            }
            Console.WriteLine($"Выполнино! Запись сделана в файл \"{file_name}\"");
            Writer.Close();
            GC.SuppressFinalize(this);
        }// запись в файл
        public static bool operator ==(Bank First, Bank Second) // Переопределение ==   (== по умолчанию возвращает true если обе ссылки указывают на один объект )
        {
            return First.balance == Second.balance;
        }
        public static bool operator !=(Bank First, Bank Second) // Переопределение !=
        {
            return First.balance != Second.balance;
        }
        public override bool Equals(object obj)
        {
            try
            {
                if (obj == null)
                    return false;
                Bank bank = obj as Bank; // возвращает null если объект нельзя привести к типу Bank          
                return bank.balance == this.balance && bank.tip == this.tip;
            }
            catch (System.NullReferenceException)
            {
                return false;
            }
        }//переопределение Equals, значение number всегда индивидуальное, не используется в сравнении 
        public override int GetHashCode()
        {
            int Code;
            if (tip == Tip.Sber)
                Code = 1;
            else Code = 2;
            return number + balance + Code;
        } //возвращает код (номер+баланс + тип счета)
        public override string ToString()
        {
            return "Номер: " + number + "\nИмя: " + name + "\nБаланс: " + balance + "\nТип: " + tip + "\n";
        }//Возвращает информацию о счете
        public BankTransaction this[int index]
        {
            get
            {
                try
                {
                    return arr.ToArray()[index];
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    return null;
                }
            }
        }
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine("DEBUG_ACCOUNT is defined ");
        }
    } //лаба 7 + 8.1  + 9 +13
     
}
