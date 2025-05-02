using System.ComponentModel.DataAnnotations;

namespace StudentManagment.Shared.Models
{
    public class SystemCodeDetail
    {
        [Key]
        public int Id { get; set; }
        public int SytemCodeId { get; set; }
        public SystemCode SystemCode { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? OrderNo { get; set; }

    }
}
