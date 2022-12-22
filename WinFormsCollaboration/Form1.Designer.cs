namespace WinFormsCollaboration
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
            this.btnLos = new System.Windows.Forms.Button();
			this.BtnBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLos
            // 
            this.btnLos.Location = new System.Drawing.Point(249, 133);
            this.btnLos.Name = "btnLos";
            this.btnLos.Size = new System.Drawing.Size(73, 61);
            this.btnLos.TabIndex = 0;
            this.btnLos.Text = "Los!";
            this.btnLos.UseVisualStyleBackColor = true;
            // 
            // BtnBeenden
            // 
            this.BtnBeenden.Location = new System.Drawing.Point(415, 216);
            this.BtnBeenden.Name = "BtnBeenden";
            this.BtnBeenden.Size = new System.Drawing.Size(121, 71);
            this.BtnBeenden.TabIndex = 0;
            this.BtnBeenden.Text = "Beenden";
            this.BtnBeenden.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 361);
            this.Controls.Add(this.btnLos);
            this.Controls.Add(this.BtnBeenden);
            this.Name = "Form1";
            this.Text = "WinFormsCollaboration";
            this.ResumeLayout(false);

        }

        #endregion


        private Button btnLos;
        private Button BtnBeenden;

    }
}