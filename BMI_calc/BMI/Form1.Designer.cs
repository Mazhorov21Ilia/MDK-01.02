namespace _33.BMI_калькулятор
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
            this.height = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.trackBarBMI = new System.Windows.Forms.TrackBar();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonOtmena = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelves = new System.Windows.Forms.Label();
            this.label1BMI = new System.Windows.Forms.Label();
            this.pictureBoxUnderWeight = new System.Windows.Forms.PictureBox();
            this.pictureBoxWoman = new System.Windows.Forms.PictureBox();
            this.pictureBoxMan = new System.Windows.Forms.PictureBox();
            this.pictureBoxHealthy = new System.Windows.Forms.PictureBox();
            this.pictureBoxOverWeight = new System.Windows.Forms.PictureBox();
            this.pictureBoxObese = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBMI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnderWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWoman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealthy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOverWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObese)).BeginInit();
            this.SuspendLayout();
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height.Location = new System.Drawing.Point(28, 212);
            this.height.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(43, 17);
            this.height.TabIndex = 0;
            this.height.Text = "Рост:";
            this.height.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight.Location = new System.Drawing.Point(28, 243);
            this.weight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(36, 17);
            this.weight.TabIndex = 1;
            this.weight.Text = "Вес:";
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBMI.Location = new System.Drawing.Point(292, 212);
            this.labelBMI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(42, 17);
            this.labelBMI.TabIndex = 7;
            this.labelBMI.Text = "ИМТ:";
            // 
            // trackBarBMI
            // 
            this.trackBarBMI.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarBMI.LargeChange = 0;
            this.trackBarBMI.Location = new System.Drawing.Point(258, 259);
            this.trackBarBMI.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarBMI.Maximum = 50;
            this.trackBarBMI.Name = "trackBarBMI";
            this.trackBarBMI.Size = new System.Drawing.Size(295, 45);
            this.trackBarBMI.TabIndex = 11;
            this.trackBarBMI.TabStop = false;
            this.trackBarBMI.Value = 18;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(26, 281);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Считать";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonOtmena
            // 
            this.buttonOtmena.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonOtmena.Location = new System.Drawing.Point(116, 281);
            this.buttonOtmena.Name = "buttonOtmena";
            this.buttonOtmena.Size = new System.Drawing.Size(75, 23);
            this.buttonOtmena.TabIndex = 13;
            this.buttonOtmena.Text = "Очистить";
            this.buttonOtmena.UseVisualStyleBackColor = false;
            this.buttonOtmena.Click += new System.EventHandler(this.buttonOtmena_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHeight.Location = new System.Drawing.Point(85, 211);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 21);
            this.textBoxHeight.TabIndex = 14;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxHeight_TextChanged);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWeight.Location = new System.Drawing.Point(85, 242);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 21);
            this.textBoxWeight.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(266, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(365, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SandyBrown;
            this.label3.Location = new System.Drawing.Point(399, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(427, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 22;
            // 
            // labelves
            // 
            this.labelves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelves.Location = new System.Drawing.Point(330, 180);
            this.labelves.Name = "labelves";
            this.labelves.Size = new System.Drawing.Size(162, 24);
            this.labelves.TabIndex = 23;
            this.labelves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1BMI
            // 
            this.label1BMI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1BMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1BMI.Location = new System.Drawing.Point(339, 209);
            this.label1BMI.Name = "label1BMI";
            this.label1BMI.Size = new System.Drawing.Size(143, 23);
            this.label1BMI.TabIndex = 24;
            this.label1BMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxUnderWeight
            // 
            this.pictureBoxUnderWeight.Image = global::_33.BMI_калькулятор.Properties.Resources.bmi_underweight_icon;
            this.pictureBoxUnderWeight.Location = new System.Drawing.Point(368, 34);
            this.pictureBoxUnderWeight.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUnderWeight.Name = "pictureBoxUnderWeight";
            this.pictureBoxUnderWeight.Size = new System.Drawing.Size(85, 144);
            this.pictureBoxUnderWeight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUnderWeight.TabIndex = 26;
            this.pictureBoxUnderWeight.TabStop = false;
            // 
            // pictureBoxWoman
            // 
            this.pictureBoxWoman.Image = global::_33.BMI_калькулятор.Properties.Resources._1200px_Toilet_women_svg;
            this.pictureBoxWoman.Location = new System.Drawing.Point(140, 34);
            this.pictureBoxWoman.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxWoman.Name = "pictureBoxWoman";
            this.pictureBoxWoman.Size = new System.Drawing.Size(85, 144);
            this.pictureBoxWoman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWoman.TabIndex = 5;
            this.pictureBoxWoman.TabStop = false;
            this.pictureBoxWoman.Click += new System.EventHandler(this.pictureBoxWoman_Click);
            // 
            // pictureBoxMan
            // 
            this.pictureBoxMan.Image = global::_33.BMI_калькулятор.Properties.Resources.man_toilet_icon;
            this.pictureBoxMan.Location = new System.Drawing.Point(50, 34);
            this.pictureBoxMan.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMan.Name = "pictureBoxMan";
            this.pictureBoxMan.Size = new System.Drawing.Size(62, 144);
            this.pictureBoxMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMan.TabIndex = 4;
            this.pictureBoxMan.TabStop = false;
            this.pictureBoxMan.Click += new System.EventHandler(this.pictureBoxMan_Click);
            // 
            // pictureBoxHealthy
            // 
            this.pictureBoxHealthy.Image = global::_33.BMI_калькулятор.Properties.Resources.bmi_healthy_icon;
            this.pictureBoxHealthy.Location = new System.Drawing.Point(368, 34);
            this.pictureBoxHealthy.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxHealthy.Name = "pictureBoxHealthy";
            this.pictureBoxHealthy.Size = new System.Drawing.Size(85, 144);
            this.pictureBoxHealthy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHealthy.TabIndex = 27;
            this.pictureBoxHealthy.TabStop = false;
            // 
            // pictureBoxOverWeight
            // 
            this.pictureBoxOverWeight.Image = global::_33.BMI_калькулятор.Properties.Resources.bmi_overweight_icon;
            this.pictureBoxOverWeight.Location = new System.Drawing.Point(368, 34);
            this.pictureBoxOverWeight.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxOverWeight.Name = "pictureBoxOverWeight";
            this.pictureBoxOverWeight.Size = new System.Drawing.Size(85, 144);
            this.pictureBoxOverWeight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOverWeight.TabIndex = 28;
            this.pictureBoxOverWeight.TabStop = false;
            // 
            // pictureBoxObese
            // 
            this.pictureBoxObese.Image = global::_33.BMI_калькулятор.Properties.Resources.bmi_obese_icon;
            this.pictureBoxObese.Location = new System.Drawing.Point(368, 34);
            this.pictureBoxObese.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxObese.Name = "pictureBoxObese";
            this.pictureBoxObese.Size = new System.Drawing.Size(85, 144);
            this.pictureBoxObese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxObese.TabIndex = 29;
            this.pictureBoxObese.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 341);
            this.Controls.Add(this.pictureBoxObese);
            this.Controls.Add(this.pictureBoxOverWeight);
            this.Controls.Add(this.pictureBoxHealthy);
            this.Controls.Add(this.pictureBoxUnderWeight);
            this.Controls.Add(this.label1BMI);
            this.Controls.Add(this.labelves);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.buttonOtmena);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.trackBarBMI);
            this.Controls.Add(this.labelBMI);
            this.Controls.Add(this.pictureBoxWoman);
            this.Controls.Add(this.pictureBoxMan);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBMI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnderWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWoman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHealthy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOverWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObese)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.PictureBox pictureBoxMan;
        private System.Windows.Forms.PictureBox pictureBoxWoman;
        private System.Windows.Forms.Label labelBMI;
        private System.Windows.Forms.TrackBar trackBarBMI;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonOtmena;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelves;
        private System.Windows.Forms.Label label1BMI;
        private System.Windows.Forms.PictureBox pictureBoxUnderWeight;
        private System.Windows.Forms.PictureBox pictureBoxHealthy;
        private System.Windows.Forms.PictureBox pictureBoxOverWeight;
        private System.Windows.Forms.PictureBox pictureBoxObese;
    }
}

