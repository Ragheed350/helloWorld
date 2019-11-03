namespace Win
{
    partial class Delete_Doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Doctors));
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.btt_del = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rabu_ret = new System.Windows.Forms.RadioButton();
            this.rabu_tra = new System.Windows.Forms.RadioButton();
            this.rabu_reg = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Name :\r\n";
            // 
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(175, 185);
            this.txtb_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(182, 26);
            this.txtb_name.TabIndex = 1;
            // 
            // btt_del
            // 
            this.btt_del.Location = new System.Drawing.Point(175, 230);
            this.btt_del.Name = "btt_del";
            this.btt_del.Size = new System.Drawing.Size(182, 48);
            this.btt_del.TabIndex = 2;
            this.btt_del.Text = "Delete";
            this.btt_del.UseVisualStyleBackColor = true;
            this.btt_del.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rabu_ret
            // 
            this.rabu_ret.AutoSize = true;
            this.rabu_ret.Location = new System.Drawing.Point(184, 125);
            this.rabu_ret.Name = "rabu_ret";
            this.rabu_ret.Size = new System.Drawing.Size(92, 26);
            this.rabu_ret.TabIndex = 17;
            this.rabu_ret.TabStop = true;
            this.rabu_ret.Text = "Retaired";
            this.rabu_ret.UseVisualStyleBackColor = true;
            // 
            // rabu_tra
            // 
            this.rabu_tra.AutoSize = true;
            this.rabu_tra.Location = new System.Drawing.Point(184, 97);
            this.rabu_tra.Name = "rabu_tra";
            this.rabu_tra.Size = new System.Drawing.Size(84, 26);
            this.rabu_tra.TabIndex = 18;
            this.rabu_tra.TabStop = true;
            this.rabu_tra.Text = "Trained";
            this.rabu_tra.UseVisualStyleBackColor = true;
            // 
            // rabu_reg
            // 
            this.rabu_reg.AutoSize = true;
            this.rabu_reg.Location = new System.Drawing.Point(184, 65);
            this.rabu_reg.Name = "rabu_reg";
            this.rabu_reg.Size = new System.Drawing.Size(99, 26);
            this.rabu_reg.TabIndex = 19;
            this.rabu_reg.TabStop = true;
            this.rabu_reg.Text = "Registerd";
            this.rabu_reg.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Doctor status :";
            // 
            // Delete_Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 352);
            this.Controls.Add(this.rabu_ret);
            this.Controls.Add(this.rabu_tra);
            this.Controls.Add(this.rabu_reg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btt_del);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Delete_Doctors";
            this.Text = "Delete_Doctors";
            this.Load += new System.EventHandler(this.Delete_Doctors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.Button btt_del;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rabu_ret;
        private System.Windows.Forms.RadioButton rabu_tra;
        private System.Windows.Forms.RadioButton rabu_reg;
        private System.Windows.Forms.Label label6;
    }
}