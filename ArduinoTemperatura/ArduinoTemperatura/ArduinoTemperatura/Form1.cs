using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace ArduinoTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            //takes available ports and put into comboBox
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
            
        }
        //when click on Select button
        private void button1_Click(object sender, EventArgs e)
        {
            string x = comboBox1.SelectedItem.ToString();
            serialPort1.PortName = x;
            serialPort1.BaudRate = 9600;
            MessageBox.Show("Port was selected!");
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            String dataFromArduino1 = serialPort1.ReadLine().ToString();
            int found = dataFromArduino1.IndexOf(",");
            textBox1.Text = dataFromArduino1.Substring(0,found) + " °C";
            textBox2.Text = dataFromArduino1.Substring(found + 1);
        }

        //when click on button Start reading
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            try
            {
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("The port is not open");
            }
        }

        //when click on button Stop reading
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            serialPort1.Close();
            textBox1.Text = " ";
        }
    }
}
