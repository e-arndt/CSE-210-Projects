using System;


    public class Order
    {
        private List<Product> _products = new();
        private List<Customer> _customers = new();
        private double _inUSA = 5.00;
        private double _outUSA = 35.00;
        private double _shipCost;
        private double _totalPrice;
        private double _subTotal;

        public Order()
        {

        }

        public void GetShippinglabel()
        {
            foreach (Customer customer in _customers)
            {
                Address shipAddress = customer.GetAddress();
                Console.WriteLine("\nShipping label:");
                Console.WriteLine($"Ship To: {customer.GetCustomerName()}");
                Console.WriteLine($"{shipAddress.DisplayFullAddress()}");
                _shipCost = customer.IsUSACustomer() ? _inUSA : _outUSA;
            }
        }

        public double GetShippingCost()
        {
            return _shipCost;
        }

        public void GetPackingLabel()
        {
            Console.WriteLine("Packing label:");
            foreach (Product product in _products)
            {
                Console.WriteLine($"Item: {product.GetProdName()} Qty: {product.GetQuantity()} - Item ID: {product.GetProdID()}");
            }
            
        }

        public double CalcTotalCost()
        {
            foreach (Product product in _products)
            {
                _totalPrice += product.TotalPrice();
            }

            return _totalPrice + GetShippingCost();
        }

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public void AddProduct(Product item)
        {
            _products.Add(item);
        }

        public void DisplayShippingInfo()
        {
            GetPackingLabel();
            GetShippinglabel();
            Console.WriteLine("_________________________________");
            foreach (Product product in _products)
            {
                _subTotal += product.TotalPrice();
            }
            Console.WriteLine($"SubTotal   : ${_subTotal}");
            Console.WriteLine($"Shipping   : ${GetShippingCost()}.00");
            Console.WriteLine($"Order total: ${CalcTotalCost()}\n");
        }
    }