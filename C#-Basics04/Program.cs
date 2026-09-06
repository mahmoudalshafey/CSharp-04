using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace C__Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintWelcomeMessage();  ---> Ques 3

            //PrintBookTitle("Clean Code"); ---> Ques 4

            //AddBounesPages(400); ---> Ques 5

            //---> Ques 6
            //double[]prices = { 25.5, 40.0};
            //ApplyDiscount(prices);
            //Console.WriteLine($"1st element after method: {prices[0]}");

            //---> Ques 7
            //int pages = 400;
            //AddBounesPages(ref pages);
            //Console.WriteLine($"pages after method {pages}");

            //--->Ques 8
            //double[] prices = { 20.0,30.0,40.0};
            //ReplaceArray(ref prices);
            //Console.WriteLine("replacing after method");
            //foreach (double num in prices)
            //{
            //    Console.Write($"{num} ");
            //}
            //Console.WriteLine();

            //---> Ques 9
            //double price;
            //TryGetPrice("Clean Code", out price);

            ////---> Ques 10
            //PrintBookInfo("Arabic");
            //PrintBookInfo("English", 500);

            //---> Ques 11
            //PrintBookInfo(title: "Arabic" , pages : 200);
            //PrintBookInfo(pages: 400, title : "English"); 
        }
        #region Ques 1

        ////double[] prices = {25.5,40.0,33.75 };
        //Console.WriteLine(prices[1]);

        #endregion

        #region Ques 2

        //int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
        //Console.WriteLine(shelfCopies[1, 0]);

        #endregion

        #region Ques 3
        //public static void PrintWelcomeMessage() {
        //    Console.WriteLine("Welcome to the Library!");
        //}

        #endregion

        #region Ques 4

        //public static void PrintBookTitle(string title) {
        //    Console.WriteLine("Book title :" + title);
        //}

        #endregion

        #region Ques 5
        //public static void AddBounesPages(int pages) {
        //    pages += 50;
        //    Console.WriteLine($"pages after bounes {pages}");
        //}
        //i expect to see the sum of pages after adding 50
        //because we add the bounes to the original pages
        #endregion

        #region Ques 6
        //public static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] -= 5.0;
        //    Console.WriteLine($"1st element inside method: {prices[0]}");
        //}

        //expected ?
        //      subtract 5 from 1st elemnt inside & after method.
        //why ?
        //      because passing by value - refrence type.

        #endregion

        #region Ques 7
        //public static void AddBounesPages(ref int pages)
        //{
        //    pages += 50;
        //    Console.WriteLine($"pages iside method {pages}");
        //}

        //different ?
        //        here we pass by ref - value type.
        //        
        #endregion

        #region Ques 8
        //public static void ReplaceArray(ref double[] prices) { 
        //    prices = new double [] { 10.0 , 12.5 , 15.0 };
        //    Console.WriteLine("replacing inside method");
        //    foreach(double num in prices){
        //        Console.Write($"{num} ");
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine(prices.Length);

        //}
        #endregion

        #region Ques 9
        //public static bool TryGetPrice(string title, out double price) { 
        //    if (title == "Clean Code")
        //    {
        //        price = 25.5;
        //        Console.WriteLine(price);
        //        return true;
        //    }
        //    price = 0.0;
        //    Console.WriteLine("not found");
        //    return false;
        //}
        #endregion

        #region Ques 10
        //public static void PrintBookInfo(string title, int pages = 300) {
        //    Console.WriteLine($"Title: {title}, Pages: {pages}");
        //}

        #endregion

        #region Ques 11
        //public static void PrintBookInfo(string title, int pages = 300)
        //{
        //    Console.WriteLine($"Title: {title}, Pages: {pages}");
        //}
        #endregion
    }
}
