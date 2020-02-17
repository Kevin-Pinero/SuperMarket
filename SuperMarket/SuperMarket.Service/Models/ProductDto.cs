namespace SuperMarket.Service.Models
{
    public class ProductDto
    {
        public ProductDto(Repository.Model.Product product)
        {
            Id = product.Id;
            Label = product.Label;
        }

        public long Id { get; set; }
        public string Label { get; set; }
    }
}
