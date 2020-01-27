using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenteBam
{
    class Consulta
    {
        public string nomePaciente { get; set; }
        public string nomeDentista { get; set; }
        public int Id { get; set; }
        public int IdDentista { get; set; }
        public int IdPaciente { get; set; }
        public string Motivo { get; set; }
        public string Diagnostico { get; set; }
        public string Receita { get; set; }
        public string Retorno { get; set; }
        public DateTime DTConsulta { get; set; }
        public DateTime DTRetorno { get; set; }

    }
}
