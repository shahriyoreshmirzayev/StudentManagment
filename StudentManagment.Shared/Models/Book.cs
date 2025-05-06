namespace StudentManagment.Shared.Models
{
    public class Book : UserCreateActivity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Auther { get; set; }
        public int NoOfCopy { get; set; }
        public int BookCategoryId { get; set; }
        public SystemCodeDetail BookCategory { get; set; }
    }
}
