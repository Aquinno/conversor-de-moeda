using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec4PropsEx3 {
    internal class Aluno {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }
        public string Situacao() {
            if (NotaFinal() >= 60) {
                return "Aprovado";
            }
            else {
                return "Reprovado\nFaltaram " + (60 - NotaFinal()) + " pontos";
            }
        }
    }
}
