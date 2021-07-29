using System;

namespace BANKASSGNT
{
    //public class bank
    //{
    //    //public double accno { get; set; }
        //public double balance { get; set; }
        //public string password { get; set; }
       

        //public bank()
        //{
        //    Console.WriteLine("Enter AccountNumber, AccountBalance,Password,BankName");
        //    accno = Convert.ToDouble(Console.ReadLine());
        //    balance = Convert.ToDouble(Console.ReadLine());
        //    password = Console.ReadLine();

        //}
    //}
   //abstract class account : bank
   // {
   //     public double minimumbalance { get; set; }
   //     public double overdraftlimitaccount { get; set; }
   //     public int amount { get; set; }
   //     public abstract void displayaccount();
   //     public abstract void withdraw(int amount);
   // }
   // class Savingsaccount:account
   // {
   //     public Savingsaccount()
   //     {

   //     }
   //     public override void withdraw(int amnt)
   //     {
   //         amount = amnt;
   //     }
   //     public override void displayaccount()
   //     {
   //         Console.WriteLine("Account Number:{0}", accno);
   //         Console.WriteLine("Account balance:{0}",balance);
   //         Console.WriteLine("Password:{0}",password);
   //         Console.WriteLine("Bank Name:{0}",bankname);
   //         Console.WriteLine("Minimum Balance:{0}", minimumbalance);
   //         Console.WriteLine("Withdraw Amount:{0}", amount);

   //     }
       

   // }
   // class Currentaccount:account
   // {
   //     public Currentaccount()
   //     {

   //     }
   //     public override void withdraw(int amnt)
   //     {
   //         amount = amnt;
   //     }

   //     public override void displayaccount()
   //     {
   //         Console.WriteLine("Account Number:{0}",accno);
   //         Console.WriteLine("Account balance:{0}",balance);
   //         Console.WriteLine("Password:{0}",password);
   //         Console.WriteLine("Bank Name:{0}",bankname);
   //         Console.WriteLine("Over drafft Limit Amount:{0}", overdraftlimitaccount);
   //         Console.WriteLine("Withdraw Amount:{0}", amount);
   //     }
   // }
   // interface IATM
   // {
   //     public void withdraw(int accountNumber, double amount);
   //     public void changePassword(int accountNumber, String oldpassword, String newpassword);
   //     public void checkBalance();
   // }
   // class SbiAtm : IATM
   // {
   //     public void withdraw(int accountNumber,double amount)
   //     {

   //     }
   //     public void changePassword(int accountNumber,String oldpassword,String newpassword)
   //     {

   //     }
   //     public void checkBalance()
   //     {

   //     }
   // }
   // class ICICATM : IATM
   // {
   //     public void withdraw(int accountNumber, double amount)
   //     {

   //     }
   //     public void changePassword(int accountNumber, String oldpassword, String newpassword)
   //     {

   //     }
   //     public void checkBalance()
   //     {

   //     }
   // }
   public class bank
   {

        public int prod(int a,int b)
        {
            return a * b;
        }
        public int getvalue(int c,int d)
        {
            return c * d;
        }

   }
    class mainclass
    {
        public static void main(string[] args)
        {
            bank b = new bank();

        }
    }
}
