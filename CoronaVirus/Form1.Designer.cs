namespace CoronaVirus
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CoronaVirusTotalCases = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ActiveCases = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.MeetingIll = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Contagion = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Dane = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(88, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(328, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Coronavirus total cases";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CoronaVirusTotalCases
            // 
            this.CoronaVirusTotalCases.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.CoronaVirusTotalCases.BackColor = System.Drawing.SystemColors.Control;
            this.CoronaVirusTotalCases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CoronaVirusTotalCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CoronaVirusTotalCases.Location = new System.Drawing.Point(220, 62);
            this.CoronaVirusTotalCases.Margin = new System.Windows.Forms.Padding(2);
            this.CoronaVirusTotalCases.Name = "CoronaVirusTotalCases";
            this.CoronaVirusTotalCases.Size = new System.Drawing.Size(75, 19);
            this.CoronaVirusTotalCases.TabIndex = 1;
            this.CoronaVirusTotalCases.Text = "Test Text";
            this.CoronaVirusTotalCases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(88, 85);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(328, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Active coronavirus cases";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ActiveCases
            // 
            this.ActiveCases.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.ActiveCases.BackColor = System.Drawing.SystemColors.Control;
            this.ActiveCases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActiveCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActiveCases.Location = new System.Drawing.Point(220, 112);
            this.ActiveCases.Margin = new System.Windows.Forms.Padding(2);
            this.ActiveCases.Name = "ActiveCases";
            this.ActiveCases.Size = new System.Drawing.Size(75, 19);
            this.ActiveCases.TabIndex = 3;
            this.ActiveCases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(88, 217);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(328, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Probabillity of meeting ill person";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MeetingIll
            // 
            this.MeetingIll.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.MeetingIll.BackColor = System.Drawing.SystemColors.Control;
            this.MeetingIll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MeetingIll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MeetingIll.Location = new System.Drawing.Point(193, 245);
            this.MeetingIll.Margin = new System.Windows.Forms.Padding(2);
            this.MeetingIll.Name = "MeetingIll";
            this.MeetingIll.Size = new System.Drawing.Size(118, 19);
            this.MeetingIll.TabIndex = 5;
            this.MeetingIll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MeetingIll.TextChanged += new System.EventHandler(this.MeetingIll_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox6.Location = new System.Drawing.Point(88, 269);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(328, 23);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "Probabillity of contagion";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Contagion
            // 
            this.Contagion.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Contagion.BackColor = System.Drawing.SystemColors.Control;
            this.Contagion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contagion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Contagion.Location = new System.Drawing.Point(143, 296);
            this.Contagion.Margin = new System.Windows.Forms.Padding(2);
            this.Contagion.Name = "Contagion";
            this.Contagion.Size = new System.Drawing.Size(222, 19);
            this.Contagion.TabIndex = 7;
            this.Contagion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Contagion.TextChanged += new System.EventHandler(this.Contagion_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox8.Location = new System.Drawing.Point(88, 344);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(328, 23);
            this.textBox8.TabIndex = 8;
            this.textBox8.Text = "Data source:";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // Dane
            // 
            this.Dane.BackColor = System.Drawing.SystemColors.Control;
            this.Dane.FlatAppearance.BorderSize = 0;
            this.Dane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dane.Location = new System.Drawing.Point(68, 372);
            this.Dane.Name = "Dane";
            this.Dane.Size = new System.Drawing.Size(378, 29);
            this.Dane.TabIndex = 9;
            this.Dane.Text = "Behavior data source: medonet.pl";
            this.Dane.UseVisualStyleBackColor = false;
            this.Dane.Click += new System.EventHandler(this.Dane_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(-3, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(509, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Source of data on the population of Poland: populacja.population.city";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dane);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.Contagion);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.MeetingIll);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ActiveCases);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CoronaVirusTotalCases);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Coronavirus in numbers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox CoronaVirusTotalCases;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ActiveCases;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox MeetingIll;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox Contagion;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button Dane;
        private System.Windows.Forms.Button button1;
    }
}

