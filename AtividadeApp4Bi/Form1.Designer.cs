﻿namespace AtividadeApp4Bi
{
    partial class frmmenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            programaToolStripMenuItem = new ToolStripMenuItem();
            tabuadaToolStripMenuItem = new ToolStripMenuItem();
            conversorToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { programaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // programaToolStripMenuItem
            // 
            programaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tabuadaToolStripMenuItem, conversorToolStripMenuItem });
            programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            programaToolStripMenuItem.Size = new Size(71, 20);
            programaToolStripMenuItem.Text = "Programa";
            programaToolStripMenuItem.Click += programaToolStripMenuItem_Click;
            // 
            // tabuadaToolStripMenuItem
            // 
            tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            tabuadaToolStripMenuItem.Size = new Size(180, 22);
            tabuadaToolStripMenuItem.Text = "Tabuada";
            tabuadaToolStripMenuItem.Click += tabuadaToolStripMenuItem_Click;
            // 
            // conversorToolStripMenuItem
            // 
            conversorToolStripMenuItem.ImageAlign = ContentAlignment.MiddleRight;
            conversorToolStripMenuItem.Name = "conversorToolStripMenuItem";
            conversorToolStripMenuItem.Size = new Size(180, 22);
            conversorToolStripMenuItem.Text = "Conversor";
            conversorToolStripMenuItem.Click += conversorToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // frmmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "frmmenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem programaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem tabuadaToolStripMenuItem;
        private ToolStripMenuItem conversorToolStripMenuItem;
    }
}
