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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonReporting = new System.Windows.Forms.Button();
            this.buttonLogging = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(199, 840);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 74);
            this.panelLogo.TabIndex = 0;
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
            this.buttonDashboard.Location = new System.Drawing.Point(0, 74);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(0);
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
            this.buttonReporting.Location = new System.Drawing.Point(0, 138);
            this.buttonReporting.Margin = new System.Windows.Forms.Padding(0);
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
            this.buttonLogging.Location = new System.Drawing.Point(0, 202);
            this.buttonLogging.Margin = new System.Windows.Forms.Padding(0);
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
            this.buttonSetting.Location = new System.Drawing.Point(0, 266);
            this.buttonSetting.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonSetting.Size = new System.Drawing.Size(200, 64);
            this.buttonSetting.TabIndex = 4;
            this.buttonSetting.Text = "     SETTING";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // panelTopBar
            // 
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(199, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1055, 29);
            this.panelTopBar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(526, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 108);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(865, 235);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(104, 73);
            this.label3.TabIndex = 4;
            this.label3.Text = "°C";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1254, 840);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonReporting;
        private System.Windows.Forms.Button buttonLogging;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

