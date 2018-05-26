namespace ArduinoTemperatura
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cars = new System.Windows.Forms.Label();
            this.carsColor = new System.Windows.Forms.TextBox();
            this.pedestrians = new System.Windows.Forms.Label();
            this.pedestriansColor = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.intermitentLED = new System.Windows.Forms.Label();
            this.intermitentLEDTextBox = new System.Windows.Forms.TextBox();
            this.motionLabel = new System.Windows.Forms.Label();
            this.motionTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select ports:";
            // 
            // cars
            // 
            this.cars.AutoSize = true;
            this.cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars.Location = new System.Drawing.Point(16, 193);
            this.cars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars.Name = "cars";
            this.cars.Size = new System.Drawing.Size(75, 29);
            this.cars.TabIndex = 0;
            this.cars.Text = "Cars :";
            // 
            // carsColor
            // 
            this.carsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsColor.Location = new System.Drawing.Point(307, 193);
            this.carsColor.Margin = new System.Windows.Forms.Padding(4);
            this.carsColor.Name = "carsColor";
            this.carsColor.Size = new System.Drawing.Size(265, 34);
            this.carsColor.TabIndex = 6;
            this.carsColor.TextChanged += new System.EventHandler(this.humidityTextBox_TextChanged);
            // 
            // pedestrians
            // 
            this.pedestrians.AutoSize = true;
            this.pedestrians.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedestrians.Location = new System.Drawing.Point(16, 235);
            this.pedestrians.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pedestrians.Name = "pedestrians";
            this.pedestrians.Size = new System.Drawing.Size(153, 29);
            this.pedestrians.TabIndex = 0;
            this.pedestrians.Text = "Pedestrians :";
            // 
            // pedestriansColor
            // 
            this.pedestriansColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedestriansColor.Location = new System.Drawing.Point(307, 235);
            this.pedestriansColor.Margin = new System.Windows.Forms.Padding(4);
            this.pedestriansColor.Name = "pedestriansColor";
            this.pedestriansColor.Size = new System.Drawing.Size(265, 34);
            this.pedestriansColor.TabIndex = 6;
            this.pedestriansColor.TextChanged += new System.EventHandler(this.humidityTextBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 43);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "SELECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 101);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "START READING";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 338);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "STOP READING";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temperature:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(142, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 34);
            this.textBox1.TabIndex = 6;
            // 
            // intermitentLED
            // 
            this.intermitentLED.AutoSize = true;
            this.intermitentLED.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intermitentLED.Location = new System.Drawing.Point(16, 151);
            this.intermitentLED.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.intermitentLED.Name = "intermitentLED";
            this.intermitentLED.Size = new System.Drawing.Size(249, 29);
            this.intermitentLED.TabIndex = 5;
            this.intermitentLED.Text = "Intermitent Right Cars:";
            // 
            // intermitentLEDTextBox
            // 
            this.intermitentLEDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intermitentLEDTextBox.Location = new System.Drawing.Point(307, 151);
            this.intermitentLEDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.intermitentLEDTextBox.Name = "intermitentLEDTextBox";
            this.intermitentLEDTextBox.Size = new System.Drawing.Size(265, 34);
            this.intermitentLEDTextBox.TabIndex = 6;
            this.intermitentLEDTextBox.TextChanged += new System.EventHandler(this.humidityTextBox_TextChanged);
            // 
            // motionLabel
            // 
            this.motionLabel.AutoSize = true;
            this.motionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motionLabel.Location = new System.Drawing.Point(16, 277);
            this.motionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.motionLabel.Name = "motionLabel";
            this.motionLabel.Size = new System.Drawing.Size(224, 29);
            this.motionLabel.TabIndex = 5;
            this.motionLabel.Text = "Earthquake Sensor:";
            // 
            // motionTextBox
            // 
            this.motionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motionTextBox.Location = new System.Drawing.Point(307, 277);
            this.motionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.motionTextBox.Name = "motionTextBox";
            this.motionTextBox.Size = new System.Drawing.Size(265, 34);
            this.motionTextBox.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 386);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intermitentLED);
            this.Controls.Add(this.intermitentLEDTextBox);
            this.Controls.Add(this.motionLabel);
            this.Controls.Add(this.motionTextBox);
            this.Controls.Add(this.cars);
            this.Controls.Add(this.carsColor);
            this.Controls.Add(this.pedestrians);
            this.Controls.Add(this.pedestriansColor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label cars;
        private System.Windows.Forms.TextBox carsColor;
        private System.Windows.Forms.Label pedestrians;
        private System.Windows.Forms.TextBox pedestriansColor;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label intermitentLED;
        private System.Windows.Forms.TextBox intermitentLEDTextBox;
        private System.Windows.Forms.Label motionLabel;
        private System.Windows.Forms.TextBox motionTextBox;

    }
}

