namespace Monopoly_Banker
{
    partial class Disaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disaster));
            this.lblDisaster = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p1_view = new System.Windows.Forms.Button();
            this.p1_list = new System.Windows.Forms.ListBox();
            this.p1_name = new System.Windows.Forms.Label();
            this.p1_icon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.p2_view = new System.Windows.Forms.Button();
            this.p2_list = new System.Windows.Forms.ListBox();
            this.p2_name = new System.Windows.Forms.Label();
            this.p2_icon = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.p3_view = new System.Windows.Forms.Button();
            this.p3_list = new System.Windows.Forms.ListBox();
            this.p3_name = new System.Windows.Forms.Label();
            this.p3_icon = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.p4_view = new System.Windows.Forms.Button();
            this.p4_list = new System.Windows.Forms.ListBox();
            this.p4_name = new System.Windows.Forms.Label();
            this.p4_icon = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.p5_view = new System.Windows.Forms.Button();
            this.p5_list = new System.Windows.Forms.ListBox();
            this.p5_name = new System.Windows.Forms.Label();
            this.p5_icon = new System.Windows.Forms.PictureBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p1_icon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2_icon)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p3_icon)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p4_icon)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p5_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisaster
            // 
            this.lblDisaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisaster.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisaster.Location = new System.Drawing.Point(12, 9);
            this.lblDisaster.Name = "lblDisaster";
            this.lblDisaster.Size = new System.Drawing.Size(1039, 45);
            this.lblDisaster.TabIndex = 0;
            this.lblDisaster.Text = "A [disaster] has occured.";
            this.lblDisaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.p1_view);
            this.panel1.Controls.Add(this.p1_list);
            this.panel1.Controls.Add(this.p1_name);
            this.panel1.Controls.Add(this.p1_icon);
            this.panel1.Location = new System.Drawing.Point(5, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 266);
            this.panel1.TabIndex = 1;
            // 
            // p1_view
            // 
            this.p1_view.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p1_view.Location = new System.Drawing.Point(3, 230);
            this.p1_view.Name = "p1_view";
            this.p1_view.Size = new System.Drawing.Size(197, 31);
            this.p1_view.TabIndex = 9;
            this.p1_view.Text = "View List";
            this.p1_view.UseVisualStyleBackColor = true;
            this.p1_view.Click += new System.EventHandler(this.view_Click);
            // 
            // p1_list
            // 
            this.p1_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(208)))));
            this.p1_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1_list.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_list.FormattingEnabled = true;
            this.p1_list.IntegralHeight = false;
            this.p1_list.ItemHeight = 17;
            this.p1_list.Location = new System.Drawing.Point(7, 80);
            this.p1_list.Name = "p1_list";
            this.p1_list.Size = new System.Drawing.Size(190, 144);
            this.p1_list.TabIndex = 4;
            // 
            // p1_name
            // 
            this.p1_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1_name.Location = new System.Drawing.Point(3, 3);
            this.p1_name.Name = "p1_name";
            this.p1_name.Size = new System.Drawing.Size(197, 20);
            this.p1_name.TabIndex = 3;
            this.p1_name.Text = "Name";
            this.p1_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1_icon
            // 
            this.p1_icon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p1_icon.Image = global::Monopoly_Banker.Properties.Resources.icon_car;
            this.p1_icon.Location = new System.Drawing.Point(76, 26);
            this.p1_icon.Name = "p1_icon";
            this.p1_icon.Size = new System.Drawing.Size(48, 48);
            this.p1_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1_icon.TabIndex = 2;
            this.p1_icon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.p2_view);
            this.panel2.Controls.Add(this.p2_list);
            this.panel2.Controls.Add(this.p2_name);
            this.panel2.Controls.Add(this.p2_icon);
            this.panel2.Location = new System.Drawing.Point(216, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 266);
            this.panel2.TabIndex = 2;
            // 
            // p2_view
            // 
            this.p2_view.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p2_view.Location = new System.Drawing.Point(3, 230);
            this.p2_view.Name = "p2_view";
            this.p2_view.Size = new System.Drawing.Size(197, 31);
            this.p2_view.TabIndex = 10;
            this.p2_view.Text = "View List";
            this.p2_view.UseVisualStyleBackColor = true;
            this.p2_view.Click += new System.EventHandler(this.view_Click);
            // 
            // p2_list
            // 
            this.p2_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p2_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(208)))));
            this.p2_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2_list.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_list.FormattingEnabled = true;
            this.p2_list.IntegralHeight = false;
            this.p2_list.ItemHeight = 17;
            this.p2_list.Location = new System.Drawing.Point(7, 80);
            this.p2_list.Name = "p2_list";
            this.p2_list.Size = new System.Drawing.Size(190, 144);
            this.p2_list.TabIndex = 4;
            // 
            // p2_name
            // 
            this.p2_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p2_name.Location = new System.Drawing.Point(3, 3);
            this.p2_name.Name = "p2_name";
            this.p2_name.Size = new System.Drawing.Size(197, 20);
            this.p2_name.TabIndex = 3;
            this.p2_name.Text = "Name";
            this.p2_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2_icon
            // 
            this.p2_icon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p2_icon.Image = global::Monopoly_Banker.Properties.Resources.icon_car;
            this.p2_icon.Location = new System.Drawing.Point(76, 26);
            this.p2_icon.Name = "p2_icon";
            this.p2_icon.Size = new System.Drawing.Size(48, 48);
            this.p2_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2_icon.TabIndex = 2;
            this.p2_icon.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.p3_view);
            this.panel3.Controls.Add(this.p3_list);
            this.panel3.Controls.Add(this.p3_name);
            this.panel3.Controls.Add(this.p3_icon);
            this.panel3.Location = new System.Drawing.Point(427, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 266);
            this.panel3.TabIndex = 5;
            // 
            // p3_view
            // 
            this.p3_view.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p3_view.Location = new System.Drawing.Point(3, 230);
            this.p3_view.Name = "p3_view";
            this.p3_view.Size = new System.Drawing.Size(197, 31);
            this.p3_view.TabIndex = 11;
            this.p3_view.Text = "View List";
            this.p3_view.UseVisualStyleBackColor = true;
            this.p3_view.Click += new System.EventHandler(this.view_Click);
            // 
            // p3_list
            // 
            this.p3_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p3_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(208)))));
            this.p3_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p3_list.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3_list.FormattingEnabled = true;
            this.p3_list.IntegralHeight = false;
            this.p3_list.ItemHeight = 17;
            this.p3_list.Location = new System.Drawing.Point(7, 80);
            this.p3_list.Name = "p3_list";
            this.p3_list.Size = new System.Drawing.Size(190, 144);
            this.p3_list.TabIndex = 4;
            // 
            // p3_name
            // 
            this.p3_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p3_name.Location = new System.Drawing.Point(3, 3);
            this.p3_name.Name = "p3_name";
            this.p3_name.Size = new System.Drawing.Size(197, 20);
            this.p3_name.TabIndex = 3;
            this.p3_name.Text = "Name";
            this.p3_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p3_icon
            // 
            this.p3_icon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p3_icon.Image = global::Monopoly_Banker.Properties.Resources.icon_car;
            this.p3_icon.Location = new System.Drawing.Point(76, 26);
            this.p3_icon.Name = "p3_icon";
            this.p3_icon.Size = new System.Drawing.Size(48, 48);
            this.p3_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3_icon.TabIndex = 2;
            this.p3_icon.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.p4_view);
            this.panel4.Controls.Add(this.p4_list);
            this.panel4.Controls.Add(this.p4_name);
            this.panel4.Controls.Add(this.p4_icon);
            this.panel4.Location = new System.Drawing.Point(638, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 266);
            this.panel4.TabIndex = 6;
            // 
            // p4_view
            // 
            this.p4_view.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p4_view.Location = new System.Drawing.Point(3, 230);
            this.p4_view.Name = "p4_view";
            this.p4_view.Size = new System.Drawing.Size(197, 31);
            this.p4_view.TabIndex = 10;
            this.p4_view.Text = "View List";
            this.p4_view.UseVisualStyleBackColor = true;
            this.p4_view.Click += new System.EventHandler(this.view_Click);
            // 
            // p4_list
            // 
            this.p4_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p4_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(208)))));
            this.p4_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p4_list.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4_list.FormattingEnabled = true;
            this.p4_list.IntegralHeight = false;
            this.p4_list.ItemHeight = 17;
            this.p4_list.Location = new System.Drawing.Point(7, 80);
            this.p4_list.Name = "p4_list";
            this.p4_list.Size = new System.Drawing.Size(190, 144);
            this.p4_list.TabIndex = 4;
            // 
            // p4_name
            // 
            this.p4_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p4_name.Location = new System.Drawing.Point(3, 3);
            this.p4_name.Name = "p4_name";
            this.p4_name.Size = new System.Drawing.Size(197, 20);
            this.p4_name.TabIndex = 3;
            this.p4_name.Text = "Name";
            this.p4_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p4_icon
            // 
            this.p4_icon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p4_icon.Image = global::Monopoly_Banker.Properties.Resources.icon_car;
            this.p4_icon.Location = new System.Drawing.Point(76, 26);
            this.p4_icon.Name = "p4_icon";
            this.p4_icon.Size = new System.Drawing.Size(48, 48);
            this.p4_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4_icon.TabIndex = 2;
            this.p4_icon.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.p5_view);
            this.panel5.Controls.Add(this.p5_list);
            this.panel5.Controls.Add(this.p5_name);
            this.panel5.Controls.Add(this.p5_icon);
            this.panel5.Location = new System.Drawing.Point(849, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 266);
            this.panel5.TabIndex = 7;
            // 
            // p5_view
            // 
            this.p5_view.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p5_view.Location = new System.Drawing.Point(3, 230);
            this.p5_view.Name = "p5_view";
            this.p5_view.Size = new System.Drawing.Size(197, 31);
            this.p5_view.TabIndex = 10;
            this.p5_view.Text = "View List";
            this.p5_view.UseVisualStyleBackColor = true;
            this.p5_view.Click += new System.EventHandler(this.view_Click);
            // 
            // p5_list
            // 
            this.p5_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p5_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(208)))));
            this.p5_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p5_list.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p5_list.FormattingEnabled = true;
            this.p5_list.IntegralHeight = false;
            this.p5_list.ItemHeight = 17;
            this.p5_list.Location = new System.Drawing.Point(7, 80);
            this.p5_list.Name = "p5_list";
            this.p5_list.Size = new System.Drawing.Size(190, 144);
            this.p5_list.TabIndex = 4;
            // 
            // p5_name
            // 
            this.p5_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p5_name.Location = new System.Drawing.Point(3, 3);
            this.p5_name.Name = "p5_name";
            this.p5_name.Size = new System.Drawing.Size(197, 20);
            this.p5_name.TabIndex = 3;
            this.p5_name.Text = "Name";
            this.p5_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p5_icon
            // 
            this.p5_icon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.p5_icon.Image = global::Monopoly_Banker.Properties.Resources.icon_car;
            this.p5_icon.Location = new System.Drawing.Point(76, 26);
            this.p5_icon.Name = "p5_icon";
            this.p5_icon.Size = new System.Drawing.Size(48, 48);
            this.p5_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p5_icon.TabIndex = 2;
            this.p5_icon.TabStop = false;
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnComplete.Location = new System.Drawing.Point(375, 356);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(307, 40);
            this.btnComplete.TabIndex = 8;
            this.btnComplete.Text = "Complete Disaster";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // Disaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1058, 412);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDisaster);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Disaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Disaster";
            this.Load += new System.EventHandler(this.Disaster_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p1_icon)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p2_icon)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p3_icon)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p4_icon)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p5_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisaster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox p1_list;
        private System.Windows.Forms.Label p1_name;
        private System.Windows.Forms.PictureBox p1_icon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox p2_list;
        private System.Windows.Forms.Label p2_name;
        private System.Windows.Forms.PictureBox p2_icon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox p3_list;
        private System.Windows.Forms.Label p3_name;
        private System.Windows.Forms.PictureBox p3_icon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox p4_list;
        private System.Windows.Forms.Label p4_name;
        private System.Windows.Forms.PictureBox p4_icon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox p5_list;
        private System.Windows.Forms.Label p5_name;
        private System.Windows.Forms.PictureBox p5_icon;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button p1_view;
        private System.Windows.Forms.Button p2_view;
        private System.Windows.Forms.Button p3_view;
        private System.Windows.Forms.Button p4_view;
        private System.Windows.Forms.Button p5_view;
    }
}