
namespace Task_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeOnUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideWhenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFullAccountNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHistoryForAllProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupByTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskLstBx = new System.Windows.Forms.ListBox();
            this.EndTaskBtn = new Guna.UI2.WinForms.Guna2Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runNewTaskToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // runNewTaskToolStripMenuItem
            // 
            this.runNewTaskToolStripMenuItem.Name = "runNewTaskToolStripMenuItem";
            this.runNewTaskToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.runNewTaskToolStripMenuItem.Text = "Run new task";
            this.runNewTaskToolStripMenuItem.Click += new System.EventHandler(this.runNewTaskToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysTopToolStripMenuItem,
            this.minimizeOnUseToolStripMenuItem,
            this.hideWhenToolStripMenuItem,
            this.setDefaultTabToolStripMenuItem,
            this.showFullAccountNameToolStripMenuItem,
            this.showHistoryForAllProcessToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // alwaysTopToolStripMenuItem
            // 
            this.alwaysTopToolStripMenuItem.Name = "alwaysTopToolStripMenuItem";
            this.alwaysTopToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.alwaysTopToolStripMenuItem.Text = "Always Top";
            // 
            // minimizeOnUseToolStripMenuItem
            // 
            this.minimizeOnUseToolStripMenuItem.Name = "minimizeOnUseToolStripMenuItem";
            this.minimizeOnUseToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.minimizeOnUseToolStripMenuItem.Text = "Minimize on use";
            // 
            // hideWhenToolStripMenuItem
            // 
            this.hideWhenToolStripMenuItem.Name = "hideWhenToolStripMenuItem";
            this.hideWhenToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.hideWhenToolStripMenuItem.Text = "Hide when minimized";
            // 
            // setDefaultTabToolStripMenuItem
            // 
            this.setDefaultTabToolStripMenuItem.Name = "setDefaultTabToolStripMenuItem";
            this.setDefaultTabToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.setDefaultTabToolStripMenuItem.Text = "Set default tab";
            // 
            // showFullAccountNameToolStripMenuItem
            // 
            this.showFullAccountNameToolStripMenuItem.Name = "showFullAccountNameToolStripMenuItem";
            this.showFullAccountNameToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.showFullAccountNameToolStripMenuItem.Text = "Show full account name";
            // 
            // showHistoryForAllProcessToolStripMenuItem
            // 
            this.showHistoryForAllProcessToolStripMenuItem.Name = "showHistoryForAllProcessToolStripMenuItem";
            this.showHistoryForAllProcessToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.showHistoryForAllProcessToolStripMenuItem.Text = "Show history for all process";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem1,
            this.updateSpeedToolStripMenuItem,
            this.groupByTypeToolStripMenuItem,
            this.expandAllToolStripMenuItem,
            this.collapseAllToolStripMenuItem});
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.refreshToolStripMenuItem.Text = "View";
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.refreshToolStripMenuItem1.Text = "Refresh now";
            // 
            // updateSpeedToolStripMenuItem
            // 
            this.updateSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.lowToolStripMenuItem,
            this.pausedToolStripMenuItem});
            this.updateSpeedToolStripMenuItem.Name = "updateSpeedToolStripMenuItem";
            this.updateSpeedToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.updateSpeedToolStripMenuItem.Text = "Update speed";
            // 
            // highToolStripMenuItem
            // 
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            this.highToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.highToolStripMenuItem.Text = "High ";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.normalToolStripMenuItem.Text = "Normal";
            // 
            // lowToolStripMenuItem
            // 
            this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
            this.lowToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.lowToolStripMenuItem.Text = "Low ";
            // 
            // pausedToolStripMenuItem
            // 
            this.pausedToolStripMenuItem.Name = "pausedToolStripMenuItem";
            this.pausedToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.pausedToolStripMenuItem.Text = "Paused";
            // 
            // groupByTypeToolStripMenuItem
            // 
            this.groupByTypeToolStripMenuItem.Name = "groupByTypeToolStripMenuItem";
            this.groupByTypeToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.groupByTypeToolStripMenuItem.Text = "Group by type";
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.expandAllToolStripMenuItem.Text = "Expand all";
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.collapseAllToolStripMenuItem.Text = "Collapse all";
            // 
            // TaskLstBx
            // 
            this.TaskLstBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaskLstBx.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TaskLstBx.FormattingEnabled = true;
            this.TaskLstBx.ItemHeight = 16;
            this.TaskLstBx.Location = new System.Drawing.Point(13, 32);
            this.TaskLstBx.Name = "TaskLstBx";
            this.TaskLstBx.Size = new System.Drawing.Size(775, 370);
            this.TaskLstBx.TabIndex = 2;
            // 
            // EndTaskBtn
            // 
            this.EndTaskBtn.BorderThickness = 1;
            this.EndTaskBtn.CheckedState.Parent = this.EndTaskBtn;
            this.EndTaskBtn.CustomImages.Parent = this.EndTaskBtn;
            this.EndTaskBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EndTaskBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EndTaskBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EndTaskBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EndTaskBtn.DisabledState.Parent = this.EndTaskBtn;
            this.EndTaskBtn.FillColor = System.Drawing.Color.White;
            this.EndTaskBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EndTaskBtn.ForeColor = System.Drawing.Color.Black;
            this.EndTaskBtn.HoverState.Parent = this.EndTaskBtn;
            this.EndTaskBtn.Location = new System.Drawing.Point(658, 410);
            this.EndTaskBtn.Name = "EndTaskBtn";
            this.EndTaskBtn.ShadowDecoration.Parent = this.EndTaskBtn;
            this.EndTaskBtn.Size = new System.Drawing.Size(130, 28);
            this.EndTaskBtn.TabIndex = 3;
            this.EndTaskBtn.Text = "End Task";
            this.EndTaskBtn.Click += new System.EventHandler(this.EndTaskBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndTaskBtn);
            this.Controls.Add(this.TaskLstBx);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runNewTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeOnUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideWhenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showFullAccountNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHistoryForAllProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupByTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ListBox TaskLstBx;
        private Guna.UI2.WinForms.Guna2Button EndTaskBtn;
    }
}

