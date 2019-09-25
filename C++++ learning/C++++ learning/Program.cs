using System;   //консольный ввод-вывод

using System.Text;   //для stringbuilder
using System.IO;   //потоки
using System.Collections.Generic;

namespace C_____learning

{
    enum Type { Sber, Cur};
       class Bank : BankTransaction
    {
        static Queue <BankTransaction> arr = new Queue<BankTransaction>();
        int number;
        int balance;
        Type tip;
        static int i = 0;
        public Bank() //только номер
        {
            puls();
            number = i;
           
        }
        public Bank(int bal) // номер и баланс
        {
            puls();
            number = i;
            this.balance = bal;
           
        }
        public Bank(Type t) //номер и тип счета
        {
            puls();
            number = i;
            this.tip = t;
            
        }
        void puls()
        {
            i++;
        }  //метод для уникального номера
        public void set(int i, int j)
        {
            this.number = i;
            this.balance = j;
        }
        public  int getN()
        {
            return this.number;
        }
        public  int getB()
        {
            return this.balance;
        }
        public Type getT()
        {
            return this.tip; 
        }
        public void show()
        {
            Console.WriteLine("Номер: {0} Баланс: {1} Тип: {2}",getN(),getB(),getT());        
        }
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
            }
            else
                Console.WriteLine("Недостаточно стредств");
            }
        public void  showtransfers()
        {            
            foreach(BankTransaction k in arr)
            {                
                Console.WriteLine($"Дата {k.Getd()} : {k.Gets()} рублей.");
            }
        }

        public void Dispose()
        {
            string file_name = "Переводы.txt";
            var Writer = new StreamWriter(file_name);
            foreach (BankTransaction k in arr)
            {
                Writer.Write($"Дата {k.Getd()} : {k.Gets()} рублей.\n");
            }
            Console.WriteLine($"Выполнино! Запись сделана в файл \"{file_name}\"");
            Writer.Close();
           // GC.SuppressFinalize(this);
        }
    } //лаба 7 + 8.1  + 9

    
     class BankTransaction
    {
         readonly DateTime date;
         readonly int sum;
       protected  BankTransaction()
        { }
        public DateTime Getd()
        {
            return this.date;
        }

        public int Gets()
        {
            return this.sum;
        }
        public BankTransaction(int sum1)
        {            
           this.date = DateTime.Now;
            this.sum = sum1;
        }
        
    }
    
    class Program
    {
        static string reverse(string rev)
        {
            StringBuilder revbuilder = new StringBuilder(rev);
            for (int i = 0, k = rev.Length - 1; i <  rev.Length / 2; i++, k--)
            {
               char a = revbuilder[i];
                revbuilder[i] = revbuilder[k];
                revbuilder[k] = a;
            }
            return new string(revbuilder.ToString());
        }  //лаба 8.2    //string в C# только для чтения, для записи можно использовать StringBuilder или создать массив char[]     
        static Boolean checkformat(object i)
        {
            return i is IFormattable;
        }
        static void Main(string[] args)
        {
            {
                
                Bank bank = new Bank();
                Console.WriteLine("{0} аккаунт: ", bank.getN());
                bank.show();

                Bank bank1 = new Bank(Type.Cur);
                Console.WriteLine("{0} аккаунт: ", bank1.getN());
                bank1.show();

                
                byte switcher = 1;
                while (switcher != 0)
                {
                    try
                    {
                        Console.WriteLine($"\n{0} - Выход\n{1} - посмотреть счета\n{2} - снять деньги\n{3} - пополнить баланс\n{4} - Перевести средства на другой счет\n{5} - Показать перевод средств\n{6} - Сохранить историю переводов в файл");
                        switcher = Convert.ToByte(Console.ReadLine());

                        switch (switcher)
                        {
                            case 1:
                                bank.show();
                                bank1.show();
                                break;

                            case 2:
                                Console.WriteLine("Введите номер счет: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите снимаемое количество денег: ");
                                int money = Convert.ToInt32(Console.ReadLine());
                                if (num == bank.getN())
                                    bank.withdraw(money);
                                else
                                    if (num == bank1.getN())
                                    bank1.withdraw(money);
                                else
                                    Console.WriteLine("Нет такого счета");
                                break;

                            case 3:
                                Console.WriteLine("Введите номер счет: ");
                                int num1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите количество на зачисление: ");
                                int money1 = Convert.ToInt32(Console.ReadLine());
                                if (num1 == bank.getN())
                                    bank.replenish(money1);
                                else
                                    if (num1 == bank1.getN())
                                    bank1.replenish(money1);
                                else
                                    Console.WriteLine("Нет такого счета");
                                break;

                            case 4:
                                Console.WriteLine("Введите номер счет (для пополнения): ");
                                int num2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите номер счет (откуда будут списаны деньги): ");
                                int num3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите количество на перевод: ");
                                int money2 = Convert.ToInt32(Console.ReadLine());
                                if (num2 == bank.getN() && num3 == bank1.getN())
                                    bank.transfer(ref bank1, money2);
                                else
                                    if (num2 == bank1.getN() && num3 == bank.getN())
                                    bank1.transfer(ref bank, money2);
                                else
                                    Console.WriteLine("Нет такого счета");
                                break;
                            case 5:
                                bank.showtransfers();
                                break;
                            case 6:
                                bank.Dispose();
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Данные не введены!");
                    }
                }
            }    // лаба 7 + 8.1 + класс Bank  + 9.1                                                                                    
            {/*
                string str = Console.ReadLine();
                Console.WriteLine(reverse(str));
            */
            }   //лаба 8.2 + функция reverse
            { /*              
                Console.WriteLine("Введите название файла: (text.txt)");
                string file_name = Console.ReadLine();
                if (File.Exists(file_name))
                {
                    var Writer = new StreamWriter(file_name);
                    var Reader = new StreamReader("содержимое исходного файла.txt");                    
                    Writer.Write(Reader.ReadToEnd().ToUpper());
                    Console.WriteLine("Выполнино!");
                    Writer.Close();
                    Reader.Close();
                    Console.ReadKey();
                    Console.WriteLine("Удаление содержимого...");
                    File.WriteAllText(file_name, String.Empty);
                }
                else
                    Console.WriteLine("Файла не существует!");                
            */
            }        //Лаба 8.3
            {/*
                object i = new Bank();
                Console.WriteLine(checkformat(i));
            */ }   //лаба 8.4                               








            Console.ReadKey();
            //Console.WriteLine($"write {3} {23}.");
        }
    }
}
