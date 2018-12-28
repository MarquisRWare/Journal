using System;
using JournalApp;

namespace Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            JournalObject journal = new JournalObject();
            Console.WriteLine(journal.journalMessage);
            int response;
            string rep;
            do
            {
                Console.WriteLine("1) Unlock");
                Console.WriteLine("2) Create Entry");
                Console.WriteLine("3) Read Entry");
                Console.WriteLine("4) Lock");
                Console.WriteLine("5) Quit");
                Console.WriteLine("-----------------------\n");
                response = int.Parse(Console.ReadLine());

                switch (response)
                {
                    case 1:
                        {
                            Console.WriteLine("Please Enter password:");
                            rep = Console.ReadLine();
                            bool cracked = journal.UnlockJournal(rep);
                            if (cracked)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;

                                Console.WriteLine("Journal Unlocked");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("Incorrect Password");

                            }
                            break;
                        }
                    case 2:
                        {


                            if(journal.Entry == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("Unlock journal first");
                                break;
                            }
                            //Console.WriteLine("okaaaay!!!!");
                            Console.WriteLine("Enter journal text");
                            string journalMessage = Console.ReadLine();

                            journal.Entry.Text = journalMessage;

                            break;

                        }
                    case 3:
                        {
                            if (journal.Entry == null)
                            {
                                Console.WriteLine("Unlock journal first");

                            }
                            else
                            {
                           // Console.WriteLine("We are here");
                               //string thing = journal.Entry.Text;

                                Console.WriteLine(journal.Entry.Text);
                                Console.WriteLine("Last Edit:" + journal.Entry.LastEditTime
                                .ToShortDateString() + " " + journal.
                                    Entry.LastEditTime.ToLongTimeString());
                            }
                            break;
                        }
                    case 4:
                        {
                            journal.LockJournal();
                            Console.WriteLine("Journal Locked");
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                  


                }
                //Console.ResetColor();
            } while (response != 5);
        }
    }
}
