namespace FlightBookingSystem
{
    partial class Tickets
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
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TicketId = new System.Windows.Forms.TextBox();
            this.PIdCb = new System.Windows.Forms.ComboBox();
            this.FCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Nationality = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PassNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TicketDataGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(964, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 34);
            this.label10.TabIndex = 42;
            this.label10.Text = "X";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 38);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ticket Booking";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(127, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 45);
            this.label1.TabIndex = 40;
            this.label1.Text = "Black Swan Airline";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(22, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 30);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ticket Id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TicketId
            // 
            this.TicketId.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TicketId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TicketId.Location = new System.Drawing.Point(176, 130);
            this.TicketId.Multiline = true;
            this.TicketId.Name = "TicketId";
            this.TicketId.Size = new System.Drawing.Size(244, 33);
            this.TicketId.TabIndex = 43;
            // 
            // PIdCb
            // 
            this.PIdCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIdCb.FormattingEnabled = true;
            this.PIdCb.Location = new System.Drawing.Point(180, 191);
            this.PIdCb.Name = "PIdCb";
            this.PIdCb.Size = new System.Drawing.Size(240, 36);
            this.PIdCb.TabIndex = 45;
            this.PIdCb.SelectionChangeCommitted += new System.EventHandler(this.PIdCb_SelectionChangeCommitted);
            // 
            // FCode
            // 
            this.FCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCode.FormattingEnabled = true;
            this.FCode.Location = new System.Drawing.Point(593, 133);
            this.FCode.Name = "FCode";
            this.FCode.Size = new System.Drawing.Size(240, 36);
            this.FCode.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(436, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 30);
            this.label3.TabIndex = 47;
            this.label3.Text = "Flight Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(22, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 30);
            this.label5.TabIndex = 48;
            this.label5.Text = "Passenger Id";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(447, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 30);
            this.label6.TabIndex = 49;
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PName
            // 
            this.PName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PName.Enabled = false;
            this.PName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PName.Location = new System.Drawing.Point(593, 191);
            this.PName.Multiline = true;
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(244, 33);
            this.PName.TabIndex = 50;
            this.PName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(436, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 30);
            this.label7.TabIndex = 52;
            this.label7.Text = "Nationality";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Nationality
            // 
            this.Nationality.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Nationality.Enabled = false;
            this.Nationality.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nationality.Location = new System.Drawing.Point(593, 269);
            this.Nationality.Multiline = true;
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(244, 33);
            this.Nationality.TabIndex = 51;
            this.Nationality.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(22, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 30);
            this.label8.TabIndex = 54;
            this.label8.Text = "Passport No";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PassNo
            // 
            this.PassNo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PassNo.Enabled = false;
            this.PassNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PassNo.Location = new System.Drawing.Point(176, 266);
            this.PassNo.Multiline = true;
            this.PassNo.Name = "PassNo";
            this.PassNo.Size = new System.Drawing.Size(244, 33);
            this.PassNo.TabIndex = 53;
            this.PassNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PassNo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(274, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 30);
            this.label9.TabIndex = 56;
            this.label9.Text = "Amount";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Amount
            // 
            this.Amount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Amount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Amount.Location = new System.Drawing.Point(420, 331);
            this.Amount.Multiline = true;
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(244, 33);
            this.Amount.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(440, 438);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 34);
            this.label12.TabIndex = 59;
            this.label12.Text = "Bookings";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(606, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 49);
            this.button3.TabIndex = 63;
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
            this.button2.Location = new System.Drawing.Point(398, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 49);
            this.button2.TabIndex = 62;
            this.button2.Text = "Reset";
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
            this.button1.Location = new System.Drawing.Point(180, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 49);
            this.button1.TabIndex = 61;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TicketDataGV
            // 
            this.TicketDataGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TicketDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDataGV.Location = new System.Drawing.Point(12, 475);
            this.TicketDataGV.Name = "TicketDataGV";
            this.TicketDataGV.RowHeadersWidth = 62;
            this.TicketDataGV.RowTemplate.Height = 28;
            this.TicketDataGV.Size = new System.Drawing.Size(954, 262);
            this.TicketDataGV.TabIndex = 64;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(989, 764);
            this.Controls.Add(this.TicketDataGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PassNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Nationality);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FCode);
            this.Controls.Add(this.PIdCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TicketId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TicketId;
        private System.Windows.Forms.ComboBox PIdCb;
        private System.Windows.Forms.ComboBox FCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Nationality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PassNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView TicketDataGV;
    }
}