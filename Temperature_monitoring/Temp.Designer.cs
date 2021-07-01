namespace Temperature_monitoring
{
    partial class Temp
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
            this.Vid = new System.Windows.Forms.Label();
            this.Vid1 = new System.Windows.Forms.TextBox();
            this.Temp_max = new System.Windows.Forms.Label();
            this.Temp_min = new System.Windows.Forms.Label();
            this.Temp_max1 = new System.Windows.Forms.TextBox();
            this.Temp_min1 = new System.Windows.Forms.TextBox();
            this.Time_max = new System.Windows.Forms.Label();
            this.Time_max1 = new System.Windows.Forms.TextBox();
            this.Time_min1 = new System.Windows.Forms.TextBox();
            this.Time_min = new System.Windows.Forms.Label();
            this.Data_time2 = new System.Windows.Forms.DateTimePicker();
            this.Data_time1 = new System.Windows.Forms.TextBox();
            this.Data_time = new System.Windows.Forms.Label();
            this.Temp_fish = new System.Windows.Forms.Label();
            this.Temp_fish1 = new System.Windows.Forms.TextBox();
            this.Raschet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vid
            // 
            this.Vid.AutoSize = true;
            this.Vid.Location = new System.Drawing.Point(48, 18);
            this.Vid.Name = "Vid";
            this.Vid.Size = new System.Drawing.Size(101, 13);
            this.Vid.TabIndex = 0;
            this.Vid.Text = "Введите вид рыбы";
            // 
            // Vid1
            // 
            this.Vid1.Location = new System.Drawing.Point(51, 34);
            this.Vid1.Name = "Vid1";
            this.Vid1.Size = new System.Drawing.Size(100, 20);
            this.Vid1.TabIndex = 1;
            // 
            // Temp_max
            // 
            this.Temp_max.AutoSize = true;
            this.Temp_max.Location = new System.Drawing.Point(48, 57);
            this.Temp_max.Name = "Temp_max";
            this.Temp_max.Size = new System.Drawing.Size(196, 13);
            this.Temp_max.TabIndex = 2;
            this.Temp_max.Text = "Введите максимальную температуру";
            // 
            // Temp_min
            // 
            this.Temp_min.AutoSize = true;
            this.Temp_min.Location = new System.Drawing.Point(48, 106);
            this.Temp_min.Name = "Temp_min";
            this.Temp_min.Size = new System.Drawing.Size(190, 13);
            this.Temp_min.TabIndex = 3;
            this.Temp_min.Text = "Введите минимальную температуру";
            this.Temp_min.Click += new System.EventHandler(this.Temp_min_Click);
            // 
            // Temp_max1
            // 
            this.Temp_max1.Location = new System.Drawing.Point(51, 76);
            this.Temp_max1.Name = "Temp_max1";
            this.Temp_max1.Size = new System.Drawing.Size(100, 20);
            this.Temp_max1.TabIndex = 4;
            this.Temp_max1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Temp_min1
            // 
            this.Temp_min1.Location = new System.Drawing.Point(51, 129);
            this.Temp_min1.Name = "Temp_min1";
            this.Temp_min1.Size = new System.Drawing.Size(100, 20);
            this.Temp_min1.TabIndex = 5;
            // 
            // Time_max
            // 
            this.Time_max.AutoSize = true;
            this.Time_max.Location = new System.Drawing.Point(369, 57);
            this.Time_max.Name = "Time_max";
            this.Time_max.Size = new System.Drawing.Size(290, 13);
            this.Time_max.TabIndex = 6;
            this.Time_max.Text = "Введите время максимально допустимой температуры";
            this.Time_max.Click += new System.EventHandler(this.label1_Click);
            // 
            // Time_max1
            // 
            this.Time_max1.Location = new System.Drawing.Point(372, 76);
            this.Time_max1.Name = "Time_max1";
            this.Time_max1.Size = new System.Drawing.Size(100, 20);
            this.Time_max1.TabIndex = 7;
            // 
            // Time_min1
            // 
            this.Time_min1.Location = new System.Drawing.Point(372, 129);
            this.Time_min1.Name = "Time_min1";
            this.Time_min1.Size = new System.Drawing.Size(100, 20);
            this.Time_min1.TabIndex = 8;
            // 
            // Time_min
            // 
            this.Time_min.AutoSize = true;
            this.Time_min.Location = new System.Drawing.Point(369, 106);
            this.Time_min.Name = "Time_min";
            this.Time_min.Size = new System.Drawing.Size(284, 13);
            this.Time_min.TabIndex = 9;
            this.Time_min.Text = "Введите время минимально допустимой температуры";
            // 
            // Data_time2
            // 
            this.Data_time2.Location = new System.Drawing.Point(51, 194);
            this.Data_time2.Name = "Data_time2";
            this.Data_time2.Size = new System.Drawing.Size(200, 20);
            this.Data_time2.TabIndex = 10;
            this.Data_time2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Data_time1
            // 
            this.Data_time1.Location = new System.Drawing.Point(257, 194);
            this.Data_time1.Name = "Data_time1";
            this.Data_time1.Size = new System.Drawing.Size(100, 20);
            this.Data_time1.TabIndex = 11;
            // 
            // Data_time
            // 
            this.Data_time.AutoSize = true;
            this.Data_time.Location = new System.Drawing.Point(48, 165);
            this.Data_time.Name = "Data_time";
            this.Data_time.Size = new System.Drawing.Size(285, 13);
            this.Data_time.TabIndex = 12;
            this.Data_time.Text = "Введите дату и время начала измерения температуры";
            // 
            // Temp_fish
            // 
            this.Temp_fish.AutoSize = true;
            this.Temp_fish.Location = new System.Drawing.Point(48, 227);
            this.Temp_fish.Name = "Temp_fish";
            this.Temp_fish.Size = new System.Drawing.Size(105, 13);
            this.Temp_fish.TabIndex = 13;
            this.Temp_fish.Text = "Введите температу";
            // 
            // Temp_fish1
            // 
            this.Temp_fish1.Location = new System.Drawing.Point(51, 253);
            this.Temp_fish1.Name = "Temp_fish1";
            this.Temp_fish1.Size = new System.Drawing.Size(100, 20);
            this.Temp_fish1.TabIndex = 14;
            // 
            // Raschet
            // 
            this.Raschet.Location = new System.Drawing.Point(51, 294);
            this.Raschet.Name = "Raschet";
            this.Raschet.Size = new System.Drawing.Size(75, 23);
            this.Raschet.TabIndex = 15;
            this.Raschet.Text = "Расчитать";
            this.Raschet.UseVisualStyleBackColor = true;
            this.Raschet.Click += new System.EventHandler(this.Raschet_Click);
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Raschet);
            this.Controls.Add(this.Temp_fish1);
            this.Controls.Add(this.Temp_fish);
            this.Controls.Add(this.Data_time);
            this.Controls.Add(this.Data_time1);
            this.Controls.Add(this.Data_time2);
            this.Controls.Add(this.Time_min);
            this.Controls.Add(this.Time_min1);
            this.Controls.Add(this.Time_max1);
            this.Controls.Add(this.Time_max);
            this.Controls.Add(this.Temp_min1);
            this.Controls.Add(this.Temp_max1);
            this.Controls.Add(this.Temp_min);
            this.Controls.Add(this.Temp_max);
            this.Controls.Add(this.Vid1);
            this.Controls.Add(this.Vid);
            this.Name = "Temp";
            this.Text = "Temp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Vid;
        private System.Windows.Forms.TextBox Vid1;
        private System.Windows.Forms.Label Temp_max;
        private System.Windows.Forms.Label Temp_min;
        private System.Windows.Forms.TextBox Temp_max1;
        private System.Windows.Forms.TextBox Temp_min1;
        private System.Windows.Forms.Label Time_max;
        private System.Windows.Forms.TextBox Time_max1;
        private System.Windows.Forms.TextBox Time_min1;
        private System.Windows.Forms.Label Time_min;
        private System.Windows.Forms.DateTimePicker Data_time2;
        private System.Windows.Forms.TextBox Data_time1;
        private System.Windows.Forms.Label Data_time;
        private System.Windows.Forms.Label Temp_fish;
        private System.Windows.Forms.TextBox Temp_fish1;
        private System.Windows.Forms.Button Raschet;
    }
}

