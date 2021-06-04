using System;

namespace Library
{
    class Book
    {
        public const int BOOK_MAX_QUANTITY = 100;
        public const int BOOK_MAX_PRICE = 1000;

        private string title;
        private string author;
        private string publication;
        private string purchase_date;
        private int price;
        private int quantity;
        private int available_quantity;

        public string Title {
            get { return title; }
            set {; }
        }
        public string Author {
            get { return author; }
            set {; }
        }
        public string Publication {
            get { return publication; }
            set {; } 
        }
        public string Purchase_Date {
            get {return purchase_date; }
            set {; } 
        }
        public int Price {
            get {return price; }
            set {; } 
        }
        public int Quantity {
            get {return quantity; }
            set {; } 
        }
        public int Available_Quantity {
            get {return available_quantity; }
            set {; } 
        }

        // Implicit constructor
        public Book()
        {
            title = "Unknown";
            author = "Unknown";
            publication = "Unknown";
            purchase_date = Convert.ToString(DateTime.Now);
            price = 1;
            quantity = 1;
            available_quantity = 0;
        }

        // Constructor
        public Book(string _title, 
            string _author,
            string _publication,
            string _purchase_date,
            int _price,
            int _quantity,
            int _available_quantity = 0
            )
        {
            title = _title;
            author = _author;
            publication = _publication;
            purchase_date = _purchase_date;
            price = _price;
            quantity = _quantity;
            available_quantity = Quantity;
        }
        public string Convert_to_string()
        {
            return $"\n Book: {Title},\nAuthor: {Author},\nPublication: {Publication}," +
                $"\nPurchase date: {Purchase_Date},\nPrice: {Price},\nQuantity: {Quantity}" +
                $"Available quantity: {Available_Quantity}";
        }
    }
}
