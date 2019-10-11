namespace HotelReservation
{
    public class PriceCalculator
    {
        public decimal CalculatePrice(decimal pricePerDay, int countOfDays, Season season, DiscountType discount)
        {
            int multiplier = (int)season;
            decimal discountMultiplier = (decimal)discount / 100.0M;

            decimal priceBeforeDiscount = countOfDays * pricePerDay * multiplier;
            decimal discountedAmount = priceBeforeDiscount * discountMultiplier;
            decimal finalPrice = priceBeforeDiscount - discountedAmount;

            return finalPrice;
        }
    }
}
