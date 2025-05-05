namespace StudentManagment.Shared.Models
{
    public class Subject : UserCreateActivity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
