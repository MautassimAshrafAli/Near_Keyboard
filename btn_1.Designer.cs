
namespace keyboard_
{
    partial class btn_1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new Guna.UI.WinForms.GunaElipsePanel();
            this.name_btn = new System.Windows.Forms.Label();
            this.btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Transparent;
            this.btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btn.Controls.Add(this.name_btn);
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn.Name = "btn";
            this.btn.Radius = 5;
            this.btn.Size = new System.Drawing.Size(95, 72);
            this.btn.TabIndex = 79;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            this.btn.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // name_btn
            // 
            this.name_btn.AutoSize = true;
            this.name_btn.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.name_btn.ForeColor = System.Drawing.Color.White;
            this.name_btn.Location = new System.Drawing.Point(15, 17);
            this.name_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_btn.Name = "name_btn";
            this.name_btn.Size = new System.Drawing.Size(65, 39);
            this.name_btn.TabIndex = 10;
            this.name_btn.Text = "Btn";
            this.name_btn.Click += new System.EventHandler(this.btn_Click);
            this.name_btn.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.name_btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn);
            this.Name = "btn_1";
            this.Size = new System.Drawing.Size(95, 72);
            this.btn.ResumeLayout(false);
            this.btn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel btn;
        private System.Windows.Forms.Label name_btn;
    }
}
