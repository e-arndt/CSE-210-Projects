using System;



    // Define the Product class
    public class Product
    {
        private string _prodName;
        private string _prodID;
        private double _prodPrice;
        private int _prodQty;
        


        public Product()
        {
            
        }

        public void SetProductName(string name)
        {
            _prodName = new(name);
        }

        public string GetProdName()
        {
            return _prodName;
        }

        public void SetProdID()
        {
            string idNum = "";
            Random random = new();
            for (int i = 0; i < 6; i++)
            {
                idNum += random.Next(9);
            }
            _prodID = $"#{idNum}";
        }

        public string GetProdID()
        {
            SetProdID();
            return _prodID;
        }

        public void SetProductPrice(double price)
        {
            _prodPrice = price;
        }

        public double GetPrice()
        {
            return (_prodPrice);
        }

        public void SetQuantity(int qty)
        {
            _prodQty = qty;
        }

        public int GetQuantity()
        {
            return _prodQty;
        }

        public double TotalPrice()
        {
            return (_prodPrice * _prodQty);
        }
    }