namespace SuperMarket.WebAPI.Contracts
{
    public class ProductResponse
    {
        public ProductResponse(Service.Models.ProductDto product)
        {
            Id = product.Id;
            Label = product.Label;
        }

        public long Id { get; set; }
        public string Label { get; set; }
    }
}
