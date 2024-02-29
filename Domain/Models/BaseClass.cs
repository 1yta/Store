namespace Domain.Models
{
    public class BaseClass
    {

        #region Propertices
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdetedDate { get; set; } 
        #endregion

    }
}
