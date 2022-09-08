using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Loan
{


    class Program
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("Program.cs");
        static void Main(string[] args)
        {
            double amountOfLoan;
            double timeOfLoan;
            int option;
            string typeOfLoan;

            Console.WriteLine("Loan Types : ");
            Console.WriteLine("1) Education Loan");
            Console.WriteLine("2) Car Loan");
            Console.WriteLine("3) Home Loan \n");

            Console.Write("Choose between option 1, 2 or 3 : ");
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
                if (option < 1 || option > 3)
                {
                    Console.WriteLine($"Option {option} Does Not Exist");
                    log.Error($"Invalid Option ({option}) was chosen");
                }
                else
                {
                    Console.Clear();

                    if (option == 1)
                    {
                        typeOfLoan = "Home Loan";
                    }
                    else if (option == 2)
                    {
                        typeOfLoan = "Car Loan";
                    }
                    else
                    {
                        typeOfLoan = "Education Loan";
                    }

                    Console.WriteLine($"Calculating Loan Payment and Interest for {typeOfLoan}\n\n");

                    try
                    {
                        Console.Write("Enter the Time of Repayment (In Years) : ");
                        timeOfLoan = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter the Principal Amount (In Rupees) : ");
                        amountOfLoan = Convert.ToDouble(Console.ReadLine());

                        double interest;
                        double total;

                        switch(option)
                        {
                            case 1:
                                HomeLoan Loan1 = new HomeLoan(amountOfLoan, timeOfLoan);
                                total = Loan1.LoanValue();
                                interest = Loan1.InterestValue();
                                break;
                            case 2:
                                CarLoan Loan2 = new CarLoan(amountOfLoan, timeOfLoan);
                                total = Loan2.LoanValue();
                                interest = Loan2.InterestValue();
                                break;
                            case 3:
                                EducationLoan Loan3 = new EducationLoan(amountOfLoan, timeOfLoan);
                                total = Loan3.LoanValue();
                                interest = Loan3.InterestValue();
                                break;
                            default:
                                interest = 0;
                                total = 0; 
                                break;
                        }

                        log.Info($"{typeOfLoan} is equal to {total} with a total interest of {interest}");
                        Console.WriteLine($"The total payable amount is {total} with a total interest of {interest}");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nInvalid Principle Ammount or Time");
                        log.Error($"Invalid Principle Ammount or Time was entered");
                    }
                }

            }
            catch (Exception)
            {
                log.Error(" Option Value was Invalid");
                Console.WriteLine("\nOption Not Permitted");
            }

            Console.ReadLine();
        }
    }

}