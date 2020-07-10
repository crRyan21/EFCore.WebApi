using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DoutorPaciente
    {
        public int DoutorId { get; set; }
        public int PacienteId { get; set; }

        public Doutor Doutor { get; set; }
        public Paciente Paciente { get; set; }
    }
}
