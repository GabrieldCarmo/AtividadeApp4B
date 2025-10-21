namespace AtividadeApp4Bi
{
    partial class frmarea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btncalcularfor = new Button();
            btncalculardowhile = new Button();
            btnlimpar = new Button();
            btnsair = new Button();
            btncalcular = new Button();
            lblc = new Label();
            txtcomodos = new TextBox();
            lbllar = new Label();
            txtlar = new TextBox();
            lblcom = new Label();
            txtcom = new TextBox();
            SuspendLayout();
            // 
            // btncalcularfor
            // 
            btncalcularfor.Location = new Point(64, 383);
            btncalcularfor.Name = "btncalcularfor";
            btncalcularfor.Size = new Size(176, 37);
            btncalcularfor.TabIndex = 19;
            btncalcularfor.Text = "Calcular(For)";
            btncalcularfor.UseVisualStyleBackColor = true;
            // 
            // btncalculardowhile
            // 
            btncalculardowhile.Location = new Point(64, 318);
            btncalculardowhile.Name = "btncalculardowhile";
            btncalculardowhile.Size = new Size(176, 37);
            btncalculardowhile.TabIndex = 18;
            btncalculardowhile.Text = "Calcular (Do While)";
            btncalculardowhile.UseVisualStyleBackColor = true;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(379, 383);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(96, 37);
            btnlimpar.TabIndex = 17;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnsair
            // 
            btnsair.Location = new Point(637, 383);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(96, 37);
            btnsair.TabIndex = 16;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = true;
            btnsair.Click += btnsair_Click;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(64, 256);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(176, 37);
            btncalcular.TabIndex = 15;
            btncalcular.Text = "Calcular (While)";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // lblc
            // 
            lblc.AutoSize = true;
            lblc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblc.Location = new Point(64, 55);
            lblc.Name = "lblc";
            lblc.Size = new Size(234, 21);
            lblc.TabIndex = 21;
            lblc.Text = "Digite a quantidade de cômodos";
            // 
            // txtcomodos
            // 
            txtcomodos.Location = new Point(318, 55);
            txtcomodos.Name = "txtcomodos";
            txtcomodos.Size = new Size(100, 23);
            txtcomodos.TabIndex = 20;
            // 
            // lbllar
            // 
            lbllar.AutoSize = true;
            lbllar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbllar.Location = new Point(64, 119);
            lbllar.Name = "lbllar";
            lbllar.Size = new Size(147, 21);
            lbllar.TabIndex = 23;
            lbllar.Text = "Largura do comodo";
            // 
            // txtlar
            // 
            txtlar.Location = new Point(260, 119);
            txtlar.Name = "txtlar";
            txtlar.Size = new Size(100, 23);
            txtlar.TabIndex = 22;
            // 
            // lblcom
            // 
            lblcom.AutoSize = true;
            lblcom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcom.Location = new Point(64, 159);
            lblcom.Name = "lblcom";
            lblcom.Size = new Size(190, 21);
            lblcom.TabIndex = 25;
            lblcom.Text = "Comprimento do cômodo";
            // 
            // txtcom
            // 
            txtcom.Location = new Point(260, 161);
            txtcom.Name = "txtcom";
            txtcom.Size = new Size(100, 23);
            txtcom.TabIndex = 24;
            // 
            // frmarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblcom);
            Controls.Add(txtcom);
            Controls.Add(lbllar);
            Controls.Add(txtlar);
            Controls.Add(lblc);
            Controls.Add(txtcomodos);
            Controls.Add(btncalcularfor);
            Controls.Add(btncalculardowhile);
            Controls.Add(btnlimpar);
            Controls.Add(btnsair);
            Controls.Add(btncalcular);
            Name = "frmarea";
            Text = "Área de uma residência";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcularfor;
        private Button btncalculardowhile;
        private Button btnlimpar;
        private Button btnsair;
        private Button btncalcular;
        private Label lblc;
        private TextBox txtcomodos;
        private Label lbllar;
        private TextBox txtlar;
        private Label lblcom;
        private TextBox txtcom;
    }
}