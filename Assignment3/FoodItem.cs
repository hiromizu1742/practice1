namespace foodsystem
{
    // This is the list of constructor
    internal class FoodItem
    {
        public string Name;
        public string Category;
        public int Qty;
        public string ExpDate;
        // declare the public 
        public FoodItem(string name, string category, int qty, string expDate)
        {
            Name = name;
            Category = category;
            Qty = qty;
            ExpDate = expDate;
        }
    }
}