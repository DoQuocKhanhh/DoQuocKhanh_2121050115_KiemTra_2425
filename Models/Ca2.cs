using System.ComponentModel.DataAnnotations;

namespace QuocKhanhMvc.Models
{
    public class Ca2
    {
        [Key]
        public require string PersonID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
