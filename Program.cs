namespace ConsoleApp2
{
    internal class Program
    {
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the library!");
        }
        static void PrintBookTitle(string title)
        {
            Console.Write("book title" + title);
            
        }
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        static void ApplyDiscount(double[]? price)
        {
            if(price == null || price.Length == 0) return;

            price[0] -= 5;

        }
        static void AddBonusPagesByref(ref int pages2)
        {
            pages2 += 50;
        }
        static void ReplaceArray(ref double[]? price)
        {
            if (price == null || price.Length == 0) return;

        }
        static bool TryGetPrice(string title , out double price)
        {
            if (title == "Clean code")
            {
                price = 25.5;
                return true;

            }
            else
            {
                price = 0;
                return false;
                
            }
        }
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"the title {title} ");
            Console.WriteLine($"the title {title} and the pages are {300} ");
        } 
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }
        

        static void Main(string[] args)
        {
            #region Q1
            double[] prices = { 25.5, 40.0, 33.75 };

            Console.WriteLine($"the price is {prices[1]}");
            #endregion

            #region Q2
            int[,] shelfCopies =
            {
                {3, 5},
                {1, 4}
            };
            Console.WriteLine($"shelf 1 is{1,0}");
            #endregion

            #region Q3
             PrintWelcomeMessage();

            #endregion
            #region Q4
            PrintBookTitle("Clean Code");

            #endregion
            #region Q5
            int pages = 400;
            Console.WriteLine($"the pages are {pages}");
            AddBonusPages(pages);
            Console.WriteLine($"After add pages{pages}");
            // the reson why we will see 400 is we are passing by value and we didnot expect to chang the out 
            #endregion

            #region Q6
            double[] price = { 25.5, 40.0 };
            Console.WriteLine($"frist price : {price[0]}");
            ApplyDiscount(price);
            Console.WriteLine($"the discount is : {price[0]}");
            // we are passing here by reference 
            // and ref is carrying address not value type 

            #endregion
            #region Q7

            int pages2 = 400;
            Console.WriteLine($"the pages are {pages2}");
            AddBonusPagesByref(ref pages2);
            Console.WriteLine($"After add pages{pages2}");
            // it will add 50 to pages the reson is we changed from value to became ref 
            #endregion
            #region Q8
            double[] price2 = new double[3]
            {10.0, 12.5, 15.0 };
            Console.WriteLine($"prices is : {price2.Length} ");

            #endregion
            // Q9
            Console.WriteLine($"{TryGetPrice}");

            // Q10
            Console.WriteLine($"{PrintBookInfo}");

            //Q11
            PrintBookInfo("clean code", 300);
            PrintBookInfo(pages: 300, title: "clean code");

            //Q12
            PrintAllTitles("Clean Code", "Welcome to the library!" , "Game programing patterns" , "C# players guide"); // here i didnt remeber any titles so i added titles for real books that i have in my room 
        }
    }
}
