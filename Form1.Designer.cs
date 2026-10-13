namespace VerificaInformatica
{
    partial class Form1
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
            listParole = new ListBox();
            btnLeggiFile = new Button();
            SuspendLayout();
            // 
            // listParole
            // 
            listParole.FormattingEnabled = true;
            listParole.ItemHeight = 15;
            listParole.Location = new Point(12, 12);
            listParole.Name = "listParole";
            listParole.Size = new Size(167, 184);
            listParole.TabIndex = 0;
            listParole.SelectedIndexChanged += listParole_SelectedIndexChanged;
            // 
            // btnLeggiFile
            // 
            btnLeggiFile.Location = new Point(185, 12);
            btnLeggiFile.Name = "btnLeggiFile";
            btnLeggiFile.Size = new Size(75, 23);
            btnLeggiFile.TabIndex = 1;
            btnLeggiFile.Text = "Leggi file";
            btnLeggiFile.UseVisualStyleBackColor = true;
            btnLeggiFile.Click += btnLeggiFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLeggiFile);
            Controls.Add(listParole);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listParole;
        private Button btnLeggiFile;
    }
}
