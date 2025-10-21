namespace AtividadeApp4Bi
{
    partial class frmconversor
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
            txtconversor = new TextBox();
            lblconversoes = new Label();
            SuspendLayout();
            // 
            // btncalcularfor
            // 
            btncalcularfor.Location = new Point(69, 396);
            btncalcularfor.Name = "btncalcularfor";
            btncalcularfor.Size = new Size(176, 37);
            btncalcularfor.TabIndex = 14;
            btncalcularfor.Text = "Calcular(For)";
            btncalcularfor.UseVisualStyleBackColor = true;
            btncalcularfor.Click += btncalcularfor_Click;
            // 
            // btncalculardowhile
            // 
            btncalculardowhile.Location = new Point(69, 331);
            btncalculardowhile.Name = "btncalculardowhile";
            btncalculardowhile.Size = new Size(176, 37);
            btncalculardowhile.TabIndex = 13;
            btncalculardowhile.Text = "Calcular (Do While)";
            btncalculardowhile.UseVisualStyleBackColor = true;
            btncalculardowhile.Click += btncalculardowhile_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(384, 396);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(96, 37);
            btnlimpar.TabIndex = 12;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnsair
            // 
            btnsair.Location = new Point(642, 396);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(96, 37);
            btnsair.TabIndex = 11;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = true;
            btnsair.Click += btnsair_Click;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(69, 269);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(176, 37);
            btncalcular.TabIndex = 10;
            btncalcular.Text = "Calcular (While)";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // txtconversor
            // 
            txtconversor.Location = new Point(369, 28);
            txtconversor.Multiline = true;
            txtconversor.Name = "txtconversor";
            txtconversor.Size = new Size(312, 278);
            txtconversor.TabIndex = 15;
            // 
            // lblconversoes
            // 
            lblconversoes.AutoSize = true;
            lblconversoes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblconversoes.Location = new Point(264, 28);
            lblconversoes.Name = "lblconversoes";
            lblconversoes.Size = new Size(99, 21);
            lblconversoes.TabIndex = 16;
            lblconversoes.Text = "Conversões:";
            // 
            // frmconversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblconversoes);
            Controls.Add(txtconversor);
            Controls.Add(btncalcularfor);
            Controls.Add(btncalculardowhile);
            Controls.Add(btnlimpar);
            Controls.Add(btnsair);
            Controls.Add(btncalcular);
            Name = "frmconversor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcularfor;
        private Button btncalculardowhile;
        private Button btnlimpar;
        private Button btnsair;
        private Button btncalcular;
        private TextBox txtconversor;
        private Label lblconversoes;
    }
}