namespace QLDiem.Entity
{
    partial class MenuBase
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
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.btn_2);
            this.pnl_Menu.Controls.Add(this.btn_1);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(156, 514);
            this.pnl_Menu.TabIndex = 0;
            // 
            // pnl_Form
            // 
            this.pnl_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Form.Location = new System.Drawing.Point(156, 0);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(683, 514);
            this.pnl_Form.TabIndex = 1;
            // 
            // btn_1
            // 
            this.btn_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_1.Location = new System.Drawing.Point(0, 0);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(156, 44);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Chức năng 1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_2.Location = new System.Drawing.Point(0, 44);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(156, 44);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "Chức năng 2";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // MenuBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(839, 514);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.pnl_Menu);
            this.Name = "MenuBase";
            this.Text = "MenuBase";
            this.pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
    }
}