namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.toyota = new System.Windows.Forms.RadioButton();
            this.nissan = new System.Windows.Forms.RadioButton();
            this.subaru = new System.Windows.Forms.RadioButton();
            this.honda = new System.Windows.Forms.RadioButton();
            this.sonota = new System.Windows.Forms.RadioButton();
            this.gaisya = new System.Windows.Forms.RadioButton();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btOpenReport = new System.Windows.Forms.Button();
            this.btSaveReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAddReport = new System.Windows.Forms.Button();
            this.btRemakeReport = new System.Windows.Forms.Button();
            this.btDeleteReport = new System.Windows.Forms.Button();
            this.btOpenPicture = new System.Windows.Forms.Button();
            this.btDeletePicture = new System.Windows.Forms.Button();
            this.btFinish = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "メーカー：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "記録者：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "記事一覧：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "画像：";
            // 
            // dtpDay
            // 
            this.dtpDay.Location = new System.Drawing.Point(97, 6);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(181, 19);
            this.dtpDay.TabIndex = 7;
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(97, 42);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(242, 20);
            this.cbName.TabIndex = 8;
            // 
            // toyota
            // 
            this.toyota.AutoSize = true;
            this.toyota.Location = new System.Drawing.Point(6, 13);
            this.toyota.Name = "toyota";
            this.toyota.Size = new System.Drawing.Size(47, 16);
            this.toyota.TabIndex = 9;
            this.toyota.TabStop = true;
            this.toyota.Text = "トヨタ";
            this.toyota.UseVisualStyleBackColor = true;
            // 
            // nissan
            // 
            this.nissan.AutoSize = true;
            this.nissan.Location = new System.Drawing.Point(59, 13);
            this.nissan.Name = "nissan";
            this.nissan.Size = new System.Drawing.Size(47, 16);
            this.nissan.TabIndex = 10;
            this.nissan.TabStop = true;
            this.nissan.Text = "日産";
            this.nissan.UseVisualStyleBackColor = true;
            // 
            // subaru
            // 
            this.subaru.AutoSize = true;
            this.subaru.Location = new System.Drawing.Point(112, 13);
            this.subaru.Name = "subaru";
            this.subaru.Size = new System.Drawing.Size(52, 16);
            this.subaru.TabIndex = 11;
            this.subaru.TabStop = true;
            this.subaru.Text = "スバル";
            this.subaru.UseVisualStyleBackColor = true;
            // 
            // honda
            // 
            this.honda.AutoSize = true;
            this.honda.Location = new System.Drawing.Point(170, 11);
            this.honda.Name = "honda";
            this.honda.Size = new System.Drawing.Size(51, 16);
            this.honda.TabIndex = 12;
            this.honda.TabStop = true;
            this.honda.Text = "ホンダ";
            this.honda.UseVisualStyleBackColor = true;
            // 
            // sonota
            // 
            this.sonota.AutoSize = true;
            this.sonota.Location = new System.Drawing.Point(280, 11);
            this.sonota.Name = "sonota";
            this.sonota.Size = new System.Drawing.Size(54, 16);
            this.sonota.TabIndex = 16;
            this.sonota.TabStop = true;
            this.sonota.Text = "その他";
            this.sonota.UseVisualStyleBackColor = true;
            // 
            // gaisya
            // 
            this.gaisya.AutoSize = true;
            this.gaisya.Location = new System.Drawing.Point(227, 11);
            this.gaisya.Name = "gaisya";
            this.gaisya.Size = new System.Drawing.Size(47, 16);
            this.gaisya.TabIndex = 15;
            this.gaisya.TabStop = true;
            this.gaisya.Text = "外車";
            this.gaisya.UseVisualStyleBackColor = true;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(97, 120);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(242, 20);
            this.cbCarName.TabIndex = 15;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(97, 156);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(389, 104);
            this.tbReport.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(685, 168);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btOpenReport
            // 
            this.btOpenReport.Location = new System.Drawing.Point(12, 305);
            this.btOpenReport.Name = "btOpenReport";
            this.btOpenReport.Size = new System.Drawing.Size(63, 37);
            this.btOpenReport.TabIndex = 18;
            this.btOpenReport.Text = "開く";
            this.btOpenReport.UseVisualStyleBackColor = true;
            this.btOpenReport.Click += new System.EventHandler(this.btOpenReport_Click);
            // 
            // btSaveReport
            // 
            this.btSaveReport.Location = new System.Drawing.Point(12, 348);
            this.btSaveReport.Name = "btSaveReport";
            this.btSaveReport.Size = new System.Drawing.Size(63, 37);
            this.btSaveReport.TabIndex = 19;
            this.btSaveReport.Text = "保存";
            this.btSaveReport.UseVisualStyleBackColor = true;
            this.btSaveReport.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(534, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 201);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btAddReport
            // 
            this.btAddReport.Location = new System.Drawing.Point(538, 252);
            this.btAddReport.Name = "btAddReport";
            this.btAddReport.Size = new System.Drawing.Size(73, 19);
            this.btAddReport.TabIndex = 21;
            this.btAddReport.Text = "追加";
            this.btAddReport.UseVisualStyleBackColor = true;
            this.btAddReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRemakeReport
            // 
            this.btRemakeReport.Location = new System.Drawing.Point(617, 252);
            this.btRemakeReport.Name = "btRemakeReport";
            this.btRemakeReport.Size = new System.Drawing.Size(73, 19);
            this.btRemakeReport.TabIndex = 22;
            this.btRemakeReport.Text = "修正";
            this.btRemakeReport.UseVisualStyleBackColor = true;
            this.btRemakeReport.Click += new System.EventHandler(this.btRemakeReport_Click);
            // 
            // btDeleteReport
            // 
            this.btDeleteReport.Location = new System.Drawing.Point(696, 252);
            this.btDeleteReport.Name = "btDeleteReport";
            this.btDeleteReport.Size = new System.Drawing.Size(73, 19);
            this.btDeleteReport.TabIndex = 23;
            this.btDeleteReport.Text = "削除";
            this.btDeleteReport.UseVisualStyleBackColor = true;
            this.btDeleteReport.Click += new System.EventHandler(this.btDeleteReport_Click);
            // 
            // btOpenPicture
            // 
            this.btOpenPicture.Location = new System.Drawing.Point(611, 13);
            this.btOpenPicture.Name = "btOpenPicture";
            this.btOpenPicture.Size = new System.Drawing.Size(67, 19);
            this.btOpenPicture.TabIndex = 24;
            this.btOpenPicture.Text = "開く";
            this.btOpenPicture.UseVisualStyleBackColor = true;
            this.btOpenPicture.Click += new System.EventHandler(this.btOpenPicture_Click);
            // 
            // btDeletePicture
            // 
            this.btDeletePicture.Location = new System.Drawing.Point(684, 13);
            this.btDeletePicture.Name = "btDeletePicture";
            this.btDeletePicture.Size = new System.Drawing.Size(67, 19);
            this.btDeletePicture.TabIndex = 25;
            this.btDeletePicture.Text = "削除";
            this.btDeletePicture.UseVisualStyleBackColor = true;
            this.btDeletePicture.Click += new System.EventHandler(this.btDeletePicture_Click);
            // 
            // btFinish
            // 
            this.btFinish.Location = new System.Drawing.Point(684, 451);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(94, 19);
            this.btFinish.TabIndex = 26;
            this.btFinish.Text = "終了";
            this.btFinish.UseVisualStyleBackColor = true;
            this.btFinish.Click += new System.EventHandler(this.btFinish_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toyota);
            this.groupBox1.Controls.Add(this.sonota);
            this.groupBox1.Controls.Add(this.nissan);
            this.groupBox1.Controls.Add(this.subaru);
            this.groupBox1.Controls.Add(this.gaisya);
            this.groupBox1.Controls.Add(this.honda);
            this.groupBox1.Location = new System.Drawing.Point(92, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 37);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btFinish);
            this.Controls.Add(this.btDeletePicture);
            this.Controls.Add(this.btOpenPicture);
            this.Controls.Add(this.btDeleteReport);
            this.Controls.Add(this.btRemakeReport);
            this.Controls.Add(this.btAddReport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSaveReport);
            this.Controls.Add(this.btOpenReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.dtpDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.RadioButton toyota;
        private System.Windows.Forms.RadioButton nissan;
        private System.Windows.Forms.RadioButton subaru;
        private System.Windows.Forms.RadioButton honda;
        private System.Windows.Forms.RadioButton sonota;
        private System.Windows.Forms.RadioButton gaisya;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btOpenReport;
        private System.Windows.Forms.Button btSaveReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAddReport;
        private System.Windows.Forms.Button btRemakeReport;
        private System.Windows.Forms.Button btDeleteReport;
        private System.Windows.Forms.Button btOpenPicture;
        private System.Windows.Forms.Button btDeletePicture;
        private System.Windows.Forms.Button btFinish;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

