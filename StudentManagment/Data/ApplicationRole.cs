
using Microsoft.AspNetCore.Identity;

namespace StudentManagment.Data

{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
        public string CreatedById { get; set; }
        public ApplicationUser CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string RewievedById { get; set; }
        public ApplicationUser RewievedBy { get; set; }
    }
}
