namespace DbOperationWithEFCoreApp
{
    public class CurrencyType
    {
        public int Id {  get; set; }
        public string Currency {  get; set; }
        public string Description { get; set; }
        public ICollection<BookPrice> BookPrices { get; set; }
    }
}
