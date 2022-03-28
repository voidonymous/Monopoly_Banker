namespace Monopoly_Banker
{
    partial class Auction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auction));
            this.panel1 = new System.Windows.Forms.Panel();
            this.p1_out = new System.Windows.Forms.PictureBox();
            this.p1_amount = new System.Windows.Forms.TextBox();
            this.p1_name = new System.Windows.Forms.Label();
            this.p1_icon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.p2_out = new System.Windows.Forms.PictureBox();
            this.p2_amount = new System.Windows.Forms.TextBox();
            this.p2_name = new System.Windows.Forms.Label();
            this.p2_icon = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.p3_out = new System.Windows.Forms.PictureBox();
            this.p3_amount = new System.Windows.Forms.TextBox();
            this.p3_name = new System.Windows.Forms.Label();
            this.p3_icon = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.p4_out = new System.Windows.Forms.PictureBox();
            this.p4_amount = new System.Windows.Forms.TextBox();
            this.p4_name = new System.Windows.Forms.Label();
            this.p4_icon = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.p5_out = new System.Windows.Forms.PictureBox();
            this.p5_amount = new System.Windows.Forms.TextBox();
            this.p5_name = new System.Windows.Forms.Label();
            this.p5_icon = new System.Windows.Forms.PictureBox();
            this.pbx_auction = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_finish = new System.Windows.Forms.Button();
            this.lbl_current_value = new System.Windows.Forms.Label();
            this.lbx_history = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p1_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1_icon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_icon)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p3_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3_icon)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p4_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4_icon)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p5_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_auction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.p1_out);
            this.panel1.Controls.Add(this.p1_amount);
            this.panel1.Controls.Add(this.p1_name);
            this.panel1.Controls.Add(this.p1_icon);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 115);
            this.panel1.TabIndex = 0;
            // 
            // p1_out
            // 
            this.p1_out.Image = global::Monopoly_Banker.Properties.Resources.close;
            this.p1_out.Location = new System.Drawing.Point(76, 43);
            this.p1_out.Name = "p1_out";
            this.p1_out.Size = new System.Drawing.Size(16, 16);
            this.p1_out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1_out.TabIndex = 5;
            this.p1_out.TabStop = false;
            this.p1_out.Click += new System.EventHandler(this.out_Click);
            // 
            // p1_amount
            // 
            this.p1_amount.Location = new System.Drawing.Point(7, 80);
            this.p1_amount.Name = "p1_amount";
            this.p1_amount.Size = new System.Drawing.Size(80, 26);
            this.p1_amount.TabIndex = 4;
            this.p1_amount.Text = "0";
            this.p1_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p1_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.amount_KeyDown);
            // 
            // p1_name
            // 
            this.p1_name.Location = new System.Drawing.Point(3, 3);
            this.p1_name.Name = "p1_name";
            this.p1_name.Size = new System.Drawing.Size(89, 20);
            this.p1_name.TabIndex = 3;
            this.p1_name.Text = "Name";
            this.p1_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1_icon
            // 
            this.p1_icon.Image = global::Monopoly_Banker.Properties.Resources.icon_car;
            this.p1_icon.Location = new System.Drawing.Point(24, 26);
            this.p1_icon.Name = "p1_icon";
            this.p1_icon.Size = new System.Drawing.Size(48, 48);
            this.p1_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1_icon.TabIndex = 2;
            this.p1_icon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.p2_out);
            this.panel2.Controls.Add(this.p2_amount);
            this.panel2.Controls.Add(this.p2_name);
            this.panel2.Controls.Add(this.p2_icon);
            this.panel2.Location = new System.Drawing.Point(12, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 115);
            this.panel2.TabIndex = 1;
            // 
            // p2_out
            // 
            this.p2_out.Image = global::Monopoly_Banker.Properties.Resources.close;
            this.p2_out.Location = new System.Drawing.Point(76, 44);
            this.p2_out.Name = "p2_out";
            this.p2_out.Size = new System.Drawing.Size(16, 16);
            this.p2_out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2_out.TabIndex = 10;
            this.p2_out.TabStop = false;
            this.p2_out.Click += new System.EventHandler(this.out_Click);
            // 
            // p2_amount
            // 
            this.p2_amount.Location = new System.Drawing.Point(7, 80);
            this.p2_amount.Name = "p2_amount";
            this.p2_amount.Size = new System.Drawing.Size(80, 26);
            this.p2_amount.TabIndex = 4;
            this.p2_amount.Text = "0";
            this.p2_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p2_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.amount_KeyDown);
            // 
            // p2_name
            // 
            this.p2_name.Location = new System.Drawing.Point(3, 3);
            this.p2_name.Name = "p2_name";
            this.p2_name.Size = new System.Drawing.Size(89, 20);
            this.p2_name.TabIndex = 3;
            this.p2_name.Text = "Name";
            this.p2_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2_icon
            // 
            this.p2_icon.Image = global::Monopoly_Banker.Properties.Resources.icon_car;
            this.p2_icon.Location = new System.Drawing.Point(24, 26);
            this.p2_icon.Name = "p2_icon";
            this.p2_icon.Size = new System.Drawing.Size(48, 48);
            this.p2_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2_icon.TabIndex = 2;
            this.p2_icon.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.p3_out);
            this.panel3.Controls.Add(this.p3_amount);
            this.panel3.Controls.Add(this.p3_name);
            this.panel3.Controls.Add(this.p3_icon);
            this.panel3.Location = new System.Drawing.Point(12, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 115);
            this.panel3.TabIndex = 5;
            this.panel3.Visible = false;
            // 
            // p3_out
            // 
            this.p3_out.Image = global::Monopoly_Banker.Properties.Resources.close;
            this.p3_out.Location = new System.Drawing.Point(76, 43);
            this.p3_out.Name = "p3_out";
            this.p3_out.Size = new System.Drawing.Size(16, 16);
            this.p3_out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3_out.TabIndex = 10;
            this.p3_out.TabStop = false;
            this.p3_out.Click += new System.EventHandler(this.out_Click);
            // 
            // p3_amount
            // 
            this.p3_amount.Location = new System.Drawing.Point(7, 80);
            this.p3_amount.Name = "p3_amount";
            this.p3_amount.Size = new System.Drawing.Size(80, 26);
            this.p3_amount.TabIndex = 4;
            this.p3_amount.Text = "0";
            this.p3_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p3_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.amount_KeyDown);
            // 
            // p3_name
            // 
            this.p3_name.Location = new System.Drawing.Point(3, 3);
            this.p3_name.Name = "p3_name";
            this.p3_name.Size = new System.Drawing.Size(89, 20);
            this.p3_name.TabIndex = 3;
            this.p3_name.Text = "Name";
            this.p3_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p3_icon
            // 
            this.p3_icon.Image = global::Monopoly_Banker.Properties.Resources.icon_car;
            this.p3_icon.Location = new System.Drawing.Point(24, 26);
            this.p3_icon.Name = "p3_icon";
            this.p3_icon.Size = new System.Drawing.Size(48, 48);
            this.p3_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3_icon.TabIndex = 2;
            this.p3_icon.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.p4_out);
            this.panel4.Controls.Add(this.p4_amount);
            this.panel4.Controls.Add(this.p4_name);
            this.panel4.Controls.Add(this.p4_icon);
            this.panel4.Location = new System.Drawing.Point(12, 375);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(95, 115);
            this.panel4.TabIndex = 6;
            this.panel4.Visible = false;
            // 
            // p4_out
            // 
            this.p4_out.Image = global::Monopoly_Banker.Properties.Resources.close;
            this.p4_out.Location = new System.Drawing.Point(76, 43);
            this.p4_out.Name = "p4_out";
            this.p4_out.Size = new System.Drawing.Size(16, 16);
            this.p4_out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4_out.TabIndex = 10;
            this.p4_out.TabStop = false;
            this.p4_out.Click += new System.EventHandler(this.out_Click);
            // 
            // p4_amount
            // 
            this.p4_amount.Location = new System.Drawing.Point(7, 80);
            this.p4_amount.Name = "p4_amount";
            this.p4_amount.Size = new System.Drawing.Size(80, 26);
            this.p4_amount.TabIndex = 4;
            this.p4_amount.Text = "0";
            this.p4_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p4_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.amount_KeyDown);
            // 
            // p4_name
            // 
            this.p4_name.Location = new System.Drawing.Point(3, 3);
            this.p4_name.Name = "p4_name";
            this.p4_name.Size = new System.Drawing.Size(89, 20);
            this.p4_name.TabIndex = 3;
            this.p4_name.Text = "Name";
            this.p4_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p4_icon
            // 
            this.p4_icon.Image = global::Monopoly_Banker.Properties.Resources.icon_car;
            this.p4_icon.Location = new System.Drawing.Point(24, 26);
            this.p4_icon.Name = "p4_icon";
            this.p4_icon.Size = new System.Drawing.Size(48, 48);
            this.p4_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4_icon.TabIndex = 2;
            this.p4_icon.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.p5_out);
            this.panel5.Controls.Add(this.p5_amount);
            this.panel5.Controls.Add(this.p5_name);
            this.panel5.Controls.Add(this.p5_icon);
            this.panel5.Location = new System.Drawing.Point(12, 496);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(95, 115);
            this.panel5.TabIndex = 5;
            this.panel5.Visible = false;
            // 
            // p5_out
            // 
            this.p5_out.Image = global::Monopoly_Banker.Properties.Resources.close;
            this.p5_out.Location = new System.Drawing.Point(76, 43);
            this.p5_out.Name = "p5_out";
            this.p5_out.Size = new System.Drawing.Size(16, 16);
            this.p5_out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p5_out.TabIndex = 10;
            this.p5_out.TabStop = false;
            this.p5_out.Click += new System.EventHandler(this.out_Click);
            // 
            // p5_amount
            // 
            this.p5_amount.Location = new System.Drawing.Point(7, 80);
            this.p5_amount.Name = "p5_amount";
            this.p5_amount.Size = new System.Drawing.Size(80, 26);
            this.p5_amount.TabIndex = 4;
            this.p5_amount.Text = "0";
            this.p5_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p5_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.amount_KeyDown);
            // 
            // p5_name
            // 
            this.p5_name.Location = new System.Drawing.Point(3, 3);
            this.p5_name.Name = "p5_name";
            this.p5_name.Size = new System.Drawing.Size(89, 20);
            this.p5_name.TabIndex = 3;
            this.p5_name.Text = "Name";
            this.p5_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p5_icon
            // 
            this.p5_icon.Image = global::Monopoly_Banker.Properties.Resources.icon_car;
            this.p5_icon.Location = new System.Drawing.Point(24, 26);
            this.p5_icon.Name = "p5_icon";
            this.p5_icon.Size = new System.Drawing.Size(48, 48);
            this.p5_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p5_icon.TabIndex = 2;
            this.p5_icon.TabStop = false;
            // 
            // pbx_auction
            // 
            this.pbx_auction.Image = global::Monopoly_Banker.Properties.Resources.house;
            this.pbx_auction.Location = new System.Drawing.Point(211, 15);
            this.pbx_auction.Name = "pbx_auction";
            this.pbx_auction.Size = new System.Drawing.Size(48, 48);
            this.pbx_auction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_auction.TabIndex = 7;
            this.pbx_auction.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current Value:";
            // 
            // btn_finish
            // 
            this.btn_finish.Location = new System.Drawing.Point(159, 188);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(141, 35);
            this.btn_finish.TabIndex = 9;
            this.btn_finish.Text = "Finish Auction";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // lbl_current_value
            // 
            this.lbl_current_value.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_current_value.Location = new System.Drawing.Point(174, 123);
            this.lbl_current_value.Name = "lbl_current_value";
            this.lbl_current_value.Size = new System.Drawing.Size(115, 36);
            this.lbl_current_value.TabIndex = 10;
            this.lbl_current_value.Text = "$0";
            this.lbl_current_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbx_history
            // 
            this.lbx_history.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_history.FormattingEnabled = true;
            this.lbx_history.IntegralHeight = false;
            this.lbx_history.ItemHeight = 17;
            this.lbx_history.Location = new System.Drawing.Point(159, 245);
            this.lbx_history.Name = "lbx_history";
            this.lbx_history.Size = new System.Drawing.Size(141, 366);
            this.lbx_history.TabIndex = 11;
            // 
            // Auction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(351, 622);
            this.Controls.Add(this.lbx_history);
            this.Controls.Add(this.lbl_current_value);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbx_auction);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(367, 661);
            this.MinimumSize = new System.Drawing.Size(367, 661);
            this.Name = "Auction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auction";
            this.Load += new System.EventHandler(this.Auction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p1_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1_icon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_icon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p3_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3_icon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p4_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4_icon)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p5_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_auction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox p1_out;
        private System.Windows.Forms.TextBox p1_amount;
        private System.Windows.Forms.Label p1_name;
        private System.Windows.Forms.PictureBox p1_icon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox p2_out;
        private System.Windows.Forms.TextBox p2_amount;
        private System.Windows.Forms.Label p2_name;
        private System.Windows.Forms.PictureBox p2_icon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox p3_out;
        private System.Windows.Forms.TextBox p3_amount;
        private System.Windows.Forms.Label p3_name;
        private System.Windows.Forms.PictureBox p3_icon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox p4_out;
        private System.Windows.Forms.TextBox p4_amount;
        private System.Windows.Forms.Label p4_name;
        private System.Windows.Forms.PictureBox p4_icon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox p5_out;
        private System.Windows.Forms.TextBox p5_amount;
        private System.Windows.Forms.Label p5_name;
        private System.Windows.Forms.PictureBox p5_icon;
        private System.Windows.Forms.PictureBox pbx_auction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Label lbl_current_value;
        private System.Windows.Forms.ListBox lbx_history;
    }
}