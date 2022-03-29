namespace PhanMemQuanLyNhanSu
{
    partial class Frmtimkiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmtimkiem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioten = new System.Windows.Forms.RadioButton();
            this.radiocm = new System.Windows.Forms.RadioButton();
            this.radioma = new System.Windows.Forms.RadioButton();
            this.txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvtimkiem = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.radioten);
            this.groupBox1.Controls.Add(this.radiocm);
            this.groupBox1.Controls.Add(this.radioma);
            this.groupBox1.Controls.Add(this.txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1001, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::PhanMemQuanLyNhanSu.Properties.Resources.timkiem;
            this.pictureBox1.Location = new System.Drawing.Point(24, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 129);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // radioten
            // 
            this.radioten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioten.AutoSize = true;
            this.radioten.Location = new System.Drawing.Point(430, 112);
            this.radioten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioten.Name = "radioten";
            this.radioten.Size = new System.Drawing.Size(128, 29);
            this.radioten.TabIndex = 2;
            this.radioten.TabStop = true;
            this.radioten.Text = "Họ Và Tên";
            this.radioten.UseVisualStyleBackColor = true;
            this.radioten.CheckedChanged += new System.EventHandler(this.radioten_CheckedChanged);
            // 
            // radiocm
            // 
            this.radiocm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radiocm.AutoSize = true;
            this.radiocm.Location = new System.Drawing.Point(585, 112);
            this.radiocm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiocm.Name = "radiocm";
            this.radiocm.Size = new System.Drawing.Size(106, 29);
            this.radiocm.TabIndex = 3;
            this.radiocm.TabStop = true;
            this.radiocm.Text = "CMTND";
            this.radiocm.UseVisualStyleBackColor = true;
            this.radiocm.CheckedChanged += new System.EventHandler(this.radiocm_CheckedChanged);
            // 
            // radioma
            // 
            this.radioma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioma.AutoSize = true;
            this.radioma.Location = new System.Drawing.Point(254, 112);
            this.radioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioma.Name = "radioma";
            this.radioma.Size = new System.Drawing.Size(158, 29);
            this.radioma.TabIndex = 1;
            this.radioma.TabStop = true;
            this.radioma.Text = "Mã Nhân Viên";
            this.radioma.UseVisualStyleBackColor = true;
            this.radioma.CheckedChanged += new System.EventHandler(this.radioma_CheckedChanged);
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt.Location = new System.Drawing.Point(393, 41);
            this.txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(256, 30);
            this.txt.TabIndex = 0;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm";
            // 
            // dgvtimkiem
            // 
            this.dgvtimkiem.AllowUserToAddRows = false;
            this.dgvtimkiem.AllowUserToDeleteRows = false;
            this.dgvtimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtimkiem.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimkiem.Location = new System.Drawing.Point(12, 313);
            this.dgvtimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvtimkiem.Name = "dgvtimkiem";
            this.dgvtimkiem.ReadOnly = true;
            this.dgvtimkiem.RowHeadersWidth = 51;
            this.dgvtimkiem.RowTemplate.Height = 24;
            this.dgvtimkiem.Size = new System.Drawing.Size(1001, 230);
            this.dgvtimkiem.TabIndex = 2;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btntimkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntimkiem.BackgroundImage")));
            this.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntimkiem.FlatAppearance.BorderSize = 0;
            this.btntimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntimkiem.Image = global::PhanMemQuanLyNhanSu.Properties.Resources.tim;
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.Location = new System.Drawing.Point(263, 20);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(149, 55);
            this.btntimkiem.TabIndex = 0;
            this.btntimkiem.Text = "Tìm KIếm";
            this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnload
            // 
            this.btnload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnload.BackgroundImage")));
            this.btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnload.FlatAppearance.BorderSize = 0;
            this.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnload.Image = global::PhanMemQuanLyNhanSu.Properties.Resources.upload;
            this.btnload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnload.Location = new System.Drawing.Point(500, 20);
            this.btnload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(149, 55);
            this.btnload.TabIndex = 2;
            this.btnload.Text = "Load";
            this.btnload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnload);
            this.groupBox2.Controls.Add(this.btntimkiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1001, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // Frmtimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhanMemQuanLyNhanSu.Properties.Resources.aa;
            this.ClientSize = new System.Drawing.Size(1025, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvtimkiem);
            this.Name = "Frmtimkiem";
            this.Text = "Frmtimkiem";
            this.Load += new System.EventHandler(this.Frmtimkiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioten;
        private System.Windows.Forms.RadioButton radiocm;
        private System.Windows.Forms.RadioButton radioma;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtimkiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}