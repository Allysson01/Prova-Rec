namespace Ebling
{
    partial class Eleicao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LbInforme = new System.Windows.Forms.Label();
            this.txtNumVotos = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.gpbVotacao = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdRodrigo = new System.Windows.Forms.RadioButton();
            this.rdMoises = new System.Windows.Forms.RadioButton();
            this.rdFernando = new System.Windows.Forms.RadioButton();
            this.rdAntonio = new System.Windows.Forms.RadioButton();
            this.lbTotal = new System.Windows.Forms.Label();
            this.gpbVotacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbInforme
            // 
            this.LbInforme.AutoSize = true;
            this.LbInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInforme.Location = new System.Drawing.Point(30, 43);
            this.LbInforme.Name = "LbInforme";
            this.LbInforme.Size = new System.Drawing.Size(229, 20);
            this.LbInforme.TabIndex = 0;
            this.LbInforme.Text = "Informe o número de votos:";
            // 
            // txtNumVotos
            // 
            this.txtNumVotos.Location = new System.Drawing.Point(279, 43);
            this.txtNumVotos.Name = "txtNumVotos";
            this.txtNumVotos.Size = new System.Drawing.Size(133, 20);
            this.txtNumVotos.TabIndex = 1;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciar.Location = new System.Drawing.Point(451, 40);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(129, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar votação";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // gpbVotacao
            // 
            this.gpbVotacao.Controls.Add(this.lbTotal);
            this.gpbVotacao.Controls.Add(this.label4);
            this.gpbVotacao.Controls.Add(this.lbCount);
            this.gpbVotacao.Controls.Add(this.label2);
            this.gpbVotacao.Controls.Add(this.btnConfirmar);
            this.gpbVotacao.Controls.Add(this.label1);
            this.gpbVotacao.Controls.Add(this.rdRodrigo);
            this.gpbVotacao.Controls.Add(this.rdMoises);
            this.gpbVotacao.Controls.Add(this.rdFernando);
            this.gpbVotacao.Controls.Add(this.rdAntonio);
            this.gpbVotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbVotacao.Location = new System.Drawing.Point(12, 66);
            this.gpbVotacao.Name = "gpbVotacao";
            this.gpbVotacao.Size = new System.Drawing.Size(683, 351);
            this.gpbVotacao.TabIndex = 3;
            this.gpbVotacao.TabStop = false;
            this.gpbVotacao.Text = "Votação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "de";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.ForeColor = System.Drawing.Color.Red;
            this.lbCount.Location = new System.Drawing.Point(615, 17);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(14, 15);
            this.lbCount.TabIndex = 8;
            this.lbCount.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Voto";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(445, 272);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(123, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha um candidato e pressione confirmar:";
            // 
            // rdRodrigo
            // 
            this.rdRodrigo.AutoSize = true;
            this.rdRodrigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Ebling.Properties.Settings.Default, "Rodrigo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdRodrigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRodrigo.Location = new System.Drawing.Point(482, 111);
            this.rdRodrigo.Name = "rdRodrigo";
            this.rdRodrigo.Size = new System.Drawing.Size(86, 22);
            this.rdRodrigo.TabIndex = 5;
            this.rdRodrigo.TabStop = true;
            this.rdRodrigo.Text = global::Ebling.Properties.Settings.Default.Rodrigo;
            this.rdRodrigo.UseVisualStyleBackColor = true;
            // 
            // rdMoises
            // 
            this.rdMoises.AutoSize = true;
            this.rdMoises.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Ebling.Properties.Settings.Default, "Moises", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdMoises.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMoises.Location = new System.Drawing.Point(361, 111);
            this.rdMoises.Name = "rdMoises";
            this.rdMoises.Size = new System.Drawing.Size(81, 22);
            this.rdMoises.TabIndex = 4;
            this.rdMoises.TabStop = true;
            this.rdMoises.Text = global::Ebling.Properties.Settings.Default.Moises;
            this.rdMoises.UseVisualStyleBackColor = true;
            // 
            // rdFernando
            // 
            this.rdFernando.AutoSize = true;
            this.rdFernando.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Ebling.Properties.Settings.Default, "Fernando", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdFernando.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFernando.Location = new System.Drawing.Point(222, 111);
            this.rdFernando.Name = "rdFernando";
            this.rdFernando.Size = new System.Drawing.Size(97, 22);
            this.rdFernando.TabIndex = 3;
            this.rdFernando.TabStop = true;
            this.rdFernando.Text = global::Ebling.Properties.Settings.Default.Fernando;
            this.rdFernando.UseVisualStyleBackColor = true;
            // 
            // rdAntonio
            // 
            this.rdAntonio.AutoSize = true;
            this.rdAntonio.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Ebling.Properties.Settings.Default, "Antonio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdAntonio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAntonio.Location = new System.Drawing.Point(86, 111);
            this.rdAntonio.Name = "rdAntonio";
            this.rdAntonio.Size = new System.Drawing.Size(83, 22);
            this.rdAntonio.TabIndex = 2;
            this.rdAntonio.TabStop = true;
            this.rdAntonio.Text = global::Ebling.Properties.Settings.Default.Antonio;
            this.rdAntonio.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(648, 17);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(14, 15);
            this.lbTotal.TabIndex = 10;
            this.lbTotal.Text = "1";
            // 
            // Eleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.gpbVotacao);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtNumVotos);
            this.Controls.Add(this.LbInforme);
            this.Name = "Eleicao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eleição";
            this.gpbVotacao.ResumeLayout(false);
            this.gpbVotacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbInforme;
        private System.Windows.Forms.TextBox txtNumVotos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.GroupBox gpbVotacao;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdRodrigo;
        private System.Windows.Forms.RadioButton rdMoises;
        private System.Windows.Forms.RadioButton rdFernando;
        private System.Windows.Forms.RadioButton rdAntonio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
    }
}