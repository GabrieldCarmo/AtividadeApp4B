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
            btncalcular = new Button();
            btnlimpar = new Button();
            btnsair = new Button();
            txtlargura = new TextBox();
            txtcomp = new TextBox();
            txtareatot = new TextBox();
            txtareaco = new TextBox();
            lblnum = new Label();
            lblcom = new Label();
            lblc = new Label();
            lbltot = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(57, 380);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(176, 37);
            btncalcular.TabIndex = 18;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(372, 380);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(96, 37);
            btnlimpar.TabIndex = 16;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnsair
            // 
            btnsair.Location = new Point(630, 380);
            btnsair.Name = "btnsair";
            btnsair.Size = new Size(96, 37);
            btnsair.TabIndex = 15;
            btnsair.Text = "Sair";
            btnsair.UseVisualStyleBackColor = true;
            btnsair.Click += btnsair_Click;
            // 
            // txtlargura
            // 
            txtlargura.Location = new Point(313, 96);
            txtlargura.Name = "txtlargura";
            txtlargura.Size = new Size(168, 23);
            txtlargura.TabIndex = 19;
            // 
            // txtcomp
            // 
            txtcomp.Location = new Point(313, 141);
            txtcomp.Name = "txtcomp";
            txtcomp.Size = new Size(168, 23);
            txtcomp.TabIndex = 20;
            // 
            // txtareatot
            // 
            txtareatot.Location = new Point(313, 233);
            txtareatot.Name = "txtareatot";
            txtareatot.ReadOnly = true;
            txtareatot.Size = new Size(168, 23);
            txtareatot.TabIndex = 21;
            // 
            // txtareaco
            // 
            txtareaco.Location = new Point(313, 188);
            txtareaco.Name = "txtareaco";
            txtareaco.ReadOnly = true;
            txtareaco.Size = new Size(168, 23);
            txtareaco.TabIndex = 22;
            txtareaco.TextChanged += txtareaco_TextChanged;
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnum.Location = new Point(61, 98);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(200, 21);
            lblnum.TabIndex = 23;
            lblnum.Text = "Digite a largura do cômodo";
            // 
            // lblcom
            // 
            lblcom.AutoSize = true;
            lblcom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcom.Location = new Point(61, 143);
            lblcom.Name = "lblcom";
            lblcom.Size = new Size(245, 21);
            lblcom.TabIndex = 24;
            lblcom.Text = "Digite o comprimento do cômodo";
            // 
            // lblc
            // 
            lblc.AutoSize = true;
            lblc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblc.Location = new Point(61, 190);
            lblc.Name = "lblc";
            lblc.Size = new Size(136, 21);
            lblc.TabIndex = 25;
            lblc.Text = "Área do cômodo";
            // 
            // lbltot
            // 
            lbltot.AutoSize = true;
            lbltot.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbltot.Location = new Point(61, 235);
            lbltot.Name = "lbltot";
            lbltot.Size = new Size(145, 21);
            lbltot.TabIndex = 26;
            lbltot.Text = "Área total da casa";
            // 
            // frmarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lbltot);
            Controls.Add(lblc);
            Controls.Add(lblcom);
            Controls.Add(lblnum);
            Controls.Add(txtareaco);
            Controls.Add(txtareatot);
            Controls.Add(txtcomp);
            Controls.Add(txtlargura);
            Controls.Add(btncalcular);
            Controls.Add(btnlimpar);
            Controls.Add(btnsair);
            Name = "frmarea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Área de uma casa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private Button btnlimpar;
        private Button btnsair;
        private TextBox txtlargura;
        private TextBox txtcomp;
        private TextBox txtareatot;
        private TextBox txtareaco;
        private Label lblnum;
        private Label lblcom;
        private Label lblc;
        private Label lbltot;
    }
}