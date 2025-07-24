using System.ComponentModel.DataAnnotations;

namespace KiemTraMvc.Models
{
    public class Lop
    {
        [Key]
        public string FullName { get; set; }
        public int Sđt { get; set; }
        public int Tuoi { get; set; }

    }
}