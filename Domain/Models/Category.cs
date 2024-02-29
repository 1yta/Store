namespace Domain.Models
{
    public class Category : BaseClass
    {

        #region Propertices
        public string Title { get; set; }

        #endregion

        #region Relations
        public List<Product> Products { get; set; } 
        #endregion

    }
}
