
namespace E_Learning_Project_final.Models
{
    public class CartItem
    {
        public int CourseId { get; set; }
        public int Id {  get; set; }
        // Primary Key
        public string Name { get; set; }
        public string UserId { get; set; }  // Foreign Key to the User

        // Price as string
        public string Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }  // Quantity of the product in the cart
        public DateTime AddedDate { get; set; }  // Date when the product was added to the cart

        public virtual Course Product { get; set; }

        // Define FinalPrice as nullable int to handle potential null values in Price
        public int? FinalPrice
        {
            get
            {
                // Check if Price is null or empty
                if (string.IsNullOrEmpty(Price))
                {
                    // Handle null or empty Price
                    return null;
                }

                // Attempt to parse Price to an integer
                if (int.TryParse(Price, out int parsedPrice))
                {
                    // Successfully parsed Price
                    return parsedPrice;
                }
                else
                {
                    // Failed to parse Price
                    throw new InvalidOperationException("Price is not in a valid format.");
                }
            }
        }

        // Calculate TotalPrice based on Quantity and FinalPrice
        public int? TotalPrice => Quantity * FinalPrice;
    }
}
