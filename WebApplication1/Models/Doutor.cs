using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Doutor
    {
        [Required]
        public int Id  { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DirthDate { get; set; }
        [Required]
        public string Cpf { get; set; }
        public List<DoutorPaciente> MyProperty { get; set; }
    }
}
