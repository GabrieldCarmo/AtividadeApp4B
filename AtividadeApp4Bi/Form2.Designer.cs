namespace AtividadeApp4Bi
{
    partial class frmtabuada
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
            btncalcular = new Button();
            btnsair = new Button();
            btnlimpar = new Button();
            txttabuada = new TextBox();
            txtnum = new TextBox();
            lblnum = new Label();
            lbltabuada = new Label();
            btncalculardowhile = new Button();
            btncalcularfor = new Button();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(48, 274);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(176, 37);
            btncalcular.TabIndex = 1;
            btncalcular.Text = "Calcular (While)";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnsair
            // 
            btnsair.Location = new Point(609, 336);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(96, 37);
            btnsair.TabIndex = 2;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = true;
            btnsair.Click += btnsair_Click_1;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(348, 336);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(96, 37);
            btnlimpar.TabIndex = 3;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // txttabuada
            // 
            txttabuada.Location = new Point(490, 73);
            txttabuada.Multiline = true;
            txttabuada.Name = "txttabuada";
            txttabuada.Size = new Size(196, 217);
            txttabuada.TabIndex = 4;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(298, 69);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(100, 23);
            txtnum.TabIndex = 5;
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnum.Location = new Point(12, 71);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(273, 21);
            lblnum.TabIndex = 6;
            lblnum.Text = "Digite o número que deseja a tabuada";
            // 
            // lbltabuada
            // 
            lbltabuada.AutoSize = true;
            lbltabuada.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltabuada.Location = new Point(490, 36);
            lbltabuada.Name = "lbltabuada";
            lbltabuada.Size = new Size(74, 21);
            lbltabuada.TabIndex = 7;
            lbltabuada.Text = "Tabuada:";
            // 
            // btncalculardowhile
            // 
            btncalculardowhile.Location = new Point(48, 336);
            btncalculardowhile.Name = "btncalculardowhile";
            btncalculardowhile.Size = new Size(176, 37);
            btncalculardowhile.TabIndex = 8;
            btncalculardowhile.Text = "Calcular (Do While)";
            btncalculardowhile.UseVisualStyleBackColor = true;
            btncalculardowhile.Click += btncalculardowhile_Click;
            // 
            // btncalcularfor
            // 
            btncalcularfor.Location = new Point(48, 401);
            btncalcularfor.Name = "btncalcularfor";
            btncalcularfor.Size = new Size(176, 37);
            btncalcularfor.TabIndex = 9;
            btncalcularfor.Text = "Calcular(For)";
            btncalcularfor.UseVisualStyleBackColor = true;
            btncalcularfor.Click += btncalcularfor_Click;
            // 
            // frmtabuada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncalcularfor);
            Controls.Add(btncalculardowhile);
            Controls.Add(lbltabuada);
            Controls.Add(lblnum);
            Controls.Add(txtnum);
            Controls.Add(txttabuada);
            Controls.Add(btnlimpar);
            Controls.Add(btnsair);
            Controls.Add(btncalcular);
            Name = "frmtabuada";
            Text = "Tabuada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private Button btnsair;
        private Button btnlimpar;
        private TextBox txttabuada;
        private TextBox txtnum;
        private Label lblnum;
        private Label lbltabuada;
        private Button btncalculardowhile;
        private Button btncalcularfor;
    }
}