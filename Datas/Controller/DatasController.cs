using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebling.Datas.Controller
{
    public class DatasController
    {
        public DatasController() { }


        public enum Turno
        {
            Diurno,
            Noturno
        };

        public string GetTurn(DateTime dtHora) {

            Turno Resultado;

            TimeSpan NoturnoInicial = TimeSpan.Parse("16:50");

            TimeSpan NoturnoFinal = TimeSpan.Parse("06:10");

            TimeSpan HoraInformada = TimeSpan.Parse(dtHora.ToShortTimeString());


            if (HoraInformada > NoturnoFinal && HoraInformada < NoturnoInicial)
                Resultado = Turno.Diurno;
            else
                Resultado = Turno.Noturno;

            return Resultado.ToString();
        }
    }
}
