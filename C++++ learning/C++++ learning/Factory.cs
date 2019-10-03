using System;
using System.Collections;

namespace C_____learning
{
    class Factory
    {
        static Hashtable ht = new Hashtable();
        public int CreateAccount()
        {
            Bank bank = new Bank();
            ht.Add(bank.Nubmer, bank);
            return bank.Nubmer;
        }
        public int CreateAccount(int balance)// баланс
        {
            Bank bank = new Bank(balance);
            ht.Add(bank.Nubmer, bank);
            return bank.Nubmer;
        }
        public int CreateAccount(Tip t)// тип счета
        {
            Bank bank = new Bank(t);
            ht.Add(bank.Nubmer, bank);
            return bank.Nubmer;
        }
        public int CreateAccount(int bal, Tip t) //баланс и тип счета
        {
            Bank bank = new Bank(bal, t);
            ht.Add(bank.Nubmer, bank);
            return bank.Nubmer;

        }
        public void Remove(int num)
        {
            bool b = false;
            foreach (DictionaryEntry cell in ht)
            {
                if (cell.Key.Equals(num))
                {
                    b = true;
                    ht.Remove(num);
                    break;
                }
            }
            if (b)
                Console.WriteLine($"Аккаунт {num} удалён.");
            else
                Console.WriteLine("Элемент не найден.");
        }
        public void Print()
        {
            foreach (DictionaryEntry hash in ht)
            {
                Console.WriteLine("Номер аккаунта = {0}", hash.Key);
            }
        }
    }
}
