namespace Domain.Models
{
    public class Product : BaseClass
    {

        #region Propertices
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public int Code { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public bool IsPublished { get; set; }
        public string Description { get; set; }
        #endregion

        #region Relations
        public Category Category { get; set; } 
        #endregion

    }
}
