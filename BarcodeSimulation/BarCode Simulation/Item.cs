namespace BarcodeSimulation
{
    internal class Item
    {
        public int CategoryNumber { get; set; }
        public int ItemPrice { get; set; }
        public int ItemNumber { get; set; }
        public string ItemName { get; set; }


        public string GetFormattedCategoryNumber(int categoryNumber)
        {
            string newNum = categoryNumber.ToString();
            string returnedNum = string.Empty;

            for (int i = 0; i < (3 - newNum.Length); i++)
            {
                returnedNum += "0";
            }
            return returnedNum + newNum;
        }

        public string GetFormattedItemPrince(decimal price)
        {
            string newNum = price.ToString();
            string returnedNum = string.Empty;

            for (int i = 0; i < (3 - newNum.Length); i++)
            {
                returnedNum += "0";
            }
            return returnedNum + newNum;
        }

        public string GetFormattedItemNumber(int ItemNumber)
        {
            string newNum = ItemNumber.ToString();
            string returnedNum = string.Empty;

            for (int i = 0; i < (3 - newNum.Length); i++)
            {
                returnedNum += "0";
            }
            return returnedNum + newNum;
        }
    }
    
}