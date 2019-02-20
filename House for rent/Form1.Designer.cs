namespace House_for_rent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radTown = new System.Windows.Forms.RadioButton();
            this.radSemiDetach = new System.Windows.Forms.RadioButton();
            this.radDetach = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radBath2_5 = new System.Windows.Forms.RadioButton();
            this.radBath2 = new System.Windows.Forms.RadioButton();
            this.radBath1_5 = new System.Windows.Forms.RadioButton();
            this.radBath1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radRm3 = new System.Windows.Forms.RadioButton();
            this.radRm4 = new System.Windows.Forms.RadioButton();
            this.radRm2 = new System.Windows.Forms.RadioButton();
            this.radRm1 = new System.Windows.Forms.RadioButton();
            this.lblThankYou = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLname);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buyer\'s Information";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(119, 95);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(162, 28);
            this.txtLname.TabIndex = 3;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(119, 43);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(162, 28);
            this.txtFname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "House For Rent";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radTown);
            this.groupBox2.Controls.Add(this.radSemiDetach);
            this.groupBox2.Controls.Add(this.radDetach);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(315, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 110);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type of Property";
            // 
            // radTown
            // 
            this.radTown.AutoSize = true;
            this.radTown.Location = new System.Drawing.Point(20, 78);
            this.radTown.Name = "radTown";
            this.radTown.Size = new System.Drawing.Size(73, 26);
            this.radTown.TabIndex = 2;
            this.radTown.TabStop = true;
            this.radTown.Text = "Town";
            this.radTown.UseVisualStyleBackColor = true;
            this.radTown.CheckedChanged += new System.EventHandler(this.radTown_CheckedChanged);
            // 
            // radSemiDetach
            // 
            this.radSemiDetach.AutoSize = true;
            this.radSemiDetach.Location = new System.Drawing.Point(20, 53);
            this.radSemiDetach.Name = "radSemiDetach";
            this.radSemiDetach.Size = new System.Drawing.Size(151, 26);
            this.radSemiDetach.TabIndex = 1;
            this.radSemiDetach.TabStop = true;
            this.radSemiDetach.Text = "Semi-Detached";
            this.radSemiDetach.UseVisualStyleBackColor = true;
            this.radSemiDetach.CheckedChanged += new System.EventHandler(this.radSemiDetach_CheckedChanged);
            // 
            // radDetach
            // 
            this.radDetach.AutoSize = true;
            this.radDetach.Location = new System.Drawing.Point(20, 30);
            this.radDetach.Name = "radDetach";
            this.radDetach.Size = new System.Drawing.Size(104, 26);
            this.radDetach.TabIndex = 0;
            this.radDetach.TabStop = true;
            this.radDetach.Text = "Detached";
            this.radDetach.UseVisualStyleBackColor = true;
            this.radDetach.CheckedChanged += new System.EventHandler(this.radDetach_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 221);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Beds and Baths";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radBath2_5);
            this.groupBox5.Controls.Add(this.radBath2);
            this.groupBox5.Controls.Add(this.radBath1_5);
            this.groupBox5.Controls.Add(this.radBath1);
            this.groupBox5.Location = new System.Drawing.Point(210, 45);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(120, 158);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "# of Baths";
            // 
            // radBath2_5
            // 
            this.radBath2_5.AutoSize = true;
            this.radBath2_5.Location = new System.Drawing.Point(23, 126);
            this.radBath2_5.Name = "radBath2_5";
            this.radBath2_5.Size = new System.Drawing.Size(53, 26);
            this.radBath2_5.TabIndex = 7;
            this.radBath2_5.TabStop = true;
            this.radBath2_5.Text = "2.5";
            this.radBath2_5.UseVisualStyleBackColor = true;
            // 
            // radBath2
            // 
            this.radBath2.AutoSize = true;
            this.radBath2.Location = new System.Drawing.Point(23, 94);
            this.radBath2.Name = "radBath2";
            this.radBath2.Size = new System.Drawing.Size(38, 26);
            this.radBath2.TabIndex = 7;
            this.radBath2.TabStop = true;
            this.radBath2.Text = "2";
            this.radBath2.UseVisualStyleBackColor = true;
            // 
            // radBath1_5
            // 
            this.radBath1_5.AutoSize = true;
            this.radBath1_5.Location = new System.Drawing.Point(22, 62);
            this.radBath1_5.Name = "radBath1_5";
            this.radBath1_5.Size = new System.Drawing.Size(53, 26);
            this.radBath1_5.TabIndex = 6;
            this.radBath1_5.TabStop = true;
            this.radBath1_5.Text = "1.5";
            this.radBath1_5.UseVisualStyleBackColor = true;
            // 
            // radBath1
            // 
            this.radBath1.AutoSize = true;
            this.radBath1.Location = new System.Drawing.Point(23, 30);
            this.radBath1.Name = "radBath1";
            this.radBath1.Size = new System.Drawing.Size(38, 26);
            this.radBath1.TabIndex = 5;
            this.radBath1.TabStop = true;
            this.radBath1.Text = "1";
            this.radBath1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radRm3);
            this.groupBox4.Controls.Add(this.radRm4);
            this.groupBox4.Controls.Add(this.radRm2);
            this.groupBox4.Controls.Add(this.radRm1);
            this.groupBox4.Location = new System.Drawing.Point(23, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 158);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "# of Bedrooms";
            // 
            // radRm3
            // 
            this.radRm3.AutoSize = true;
            this.radRm3.Location = new System.Drawing.Point(26, 94);
            this.radRm3.Name = "radRm3";
            this.radRm3.Size = new System.Drawing.Size(100, 26);
            this.radRm3.TabIndex = 7;
            this.radRm3.TabStop = true;
            this.radRm3.Text = "3 Rooms";
            this.radRm3.UseVisualStyleBackColor = true;
            // 
            // radRm4
            // 
            this.radRm4.AutoSize = true;
            this.radRm4.Location = new System.Drawing.Point(26, 126);
            this.radRm4.Name = "radRm4";
            this.radRm4.Size = new System.Drawing.Size(100, 26);
            this.radRm4.TabIndex = 5;
            this.radRm4.Text = "4 Rooms";
            this.radRm4.UseVisualStyleBackColor = true;
            // 
            // radRm2
            // 
            this.radRm2.AutoSize = true;
            this.radRm2.Location = new System.Drawing.Point(26, 62);
            this.radRm2.Name = "radRm2";
            this.radRm2.Size = new System.Drawing.Size(100, 26);
            this.radRm2.TabIndex = 6;
            this.radRm2.TabStop = true;
            this.radRm2.Text = "2 Rooms";
            this.radRm2.UseVisualStyleBackColor = true;
            // 
            // radRm1
            // 
            this.radRm1.AutoSize = true;
            this.radRm1.Location = new System.Drawing.Point(26, 30);
            this.radRm1.Name = "radRm1";
            this.radRm1.Size = new System.Drawing.Size(92, 26);
            this.radRm1.TabIndex = 5;
            this.radRm1.TabStop = true;
            this.radRm1.Text = "1 Room";
            this.radRm1.UseVisualStyleBackColor = true;
            // 
            // lblThankYou
            // 
            this.lblThankYou.AutoSize = true;
            this.lblThankYou.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThankYou.Location = new System.Drawing.Point(389, 261);
            this.lblThankYou.Name = "lblThankYou";
            this.lblThankYou.Size = new System.Drawing.Size(0, 17);
            this.lblThankYou.TabIndex = 5;
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(611, 84);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(128, 37);
            this.btnBuy.TabIndex = 6;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(611, 127);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(611, 169);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 41);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lblThankYou);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radTown;
        private System.Windows.Forms.RadioButton radSemiDetach;
        private System.Windows.Forms.RadioButton radDetach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radBath2_5;
        private System.Windows.Forms.RadioButton radBath2;
        private System.Windows.Forms.RadioButton radBath1_5;
        private System.Windows.Forms.RadioButton radBath1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radRm3;
        private System.Windows.Forms.RadioButton radRm4;
        private System.Windows.Forms.RadioButton radRm2;
        private System.Windows.Forms.RadioButton radRm1;
        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

