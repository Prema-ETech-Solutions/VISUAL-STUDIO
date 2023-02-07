namespace File_IO
{
    partial class MainForm
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
            this.User_name = new System.Windows.Forms.Button();
            this.Base = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // User_name
            // 
            this.User_name.Location = new System.Drawing.Point(0, 0);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(144, 59);
            this.User_name.TabIndex = 0;
            this.User_name.Text = "User Name";
            this.User_name.UseVisualStyleBackColor = true;
            this.User_name.Click += new System.EventHandler(this.User_name_Click);
            // 
            // Base
            // 
            this.Base.Location = new System.Drawing.Point(150, 0);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(144, 59);
            this.Base.TabIndex = 1;
            this.Base.Text = "Base Data";
            this.Base.UseVisualStyleBackColor = true;
            this.Base.Click += new System.EventHandler(this.Base_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.User_name);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button User_name;
        private System.Windows.Forms.Button Base;
    }
}

