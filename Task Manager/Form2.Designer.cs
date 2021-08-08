
namespace Task_Manager
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.OpenTaskTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RunTaskBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // OpenTaskTxtBx
            // 
            this.OpenTaskTxtBx.BorderColor = System.Drawing.Color.Black;
            this.OpenTaskTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OpenTaskTxtBx.DefaultText = "";
            this.OpenTaskTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OpenTaskTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OpenTaskTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OpenTaskTxtBx.DisabledState.Parent = this.OpenTaskTxtBx;
            this.OpenTaskTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OpenTaskTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OpenTaskTxtBx.FocusedState.Parent = this.OpenTaskTxtBx;
            this.OpenTaskTxtBx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OpenTaskTxtBx.ForeColor = System.Drawing.Color.Black;
            this.OpenTaskTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OpenTaskTxtBx.HoverState.Parent = this.OpenTaskTxtBx;
            this.OpenTaskTxtBx.Location = new System.Drawing.Point(82, 26);
            this.OpenTaskTxtBx.Name = "OpenTaskTxtBx";
            this.OpenTaskTxtBx.PasswordChar = '\0';
            this.OpenTaskTxtBx.PlaceholderText = "ex:chrome.exe";
            this.OpenTaskTxtBx.SelectedText = "";
            this.OpenTaskTxtBx.ShadowDecoration.Parent = this.OpenTaskTxtBx;
            this.OpenTaskTxtBx.Size = new System.Drawing.Size(366, 36);
            this.OpenTaskTxtBx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Open:";
            // 
            // RunTaskBtn
            // 
            this.RunTaskBtn.BorderThickness = 1;
            this.RunTaskBtn.CheckedState.Parent = this.RunTaskBtn;
            this.RunTaskBtn.CustomImages.Parent = this.RunTaskBtn;
            this.RunTaskBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RunTaskBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RunTaskBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RunTaskBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RunTaskBtn.DisabledState.Parent = this.RunTaskBtn;
            this.RunTaskBtn.FillColor = System.Drawing.Color.White;
            this.RunTaskBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RunTaskBtn.ForeColor = System.Drawing.Color.Black;
            this.RunTaskBtn.HoverState.Parent = this.RunTaskBtn;
            this.RunTaskBtn.Location = new System.Drawing.Point(318, 83);
            this.RunTaskBtn.Name = "RunTaskBtn";
            this.RunTaskBtn.ShadowDecoration.Parent = this.RunTaskBtn;
            this.RunTaskBtn.Size = new System.Drawing.Size(130, 28);
            this.RunTaskBtn.TabIndex = 4;
            this.RunTaskBtn.Text = "Run ";
            this.RunTaskBtn.Click += new System.EventHandler(this.RunTaskBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 136);
            this.Controls.Add(this.RunTaskBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenTaskTxtBx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Run";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox OpenTaskTxtBx;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button RunTaskBtn;
    }
}