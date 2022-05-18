using System;
using System.IO;
using Microsoft.VisualBasic;

namespace Lab4
{
    class Program
    {
            public  void Menu()
        {
            string path = "/Users/timofejvoznesenskij/RiderProjects/Lab4/Lab4/company.txt";
            
            char command;
            char key;
            do
            {
                Console.WriteLine("Menu of command");
                Console.WriteLine("1. Inheritance");
                Console.WriteLine("2. Interface");
                Console.WriteLine("3. Abstraction");
                Console.WriteLine();
                Console.WriteLine("select of command, press number of key");
                command = (char) Console.Read();
                Console.ReadLine();
                Console.WriteLine(new String('-', 25));
                switch (command)
                {
                    case '1':
                        Inheritance();
                        break;
                    case '2':
                        Interface();
                        break;
                    case '3':
                        Abstraction();
                        break;
                    default:
                        Console.WriteLine("wrong command");
                        break;
                }

                Console.WriteLine("Continue y/n");
                key = (char) Console.Read();
                Console.ReadLine();
            } while (key != 'n');
        }
            public static void Petroleum()
            {
                string path = "/Users/timofejvoznesenskij/RiderProjects/Lab4/Lab4/company.txt";
                StreamWriter writer = new StreamWriter(path, true);
                
                PetroleumCompany oil = new PetroleumCompany("Gasoline", 300000, 0, 10000);
                int percent, salary;
                Console.Write("Percent of profit per month: ");
                percent=Int32.Parse(Console.ReadLine());
                Console.Write("Middle salary: ");
                salary = Int32.Parse(Console.ReadLine());
                
                oil.CountProfit(percent,oil.GeneralMoney);
                oil.CountEmployee(salary,oil.GeneralMoney);
                
                writer.WriteLine("INHERITANCE");
                writer.WriteLine("Name: {0}", oil.Name);
                writer.WriteLine("Location: {0}", oil.Location);
                writer.WriteLine("Activity: {0}", oil.Activity);
                writer.WriteLine("Product: {0}", oil.Product);
                writer.WriteLine("Profit: {0}$", oil.Profit);
                writer.WriteLine("Worker: {0}", oil.NumberWorker);
                writer.WriteLine(new String('-', 25));
                writer.Close();

            }

            public static void Zavod()
            {
                string path = "/Users/timofejvoznesenskij/RiderProjects/Lab4/Lab4/company.txt";
                StreamWriter writer = new StreamWriter(path, true);
                
                PetroleumCompany zavod = new PetroleumCompany("Metallurgy", 780000, 0, 0);
                int percent, salary;
                Console.Write("Percent of profit per month: ");
                percent=Int32.Parse(Console.ReadLine());
                Console.Write("Middle salary: ");
                salary = Int32.Parse(Console.ReadLine());
                
                zavod.CountProfit(percent,zavod.GeneralMoney);
                zavod.CountEmployee(salary,zavod.GeneralMoney);
                
                writer.WriteLine("INHERITANCE");
                writer.WriteLine("Name: {0}", zavod.Name);
                writer.WriteLine("Location: {0}", zavod.Location);
                writer.WriteLine("Activity: {0}", zavod.Activity);
                writer.WriteLine("Product: {0}", zavod.Product);
                writer.WriteLine("Profit: {0}$", zavod.Profit);
                writer.WriteLine("Worker: {0}", zavod.NumberWorker);
                writer.WriteLine(new String('-', 25));
                writer.Close();

            }

            public  void Inheritance()
            {
                char command;
                char key;
                do
                {
                    Console.WriteLine("Menu of Inheritance");
                    Console.WriteLine("1. Petroleum");
                    Console.WriteLine("2. Zavod");
                    Console.WriteLine("3. Exit");
                    
                    Console.WriteLine();
                    Console.WriteLine("select of command, press number of key");
                    command = (char) Console.Read();
                    Console.ReadLine();
                    Console.WriteLine(new String('-', 25));
                    switch (command)
                    {
                        case '1':
                            Petroleum();
                            break;
                        case '2':
                            Zavod();
                            break;
                        case '3':
                            Menu();
                            break;
                        default:
                            Console.WriteLine("wrong command");
                            break;
                    }

                    Console.WriteLine("Continue y/n");
                    key = (char) Console.Read();
                    Console.ReadLine();
                } while (key != 'n');
            }

            public static void InterfacePetroleum()
            {
                string path = "/Users/timofejvoznesenskij/RiderProjects/Lab4/Lab4/company.txt";
                StreamWriter writer = new StreamWriter(path, true);
                
                Interface gas = new InterPetroleum("Gasoline", 300000, 0, 10000);
                int percent, salary;
                Console.Write("Percent of profit per month: ");
                percent=Int32.Parse(Console.ReadLine());
                Console.Write("Middle salary: ");
                salary = Int32.Parse(Console.ReadLine());
                
                gas.CountProfit(percent,gas.GeneralMoney);
                gas.CountEmployee(salary, gas.GeneralMoney);

                writer.WriteLine("INTERFACE");
                writer.WriteLine("Name: {0}", gas.Name);
                writer.WriteLine("Location: {0}", gas.Location);
                writer.WriteLine("Activity: {0}", gas.Activity);
                writer.WriteLine("Product: {0}", gas.Product);
                writer.WriteLine("Profit: {0}$", gas.Profit);
                writer.WriteLine("Worker: {0}", gas.NumberWorker);
                writer.WriteLine(new String('-', 25));
                writer.Close();
            }

