using System;
using System.Runtime.CompilerServices;

namespace AutoPotter
{
    internal class Program
    {
        private static string _accessToken = "";
        private static string _accountId = "";
        static void Main(string[] args)
        {
            //Load Settings.
            //Grab current balance from main account.
            //If current balance is less than the bottom limit setting then exit.
            //Else load the list of SavingSetting objects from the json file.
            //Foreach SavingSetting
                //Load the pot data from the monzo api.
                //Calculate the if the amount is correct based on this (CurrentDay - 1) * (CurrentDay - 1 + IncrementBy) / 2 storing in a variable.
                //Calculate the amount needed for the current day based on this CurrentDay * CurrentDay + IncrementBy / 2 storing in a variable.\
                //Subtract the First amount from the second amount, make sure it's not a minus.
                //Make sure we can send the actual amount.
                //Send the amount.
            Console.WriteLine("Hello World!");
        }
    }

    public class SavingSetting
    {
        public long TargetAmount { get; set; }
        public string PotId { get; set; }
        public DateTime StartOn { get; set; }
        public DateTime LastUpdated { get; set; }
        public int IncrementBy { get; set; }
    }
}
