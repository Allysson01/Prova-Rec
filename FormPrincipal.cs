
using Ebling.Datas.FormsDatas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebling
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal() {
            InitializeComponent();
        }

        Eleicao oEleicao;

        Turno oTurno;

        private void Button1_Click(object sender, EventArgs e) {
            oEleicao = new Eleicao();
            oEleicao.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e) {
            oTurno = new Turno();
            oTurno.ShowDialog();
        }
    }
}
