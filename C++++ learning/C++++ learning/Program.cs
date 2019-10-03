#define DEBUG_ACCOUNT
using System;   //консольный ввод-вывод
using System.Text;   //для stringbuilder
using System.IO;   //потоки
//using System.Collections.Generic; //для массива классов Queue
//using System.Collections; // для хеш-таблицы

namespace C_____learning
{
    
    class Program
    {
        static string reverse(string rev)
        {
            StringBuilder revbuilder = new StringBuilder(rev);
            for (int i = 0, k = rev.Length - 1; i < rev.Length / 2; i++, k--)
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

        delegate string deel(string s);
        static void Main(string[] args)
        {
            {/*
                Func<string, string> delreverse;  //У Action второе значение передается как второй аргумент функции
                delreverse = reverse;
                delreverse += reverse;//вернет значение последнего делегата (ничего не изменилось)
                string str = Console.ReadLine();
                Console.WriteLine(delreverse(str));
                deel check = reverse;
                Console.WriteLine(check.Invoke("Привет"));
            */}//Делегаты
            {  /*   
                Bank bank = new Bank();
                bank.Name = "Никита";
                Console.WriteLine("{0} аккаунт: ", bank.Nubmer);
                Console.WriteLine(bank.ToString());

                Bank bank1 = new Bank(Tip.Cur);
                bank1.Name = "Андрей";
                Console.WriteLine("{0} аккаунт: ", bank1.Nubmer);
                Console.WriteLine(bank1.ToString());               

                byte switcher = 1;
                while (switcher != 0)
                {
                    try
                    {                        
                        Console.WriteLine($"\n{0} - Выход\n{1} - Посмотреть счета\n{2} - Снять деньги\n{3} - Пополнить баланс\n{4} - Перевести средства на другой счет\n{5} - Показать перевод средств\n{6} - Сохранить историю переводов в файл\n{7} - Найти транзакцию по ее номеру\n{8} - Определен ли DEBUG_ACCOUNT");
                        switcher = Convert.ToByte(Console.ReadLine());

                        switch (switcher)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine(bank.ToString());
                                Console.WriteLine(bank1.ToString());
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("Введите номер счет: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите снимаемое количество денег: ");
                                int money = Convert.ToInt32(Console.ReadLine());
                                if (num == bank.Nubmer)
                                    bank.withdraw(money);
                                else
                                    if (num == bank1.Nubmer)
                                    bank1.withdraw(money);
                                else
                                    Console.WriteLine("Нет такого счета");
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("Введите номер счет: ");
                                int num1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите количество на зачисление: ");
                                int money1 = Convert.ToInt32(Console.ReadLine());
                                if (num1 == bank.Nubmer)
                                    bank.replenish(money1);
                                else
                                    if (num1 == bank1.Nubmer)
                                    bank1.replenish(money1);
                                else
                                    Console.WriteLine("Нет такого счета");
                                break;

                            case 4:
                                Console.Clear();
                                Console.WriteLine("Введите номер счет (для пополнения): ");
                                int num2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите номер счет (откуда будут списаны деньги): ");
                                int num3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите количество на перевод: ");
                                int money2 = Convert.ToInt32(Console.ReadLine());
                                if (num2 == bank.Nubmer && num3 == bank1.Nubmer)
                                    bank.transfer(ref bank1, money2);
                                else
                                    if (num2 == bank1.Nubmer && num3 == bank.Nubmer)
                                     bank1.transfer(ref bank, money2);
                                else
                                    Console.WriteLine("Нет такого счета");
                                break;

                            case 5:
                                Console.Clear();
                                bank.showtransfers();
                                break;

                            case 6:
                                Console.Clear();
                                bank.Dispose();
                                break;
                            case 7:
                                Console.Clear();
                                Console.WriteLine("Введите номер транзакции: ");
                                int digit = Convert.ToInt32(Console.ReadLine()) - 1;
                                if(bank[digit]==null)
                                    Console.WriteLine("Нет такой транзакции.");
                                else
                                    Console.WriteLine($"Дата {bank[digit].Datetime} : {bank[digit].Sum} рублей.");
                                break;
                            case 8:
                                Console.Clear();
                                bank.DumpToScreen();
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Данные не введены!");
                    }
                }                
            
            */
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
            */
            }   //лаба 8.4                               
            {/*
                ACipher acode = new ACipher();

                string first = Console.ReadLine();
                string enc = acode.encode(first);
                Console.WriteLine(enc);
                Console.WriteLine(acode.decode(enc));
            */
            } //Acipher
            {/*
                BCypher bcode = new BCypher();

                string first = Console.ReadLine();
                string enc = bcode.encode(first);
                Console.WriteLine(enc);
                Console.WriteLine(bcode.decode(enc));
                */
            } //Bcipher //лаба 10.1
            { /*
            Factory factory = new Factory();
            byte switcher= 1;                
                    while (switcher != 0)
                {
                    try
                    {                        
                        Console.WriteLine($"\n{0} - Выход\n{1} - Создать аккаунт\n{2} - Удалить аккаунт\n{3} - Посмотреть аккаунты\n");
                       
                        switcher = Convert.ToByte(Console.ReadLine());
                        switch (switcher)
                        {
                            case 1:
                                System.Console.Clear();
                                Console.WriteLine("Аккаунт {0} создан.", factory.CreateAccount());                                
                                break;
                            case 2:
                                System.Console.Clear();
                                Console.WriteLine("Введите номер счета для удаления: ");
                               int num = Convert.ToInt32(Console.ReadLine());
                                factory.Remove(num);
                                break;
                            case 3:
                                System.Console.Clear();
                                factory.Print();
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Данные не введены!");
                    }
            }
            */
            }//лаба 11.1
            {/*
                BankTransaction ba = new BankTransaction(1);
                Bank bank = new Bank();
                Bank bank1 = new Bank();
                Console.WriteLine(bank.GetHashCode());
                Console.WriteLine(bank.ToString());
                Console.WriteLine(bank1==bank);
                Console.WriteLine(bank1!=bank);
                Console.WriteLine(bank.Equals(bank1));
                Console.WriteLine(bank.Equals(ba));
            */
            }//лаба 12.1
            {/*
                RationalNumbers r = new RationalNumbers(1,2);
                RationalNumbers r1 = new RationalNumbers(1, 3);                
                Console.WriteLine(r.ToString());
                Console.WriteLine(r1.ToString());
                Console.WriteLine(r.Equals(r1));
                Console.WriteLine(r==r1);
                Console.WriteLine(r!=r1);
                Console.WriteLine(r>r1);
                Console.WriteLine(r < r1);
                Console.WriteLine(r >= r1);
                Console.WriteLine(r <= r1);
                Console.WriteLine(r + r1);
                Console.WriteLine(r - r1);
                Console.WriteLine(r++);
                Console.WriteLine(r--);
            */
            }//лаба 12.2 
            {/*
                Type t = typeof(RationalNumbers);
                object[] arrayAtt = t.GetCustomAttributes(false);
                foreach (AttributeInfoAttribute attrbt in arrayAtt)
                {
                    Console.WriteLine($"Имя создателя: {attrbt.name}.\nДата: {attrbt.date_creation}.");
                }
            */
            }//лаба 14.2           
            Console.ReadKey();            
        }
    }
}











//class A
//{

//}
//p class B
//{
//    private A _a;
//    public B(A a) Объект А живет где-то отдельно
//    {
//        _a = a;
//    }
//}

//class B
//{
//    private A _a = new A();// Объект А существует только вместе с B
//}

//string str = "asd";
//char[] a = str.ToCharArray();


//class Account<T>    T - универсальный параметр
//{
//    public T Id { get; set; }
//    public int Sum { get; set; }
//}

//Account<int> account1 = new Account<int> { Sum = 5000 };
//Account<string> account2 = new Account<string> { Sum = 4000 };
//account1.Id = 2;        // упаковка не нужна
//account2.Id = "4356";
//int id1 = account1.Id;  // распаковка не нужна
//string id2 = account2.Id;