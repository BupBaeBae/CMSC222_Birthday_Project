namespace birthday
{
    partial class birthday
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDOW = new System.Windows.Forms.Label();
            this.txtDOW = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.txtAnimal = new System.Windows.Forms.Label();
            this.lblZodiac = new System.Windows.Forms.Label();
            this.txtZodiac = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.txtSeason = new System.Windows.Forms.Label();
            this.picAnimals = new System.Windows.Forms.PictureBox();
            this.picZodiacs = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZodiacs)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(345, 56);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(527, 38);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(54, 56);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(87, 32);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // lblDOW
            // 
            this.lblDOW.AutoSize = true;
            this.lblDOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOW.Location = new System.Drawing.Point(54, 161);
            this.lblDOW.Name = "lblDOW";
            this.lblDOW.Size = new System.Drawing.Size(194, 32);
            this.lblDOW.TabIndex = 2;
            this.lblDOW.Text = "Day of Week:";
            // 
            // txtDOW
            // 
            this.txtDOW.AutoSize = true;
            this.txtDOW.Location = new System.Drawing.Point(339, 161);
            this.txtDOW.Name = "txtDOW";
            this.txtDOW.Size = new System.Drawing.Size(0, 32);
            this.txtDOW.TabIndex = 3;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.Location = new System.Drawing.Point(54, 474);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(207, 32);
            this.lblAnimal.TabIndex = 4;
            this.lblAnimal.Text = "Chinese Year:";
            // 
            // txtAnimal
            // 
            this.txtAnimal.AutoSize = true;
            this.txtAnimal.Location = new System.Drawing.Point(339, 474);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(0, 32);
            this.txtAnimal.TabIndex = 5;
            // 
            // lblZodiac
            // 
            this.lblZodiac.AutoSize = true;
            this.lblZodiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZodiac.Location = new System.Drawing.Point(54, 889);
            this.lblZodiac.Name = "lblZodiac";
            this.lblZodiac.Size = new System.Drawing.Size(185, 32);
            this.lblZodiac.TabIndex = 6;
            this.lblZodiac.Text = "Zodiac Sign:";
            // 
            // txtZodiac
            // 
            this.txtZodiac.AutoSize = true;
            this.txtZodiac.Location = new System.Drawing.Point(339, 889);
            this.txtZodiac.Name = "txtZodiac";
            this.txtZodiac.Size = new System.Drawing.Size(0, 32);
            this.txtZodiac.TabIndex = 7;
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeason.Location = new System.Drawing.Point(54, 245);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(126, 32);
            this.lblSeason.TabIndex = 8;
            this.lblSeason.Text = "Season:";
            // 
            // txtSeason
            // 
            this.txtSeason.AutoSize = true;
            this.txtSeason.Location = new System.Drawing.Point(339, 245);
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.Size = new System.Drawing.Size(0, 32);
            this.txtSeason.TabIndex = 9;
            // 
            // picAnimals
            // 
            this.picAnimals.Location = new System.Drawing.Point(665, 356);
            this.picAnimals.Name = "picAnimals";
            this.picAnimals.Size = new System.Drawing.Size(150, 150);
            this.picAnimals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAnimals.TabIndex = 10;
            this.picAnimals.TabStop = false;
            // 
            // picZodiacs
            // 
            this.picZodiacs.Location = new System.Drawing.Point(665, 771);
            this.picZodiacs.Name = "picZodiacs";
            this.picZodiacs.Size = new System.Drawing.Size(150, 150);
            this.picZodiacs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picZodiacs.TabIndex = 11;
            this.picZodiacs.TabStop = false;
            // 
            // birthday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 1312);
            this.Controls.Add(this.picZodiacs);
            this.Controls.Add(this.picAnimals);
            this.Controls.Add(this.txtSeason);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.txtZodiac);
            this.Controls.Add(this.lblZodiac);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.txtDOW);
            this.Controls.Add(this.lblDOW);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "birthday";
            this.Text = "Birthday";
            ((System.ComponentModel.ISupportInitialize)(this.picAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZodiacs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDOW;
        private System.Windows.Forms.Label txtDOW;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label txtAnimal;
        private System.Windows.Forms.Label lblZodiac;
        private System.Windows.Forms.Label txtZodiac;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.Label txtSeason;
        private System.Windows.Forms.PictureBox picAnimals;
        private System.Windows.Forms.PictureBox picZodiacs;
    }
}

