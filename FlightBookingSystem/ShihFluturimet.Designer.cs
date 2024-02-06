namespace FlightBookingSystem
{
    partial class ShihFluturimet
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Source = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Seatnumbers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Fcodee = new System.Windows.Forms.TextBox();
            this.Destination = new System.Windows.Forms.ComboBox();
            this.FlightDataGV = new System.Windows.Forms.DataGridView();
            this.Print = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDataGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "View Scheduled Flights";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(107, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Black Swan Airline";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Fdate
            // 
            this.Fdate.CalendarForeColor = System.Drawing.Color.Maroon;
            this.Fdate.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Fdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fdate.Location = new System.Drawing.Point(188, 252);
            this.Fdate.Name = "Fdate";
            this.Fdate.Size = new System.Drawing.Size(250, 37);
            this.Fdate.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(12, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 30);
            this.label8.TabIndex = 30;
            this.label8.Text = "TakeofDate:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Source
            // 
            this.Source.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Source.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Source.FormattingEnabled = true;
            this.Source.Items.AddRange(new object[] {
            "London",
            "Tirana",
            "Prishtina",
            "Madrid",
            "Skopje",
            "Istanbul",
            "Berlin",
            "Paris",
            "Viena",
            "Chicago",
            "New York",
            "Verona",
            "Delhy",
            "Dubai",
            "Barcelona"});
            this.Source.Location = new System.Drawing.Point(582, 169);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(225, 36);
            this.Source.TabIndex = 29;
            this.Source.SelectedIndexChanged += new System.EventHandler(this.Source_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(459, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 30);
            this.label6.TabIndex = 28;
            this.label6.Text = "Source";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(459, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "Destination";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(196, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "Num of Seats:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Seatnumbers
            // 
            this.Seatnumbers.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Seatnumbers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Seatnumbers.Location = new System.Drawing.Point(407, 337);
            this.Seatnumbers.Multiline = true;
            this.Seatnumbers.Name = "Seatnumbers";
            this.Seatnumbers.Size = new System.Drawing.Size(244, 26);
            this.Seatnumbers.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(-5, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "Flight Code";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Fcodee
            // 
            this.Fcodee.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Fcodee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fcodee.Location = new System.Drawing.Point(174, 179);
            this.Fcodee.Multiline = true;
            this.Fcodee.Name = "Fcodee";
            this.Fcodee.Size = new System.Drawing.Size(244, 26);
            this.Fcodee.TabIndex = 23;
            // 
            // Destination
            // 
            this.Destination.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Destination.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Destination.FormattingEnabled = true;
            this.Destination.Items.AddRange(new object[] {
            "London",
            "Tirana",
            "Prishtina",
            "Madrid",
            "Skopje",
            "Istanbul",
            "Berlin",
            "Paris",
            "Viena",
            "Chicago",
            "New York",
            "Verona",
            "Delhy",
            "Dubai",
            "Barcelona"});
            this.Destination.Location = new System.Drawing.Point(612, 246);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(208, 36);
            this.Destination.TabIndex = 33;
            // 
            // FlightDataGV
            // 
            this.FlightDataGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FlightDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightDataGV.Location = new System.Drawing.Point(12, 409);
            this.FlightDataGV.Name = "FlightDataGV";
            this.FlightDataGV.ReadOnly = true;
            this.FlightDataGV.RowHeadersWidth = 62;
            this.FlightDataGV.RowTemplate.Height = 28;
            this.FlightDataGV.Size = new System.Drawing.Size(859, 262);
            this.FlightDataGV.TabIndex = 39;
            this.FlightDataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightDataGV_CellContentClick);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Print.FlatAppearance.BorderSize = 0;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.ForeColor = System.Drawing.Color.Maroon;
            this.Print.Location = new System.Drawing.Point(672, 354);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(189, 49);
            this.Print.TabIndex = 41;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FlightBookingSystem.Properties.Resources.third;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 677);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 87);
            this.panel2.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(602, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 49);
            this.button3.TabIndex = 37;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(212, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 49);
            this.button4.TabIndex = 36;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(407, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 49);
            this.button2.TabIndex = 35;
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
            this.button1.Location = new System.Drawing.Point(17, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 49);
            this.button1.TabIndex = 34;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FlightBookingSystem.Properties.Resources.m;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(877, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 764);
            this.panel1.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(86, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 34);
            this.label10.TabIndex = 76;
            this.label10.Text = "X";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ShihFluturimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(997, 764);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.FlightDataGV);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.Fdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Seatnumbers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fcodee);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShihFluturimet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShihFluturimet";
            this.Load += new System.EventHandler(this.ShihFluturimet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightDataGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker Fdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Source;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Seatnumbers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Fcodee;
        private System.Windows.Forms.ComboBox Destination;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView FlightDataGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Print;
    }
}