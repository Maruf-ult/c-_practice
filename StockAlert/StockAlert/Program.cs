namespace StockAlert
{
    class StockLowEventArgs : EventArgs
    {
        public string ProductName { get; }
        public int CurrentStock { get; }

        public StockLowEventArgs(string productName,int currentStock)
        {
            ProductName = productName;
            CurrentStock = currentStock;
        }
    }

    class InventoryService
    {
        public event EventHandler<StockLowEventArgs> StockLow;

        public void UpdateStock(string productName, int currentStock)
        {
            Console.WriteLine($"{productName} stock updated to {currentStock}");

            if (currentStock < 10)
            {
                StockLow?.Invoke(this, new StockLowEventArgs(productName, currentStock));
            }
        }
    }
    internal class Program
    {
        static void NotifyAdmin(object sender,StockLowEventArgs e)
        {
            Console.WriteLine($"Admin alert: {e.ProductName} stock is low , current stock is {e.CurrentStock}");
        }

        static void CreatePurchaseRequest(object sender,StockLowEventArgs e)
        {
            Console.WriteLine($"Purchase request created for {e.ProductName}");
        }
        static void Main(string[] args)
        {
            InventoryService inventoryService = new InventoryService();

            inventoryService.StockLow += NotifyAdmin;
            inventoryService.StockLow += CreatePurchaseRequest;

            inventoryService.UpdateStock("maruf", 20);
            inventoryService.UpdateStock("protik", 9);


        }
    }
}
