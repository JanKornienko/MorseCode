namespace morseCode
{
    partial class Morse
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textFile = new System.Windows.Forms.CheckBox();
            this.button = new System.Windows.Forms.Button();
            this.radLight = new System.Windows.Forms.RadioButton();
            this.radSound = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(460, 100);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(12, 119);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(460, 100);
            this.textBox2.TabIndex = 1;
            // 
            // textFile
            // 
            this.textFile.AutoSize = true;
            this.textFile.Location = new System.Drawing.Point(12, 271);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(63, 17);
            this.textFile.TabIndex = 4;
            this.textFile.Text = "Text file";
            this.textFile.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 296);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 5;
            this.button.Text = "Translate";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // radLight
            // 
            this.radLight.AutoSize = true;
            this.radLight.Location = new System.Drawing.Point(12, 225);
            this.radLight.Name = "radLight";
            this.radLight.Size = new System.Drawing.Size(48, 17);
            this.radLight.TabIndex = 6;
            this.radLight.TabStop = true;
            this.radLight.Text = "Light";
            this.radLight.UseVisualStyleBackColor = true;
            // 
            // radSound
            // 
            this.radSound.AutoSize = true;
            this.radSound.Location = new System.Drawing.Point(12, 248);
            this.radSound.Name = "radSound";
            this.radSound.Size = new System.Drawing.Size(56, 17);
            this.radSound.TabIndex = 7;
            this.radSound.TabStop = true;
            this.radSound.Text = "Sound";
            this.radSound.UseVisualStyleBackColor = true;
            // 
            // Morse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 331);
            this.Controls.Add(this.radSound);
            this.Controls.Add(this.radLight);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Morse";
            this.Text = "Morse Code Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox textFile;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.RadioButton radLight;
        private System.Windows.Forms.RadioButton radSound;
    }
}

