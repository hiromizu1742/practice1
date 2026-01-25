namespace foodsystem
{
    internal class foodtrack
    {
        
        FoodItem[] items = new FoodItem[100];
        int count = 0;
        
        public string FoodList()
        {
            
            if (count == 0) return "No Food Found";
            
            string result = "";
            
            for (int i = 0; i < count; i++)
            {
                result += $"{i+1}. Name: {items[i].Name} | Category: {items[i].Category} | qty: {items[i].Qty} | Exp: {items[i].ExpDate}\n";
            }

            return result;
        }

        public bool AddFood(string fooditem, string fooddate, int foodqty, string foodcategory)
        {
            if (foodqty <= 0) return false;
            
            for (int i = 0; i < count; i++)
            {
                if (items[i].Name == fooditem && items[i].Category == foodcategory && items[i].ExpDate == fooddate)
                {
                    items[i].Qty += foodqty;
                    return true;
                }
            }
            
            items[count] = new FoodItem(fooditem, foodcategory, foodqty, fooddate);
            count++;
            
            return true;
        }

        public bool RemoveFood(string fooditem, string foodcategory)
        {
            int deletecount = 0;
            
            for (int i=0; i < count; i++)
            {
                if (items[i].Name == fooditem && items[i].Category == foodcategory)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    count--;
                    
                    deletecount++;
                    i--;
                }
            }
            return deletecount > 0;
        }
        
        
    }
}