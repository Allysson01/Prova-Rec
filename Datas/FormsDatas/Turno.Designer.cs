namespace Ebling.Datas.FormsDatas
{
    partial class Turno
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
            this.LbInformacao = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.LbResp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbInformacao
            // 
            this.LbInformacao.AutoSize = true;
            this.LbInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInformacao.Location = new System.Drawing.Point(38, 70);
            this.LbInformacao.Name = "LbInformacao";
            this.LbInformacao.Size = new System.Drawing.Size(241, 16);
            this.LbInformacao.TabIndex = 0;
            this.LbInformacao.Text = "Informe o seu horário de trabalho:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Location = new System.Drawing.Point(106, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LbResp
            // 
            this.LbResp.AutoSize = true;
            this.LbResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbResp.Location = new System.Drawing.Point(4, 46);
            this.LbResp.Name = "LbResp";
            this.LbResp.Size = new System.Drawing.Size(248, 16);
            this.LbResp.TabIndex = 3;
            this.LbResp.Text = "Aguardando que digite o horário ...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbResp);
            this.groupBox1.Location = new System.Drawing.Point(21, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(106, 89);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(96, 20);
            this.txtHora.TabIndex = 5;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.txtHora.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtHora_MaskInputRejected);
            // 
            // Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 260);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.LbInformacao);
            this.Name = "Turno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Turno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbInformacao;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label LbResp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtHora;
    }
}