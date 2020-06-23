using Ebling.Datas.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebling.Datas.FormsDatas
{
    public partial class Turno : Form
    {
        public Turno() {
            InitializeComponent();
        }


        DatasController oDatas = new DatasController();

        string dtHora = "";

        private void BtnBuscar_Click(object sender, EventArgs e) {


            try {

                dtHora = oDatas.GetTurn(Convert.ToDateTime(txtHora.Text));


                if (dtHora != "Noturno")
                    LbResp.ForeColor = Color.OrangeRed;
                else
                    LbResp.ForeColor = Color.DarkBlue;

                LbResp.Text = dtHora;
                txtHora.Text = "";

                Timer Tempo = new Timer();
                Tempo.Interval = 3000;
                Tempo.Tick += new EventHandler(Tempo_Tick);
                Tempo.Start();

            } catch (Exception ex) {

                MessageBox.Show("[ERRO]: Você precisa informar uma hora válida!");
                txtHora.Text = "";
            }
        }

        private void Tempo_Tick(object sender, EventArgs e) {
            LbResp.ForeColor = Color.Black;
            LbResp.Text = "Aguardando que digite o horário...";
        }

    }
}
