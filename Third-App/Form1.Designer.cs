namespace Third_App
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
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonReporting = new System.Windows.Forms.Button();
            this.buttonLogging = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkOrchid;
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.buttonDashboard);
            this.panelMenu.Controls.Add(this.buttonReporting);
            this.panelMenu.Controls.Add(this.buttonLogging);
            this.panelMenu.Controls.Add(this.buttonSetting);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(205, 840);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 74);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDashboard.Image = global::Third_App.Properties.Resources.view_dashboard_outline;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(3, 83);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(200, 64);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "     DASHBOARD";
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonReporting
            // 
            this.buttonReporting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReporting.FlatAppearance.BorderSize = 0;
            this.buttonReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReporting.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReporting.ForeColor = System.Drawing.Color.Transparent;
            this.buttonReporting.Image = global::Third_App.Properties.Resources.file_chart;
            this.buttonReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReporting.Location = new System.Drawing.Point(3, 153);
            this.buttonReporting.Name = "buttonReporting";
            this.buttonReporting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonReporting.Size = new System.Drawing.Size(200, 64);
            this.buttonReporting.TabIndex = 2;
            this.buttonReporting.Text = "     REPORTING";
            this.buttonReporting.UseVisualStyleBackColor = true;
            this.buttonReporting.Click += new System.EventHandler(this.buttonReporting_Click);
            // 
            // buttonLogging
            // 
            this.buttonLogging.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogging.FlatAppearance.BorderSize = 0;
            this.buttonLogging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogging.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogging.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogging.Image = global::Third_App.Properties.Resources.clipboard_text_clock;
            this.buttonLogging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogging.Location = new System.Drawing.Point(3, 223);
            this.buttonLogging.Name = "buttonLogging";
            this.buttonLogging.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonLogging.Size = new System.Drawing.Size(200, 64);
            this.buttonLogging.TabIndex = 3;
            this.buttonLogging.Text = "     LOGGING";
            this.buttonLogging.UseVisualStyleBackColor = true;
            this.buttonLogging.Click += new System.EventHandler(this.buttonLogging_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSetting.Image = global::Third_App.Properties.Resources.cog_outline;
            this.buttonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.Location = new System.Drawing.Point(3, 293);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonSetting.Size = new System.Drawing.Size(200, 64);
            this.buttonSetting.TabIndex = 4;
            this.buttonSetting.Text = "     SETTING";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daffa\'s IoT Project";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1254, 840);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = " ";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonReporting;
        private System.Windows.Forms.Button buttonLogging;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Label label1;
    }
}

