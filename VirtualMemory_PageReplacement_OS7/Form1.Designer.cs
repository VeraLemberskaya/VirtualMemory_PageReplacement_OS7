namespace VirtualMemory_PageReplacement_OS7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PageNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.memorySizeTextBox = new System.Windows.Forms.TextBox();
            this.processSizeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.referToAddressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pageLabel = new System.Windows.Forms.Label();
            this.pageFrameLabel = new System.Windows.Forms.Label();
            this.physicalAddressLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.PN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresentBit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferencedBit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedBit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageFR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.ReferBtn = new System.Windows.Forms.Button();
            this.ModifyBTN = new System.Windows.Forms.Button();
            this.modifyAddressTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageNum,
            this.PageFrame});
            this.dataGridView1.Location = new System.Drawing.Point(27, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // PageNum
            // 
            this.PageNum.HeaderText = "Page Number";
            this.PageNum.Name = "PageNum";
            // 
            // PageFrame
            // 
            this.PageFrame.HeaderText = "PageFrameNumber";
            this.PageFrame.Name = "PageFrame";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PageNumber,
            this.Status});
            this.dataGridView2.Location = new System.Drawing.Point(318, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 323);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(622, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Memory Size:";
            // 
            // memorySizeTextBox
            // 
            this.memorySizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memorySizeTextBox.Location = new System.Drawing.Point(729, 46);
            this.memorySizeTextBox.Name = "memorySizeTextBox";
            this.memorySizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.memorySizeTextBox.TabIndex = 3;
            // 
            // processSizeTextBox
            // 
            this.processSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processSizeTextBox.Location = new System.Drawing.Point(729, 91);
            this.processSizeTextBox.Name = "processSizeTextBox";
            this.processSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.processSizeTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(622, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Process Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(622, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Refer to address:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(625, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // referToAddressTextBox
            // 
            this.referToAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.referToAddressTextBox.Location = new System.Drawing.Point(765, 233);
            this.referToAddressTextBox.Name = "referToAddressTextBox";
            this.referToAddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.referToAddressTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(622, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Page:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(622, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Page Frame:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(622, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Physical address:";
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageLabel.ForeColor = System.Drawing.Color.Red;
            this.pageLabel.Location = new System.Drawing.Point(683, 315);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(0, 16);
            this.pageLabel.TabIndex = 12;
            // 
            // pageFrameLabel
            // 
            this.pageFrameLabel.AutoSize = true;
            this.pageFrameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageFrameLabel.ForeColor = System.Drawing.Color.Red;
            this.pageFrameLabel.Location = new System.Drawing.Point(726, 346);
            this.pageFrameLabel.Name = "pageFrameLabel";
            this.pageFrameLabel.Size = new System.Drawing.Size(0, 16);
            this.pageFrameLabel.TabIndex = 13;
            // 
            // physicalAddressLabel
            // 
            this.physicalAddressLabel.AutoSize = true;
            this.physicalAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.physicalAddressLabel.ForeColor = System.Drawing.Color.Red;
            this.physicalAddressLabel.Location = new System.Drawing.Point(762, 380);
            this.physicalAddressLabel.Name = "physicalAddressLabel";
            this.physicalAddressLabel.Size = new System.Drawing.Size(0, 16);
            this.physicalAddressLabel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(835, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "KB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(835, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "KB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(134, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "RAM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(420, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "DISK";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PN,
            this.PresentBit,
            this.ReferencedBit,
            this.ModifiedBit,
            this.PageFR});
            this.dataGridView3.Location = new System.Drawing.Point(12, 404);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(549, 194);
            this.dataGridView3.TabIndex = 19;
            // 
            // PN
            // 
            this.PN.HeaderText = "Page Number";
            this.PN.Name = "PN";
            // 
            // PresentBit
            // 
            this.PresentBit.HeaderText = "Present Bit";
            this.PresentBit.Name = "PresentBit";
            // 
            // ReferencedBit
            // 
            this.ReferencedBit.HeaderText = "Referenced Bit";
            this.ReferencedBit.Name = "ReferencedBit";
            // 
            // ModifiedBit
            // 
            this.ModifiedBit.HeaderText = "Modified Bit";
            this.ModifiedBit.Name = "ModifiedBit";
            // 
            // PageFR
            // 
            this.PageFR.HeaderText = "Page Frame Number";
            this.PageFR.Name = "PageFR";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "PAGE TABLE";
            // 
            // ReferBtn
            // 
            this.ReferBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReferBtn.Location = new System.Drawing.Point(882, 233);
            this.ReferBtn.Name = "ReferBtn";
            this.ReferBtn.Size = new System.Drawing.Size(75, 23);
            this.ReferBtn.TabIndex = 21;
            this.ReferBtn.Text = "Refer";
            this.ReferBtn.UseVisualStyleBackColor = true;
            this.ReferBtn.Click += new System.EventHandler(this.ReferBtn_Click);
            // 
            // ModifyBTN
            // 
            this.ModifyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModifyBTN.Location = new System.Drawing.Point(882, 272);
            this.ModifyBTN.Name = "ModifyBTN";
            this.ModifyBTN.Size = new System.Drawing.Size(75, 23);
            this.ModifyBTN.TabIndex = 24;
            this.ModifyBTN.Text = "Modify";
            this.ModifyBTN.UseVisualStyleBackColor = true;
            this.ModifyBTN.Click += new System.EventHandler(this.ModifyBTN_Click);
            // 
            // modifyAddressTextBox
            // 
            this.modifyAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modifyAddressTextBox.Location = new System.Drawing.Point(765, 272);
            this.modifyAddressTextBox.Name = "modifyAddressTextBox";
            this.modifyAddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.modifyAddressTextBox.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(622, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Write to address:";
            // 
            // PageNumber
            // 
            this.PageNumber.HeaderText = "Page Number";
            this.PageNumber.Name = "PageNumber";
            // 
            // Status
            // 
            this.Status.HeaderText = "DiskAdress";
            this.Status.Name = "Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(624, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Algorithm:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(729, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 615);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ModifyBTN);
            this.Controls.Add(this.modifyAddressTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ReferBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.physicalAddressLabel);
            this.Controls.Add(this.pageFrameLabel);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.referToAddressTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.processSizeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memorySizeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memorySizeTextBox;
        private System.Windows.Forms.TextBox processSizeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox referToAddressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Label pageFrameLabel;
        private System.Windows.Forms.Label physicalAddressLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageFrame;
        private System.Windows.Forms.DataGridViewTextBoxColumn PN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresentBit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferencedBit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedBit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageFR;
        private System.Windows.Forms.Button ReferBtn;
        private System.Windows.Forms.Button ModifyBTN;
        private System.Windows.Forms.TextBox modifyAddressTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

