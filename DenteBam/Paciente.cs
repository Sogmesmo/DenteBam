using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenteBam
{
    class Paciente : Pessoa
    {

      //  public int Id { get; set; }
      //  public string Nome { get; set; }
        public string End { get; set; }
        public string Cpf { get; set; }
        public string Tel{ get; set; }
        public DateTime DTNasc { get; set; }
        public System.Windows.Forms.FormStartPosition StartPosition { get; set; }

    }
}
