using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Paciente
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Crm { get; set; }
        [Required]
        public string CrmUf { get; set; }
        public List<DoutorPaciente> MyProperty { get; set; }

    }
}
