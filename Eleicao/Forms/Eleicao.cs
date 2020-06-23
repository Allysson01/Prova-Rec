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
    public partial class Eleicao : Form
    {
        public string sRetornaSelecionado() {

            if (rdAntonio.Checked)
                sCandidato = rdAntonio.Text;
            else if (rdFernando.Checked)
                sCandidato = rdFernando.Text;
            else if (rdMoises.Checked)
                sCandidato = rdMoises.Text;
            else
                sCandidato = rdRodrigo.Text;

            return sCandidato;
        }


        int iVotacao = 0;
        string[] aVotos = new string[0];
        int iCount = 0;
        string sCandidato = "";
        string sResultado = "";
        EleicaoController oElecao = new EleicaoController();

        public Eleicao() {
            InitializeComponent();

            gpbVotacao.Visible = false;
        }

        private void BtnIniciar_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(txtNumVotos.Text)) {
                LbInforme.Visible = false;
                txtNumVotos.Visible = false;
                btnIniciar.Visible = false;

                gpbVotacao.Visible = true;

                iVotacao = Convert.ToInt32(txtNumVotos.Text);

                lbTotal.Text = iVotacao.ToString();
                lbCount.Text = (iCount + 1).ToString();
            } else {
                MessageBox.Show("Você deve escolher a quantidade de votos antes de começar!");
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e) {
            if (rdAntonio.Checked || rdFernando.Checked || rdMoises.Checked || rdRodrigo.Checked) {
                if (iCount < iVotacao) {

                    sCandidato = sRetornaSelecionado();

                    Array.Resize(ref aVotos, aVotos.Length + 1);

                    aVotos[iCount] = sCandidato;

                    iCount++;

                    rdAntonio.Checked = false;
                    rdFernando.Checked = false;
                    rdMoises.Checked = false;
                    rdRodrigo.Checked = false;

                    MessageBox.Show("Voto computado com sucesso!");

                    lbCount.Text = iCount < iVotacao ? (iCount + 1).ToString() : lbCount.Text;
                }

                if (iCount == iVotacao) {
                    if (MessageBox.Show("Votação chegou ao fim! Deseja saber quem é o vencedor?", "Ver",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                        LbInforme.Visible = true;
                        txtNumVotos.Visible = true;
                        btnIniciar.Visible = true;
                        txtNumVotos.Text = "";
                        gpbVotacao.Visible = false;
                        this.Close();
                        sResultado = oElecao.electionWinner(aVotos);
                        MessageBox.Show("O vencedor é: " + sResultado);
                    }
                    iCount = 0;
                    aVotos = new string[0];
                }
            } else {
                MessageBox.Show("Você precisa selecionar um candidato.");
            }
        }
    }
}
