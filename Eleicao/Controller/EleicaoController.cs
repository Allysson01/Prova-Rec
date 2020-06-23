using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebling
{
    public class EleicaoController
    {
        public EleicaoController() { }

        public string electionWinner(string[] dados) {

            int Antônio = (from q in dados where q.Equals("Antônio") select dados).Count();
            int Fernando = (from q in dados where q.Equals("Fernando") select dados).Count();
            int Móises = (from q in dados where q.Equals("Móises") select dados).Count();
            int Rodrigo = (from q in dados where q.Equals("Rodrigo") select dados).Count();

            Dictionary<string, int> ListVencedores = new Dictionary<string, int>();

            ListVencedores.Add(nameof(Antônio), Antônio);
            ListVencedores.Add(nameof(Fernando), Fernando);
            ListVencedores.Add(nameof(Móises), Móises);
            ListVencedores.Add(nameof(Rodrigo), Rodrigo);

            var maiorValor = ListVencedores.Max(x => x.Value);
            var Result = ListVencedores.LastOrDefault(x => x.Value == maiorValor).Key;

            return Result.ToUpper().ToString();
        }
    }
}
