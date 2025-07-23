using System.ComponentModel.DataAnnotations;

namespace KiemTraMvc.Models
{
    public class Hieu
    {
        [Key]
        public Guid Id { get; set; }
        public string FullName { get; set; }

    }
}