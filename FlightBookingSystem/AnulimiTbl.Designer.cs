namespace FlightBookingSystem
{
    partial class AnulimiTbl
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
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TidCb = new System.Windows.Forms.ComboBox();
            this.Fcode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CancellationDataGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CancellationDataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(60, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(249, 34);
            this.label12.TabIndex = 71;
            this.label12.Text = "Cancellations List";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(403, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 30);
            this.label6.TabIndex = 69;
            this.label6.Text = "Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(0, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 30);
            this.label5.TabIndex = 68;
            this.label5.Text = "Flight Code";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(387, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 30);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ticket Id";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TidCb
            // 
            this.TidCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TidCb.FormattingEnabled = true;
            this.TidCb.Location = new System.Drawing.Point(504, 165);
            this.TidCb.Name = "TidCb";
            this.TidCb.Size = new System.Drawing.Size(240, 36);
            this.TidCb.TabIndex = 66;
            this.TidCb.SelectionChangeCommitted += new System.EventHandler(this.TidCb_SelectionChangeCommitted);
            // 
            // Fcode
            // 
            this.Fcode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fcode.FormattingEnabled = true;
            this.Fcode.Location = new System.Drawing.Point(157, 208);
            this.Fcode.Name = "Fcode";
            this.Fcode.Size = new System.Drawing.Size(240, 36);
            this.Fcode.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(0, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 30);
            this.label4.TabIndex = 64;
            this.label4.Text = "Cancel Id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CancelId
            // 
            this.CancelId.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelId.Location = new System.Drawing.Point(137, 165);
            this.CancelId.Multiline = true;
            this.CancelId.Name = "CancelId";
            this.CancelId.Size = new System.Drawing.Size(244, 33);
            this.CancelId.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 38);
            this.label2.TabIndex = 62;
            this.label2.Text = "Ticket Cancellation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(125, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 45);
            this.label1.TabIndex = 61;
            this.label1.Text = "Black Swan Airline";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label11.Font = new System.Drawing.Font("Brush Script MT", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(703, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(293, 34);
            this.label11.TabIndex = 74;
            this.label11.Text = "“Wings up, worries down.”";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(962, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 34);
            this.label10.TabIndex = 75;
            this.label10.Text = "X";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // CancellationDataGV
            // 
            this.CancellationDataGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancellationDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CancellationDataGV.Location = new System.Drawing.Point(31, 442);
            this.CancellationDataGV.Name = "CancellationDataGV";
            this.CancellationDataGV.RowHeadersWidth = 62;
            this.CancellationDataGV.RowTemplate.Height = 28;
            this.CancellationDataGV.Size = new System.Drawing.Size(954, 298);
            this.CancellationDataGV.TabIndex = 76;
            this.CancellationDataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketDataGV_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(470, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 49);
            this.button3.TabIndex = 79;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(262, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 49);
            this.button2.TabIndex = 78;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(44, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 49);
            this.button1.TabIndex = 77;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CDate
            // 
            this.CDate.CalendarForeColor = System.Drawing.Color.Maroon;
            this.CDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDate.Location = new System.Drawing.Point(493, 211);
            this.CDate.Name = "CDate";
            this.CDate.Size = new System.Drawing.Size(281, 37);
            this.CDate.TabIndex = 80;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FlightBookingSystem.Properties.Resources.cancel;
            this.pictureBox2.Location = new System.Drawing.Point(799, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightBookingSystem.Properties.Resources.third;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(998, 764);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AnulimiTbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 764);
            this.Controls.Add(this.CDate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CancellationDataGV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TidCb);
            this.Controls.Add(this.Fcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnulimiTbl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnulimiTbl";
            this.Load += new System.EventHandler(this.AnulimiTbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CancellationDataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TidCb;
        private System.Windows.Forms.ComboBox Fcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CancelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView CancellationDataGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker CDate;
    }
}