            public static void InterfaceZavod()
            {
                string path = "/Users/timofejvoznesenskij/RiderProjects/Lab4/Lab4/company.txt";
                StreamWriter writer = new StreamWriter(path, true);
                
                Interface zavod = new InterPetroleum("Milk products", 560000, 0, 0);
                int percent, salary;
                Console.Write("Percent of profit per month: ");
                percent=Int32.Parse(Console.ReadLine());
                Console.Write("Middle salary: ");
                salary = Int32.Parse(Console.ReadLine());
                
                zavod.CountProfit(percent,zavod.GeneralMoney);
                zavod.CountEmployee(salary,zavod.GeneralMoney);

                writer.WriteLine("INTERFACE");
                writer.WriteLine("Name: {0}", zavod.Name);
                writer.WriteLine("Location: {0}", zavod.Location);
                writer.WriteLine("Activity: {0}", zavod.Activity);
                writer.WriteLine("Product: {0}", zavod.Product);
                writer.WriteLine("Profit: {0}$", zavod.Profit);
                writer.WriteLine("Worker: {0}", zavod.NumberWorker);
                writer.WriteLine(new String('-', 25));
                writer.Close();
            }

            public  void Interface()
            {
                char command;
                char key;
                do
                {
                    Console.WriteLine("Menu of Interface");
                    Console.WriteLine("1. Petroleum");
                    Console.WriteLine("2. Zavod");
                    Console.WriteLine("3. Exit");
                   
                    Console.WriteLine();
                    Console.WriteLine("select of command, press number of key");
                    command = (char) Console.Read();
                    Console.ReadLine();
                    Console.WriteLine(new String('-', 25));
                    switch (command)
                    {
                        case '1':
                            InterfacePetroleum();
                            break;
                        case '2':
                            InterfaceZavod();
                            break;
                        case '3':
                            Menu();
                            break;
                        default:
                            Console.WriteLine("wrong command");
                            break;
                    }

                    Console.WriteLine("Continue y/n");
                    key = (char) Console.Read();
                    Console.ReadLine();
                } while (key != 'n');
            }

            public static void AbsZavod()
            {
                string path = "/Users/timofejvoznesenskij/RiderProjects/Lab4/Lab4/company.txt";
                StreamWriter writer = new StreamWriter(path, true);
                
                AbsZavod zavod = new AbsZavod("Production", 234560000, 0, 0);
                int percent, salary;
                Console.Write("Percent of profit per month: ");
                percent=Int32.Parse(Console.ReadLine());
                Console.Write("Middle salary: ");
                salary = Int32.Parse(Console.ReadLine());
                
                zavod.CountProfit(percent,zavod.GeneralMoney);
                zavod.CountEmployee(salary,zavod.GeneralMoney);

                writer.WriteLine("ABSTRACTION");
                writer.WriteLine("Name: {0}", zavod.Name);
                writer.WriteLine("Location: {0}", zavod.Location);
                writer.WriteLine("Activity: {0}", zavod.Activity);
                writer.WriteLine("Product: {0}", zavod.Product);
                writer.WriteLine("Profit: {0}$", zavod.Profit);
                writer.WriteLine("Worker: {0}", zavod.NumberWorker);
                writer.WriteLine(new String('-', 25));
                writer.Close();
            }

            public static void AbsPetroleum()
            {
                string path = "/Users/timofejvoznesenskij/RiderProjects/Lab4/Lab4/company.txt";
                StreamWriter writer = new StreamWriter(path, true);
                
                AbsPetroleum oil = new AbsPetroleum("Gasoline", 3450000, 0, 10000);
                int percent, salary;
                Console.Write("Percent of profit per month: ");
                percent=Int32.Parse(Console.ReadLine());
                Console.Write("Middle salary: ");
                salary = Int32.Parse(Console.ReadLine());
                
                oil.CountProfit(percent,oil.GeneralMoney);
                oil.CountEmployee(salary,oil.GeneralMoney);

                writer.WriteLine("ABSTRACTION");
                writer.WriteLine("Name: {0}", oil.Name);
                writer.WriteLine("Location: {0}", oil.Location);
                writer.WriteLine("Activity: {0}", oil.Activity);
                writer.WriteLine("Product: {0}", oil.Product);
                writer.WriteLine("Profit: {0}$", oil.Profit);
                writer.WriteLine("Worker: {0}", oil.NumberWorker);
                writer.WriteLine(new String('-', 25));
                writer.Close();
            }

            public  void Abstraction()
            {
                char command;
                char key;
                do
                {
                    Console.WriteLine("Menu of Abstraction");
                    Console.WriteLine("1. Petroleum");
                    Console.WriteLine("2. Zavod");
                    Console.WriteLine("3. Exit");
                    
                    Console.WriteLine();
                    Console.WriteLine("select of command, press number of key");
                    command = (char) Console.Read();
                    Console.ReadLine();
                    Console.WriteLine(new String('-', 25));
                    switch (command)
                    {
                        case '1':
                            AbsPetroleum();
                            break;
                        case '2':
                            AbsZavod();
                            break;
                        case '3':
                            Menu();
                            break;
                        default:
                            Console.WriteLine("wrong command");
                            break;
                    }

                    Console.WriteLine("Continue y/n");
                    key = (char) Console.Read();
                    Console.ReadLine();
                } while (key != 'n');
            }
            
    }
}