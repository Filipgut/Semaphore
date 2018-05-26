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
using System.Data.SqlClient;

namespace ArduinoTemperatura
{
    public partial class Form1 : Form
    {
        String motionSensorA="";
        String carSensor="";
        String pedestriansSensor="";
        String intermitentLEDSensor="";

        SqlConnection sql;
        int i;
        int j;
        int k;
        int l;
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            intermitentLEDTextBox.ReadOnly = true;
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


        private void timerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
                string x = carsTimer.Text.ToString();

                string y = pedestriansTimer.Text.ToString();
                string z = intermitentTimer.Text.ToString();

                string toReturn = x + " " + y + " " + z;

                serialPort1.Write(toReturn); //send 1 to Arduino
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;


            
             //datetime of the system when the record was added into database
             DateTime dataAdaugarii = DateTime.Now;

             //connecting to database
             sql = new SqlConnection();

             //add path where the database is saved
             sql.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stud\Documents\Lab5.mdf;Integrated Security=True;Connect Timeout=30";
             sql.Open();


             SqlCommand cmd  = new SqlCommand("SELECT Id FROM CarTable", sql);
             SqlCommand cmd2 = new SqlCommand("SELECT Id FROM MotionTable", sql);
             SqlCommand cmd3 = new SqlCommand("SELECT Id FROM PedestriansTable", sql);

             using (SqlDataReader dr = cmd.ExecuteReader())
             {
                 while (dr.Read())
                 {
                     //verify if the id of the table exists or not
                     if (dr["Id"].ToString() == null)
                     {
                         i = 1;

                     }
                     else
                     {
                         string sir;
                         sir = dr["Id"].ToString();
                         i = Convert.ToInt32(sir) + 1;
                     }
                 }
             }

             using (SqlDataReader dr2 = cmd2.ExecuteReader())
             {
                 while (dr2.Read())
                 {
                     //verify if the id of the table exists or not
                     if (dr2["Id"].ToString() == null)
                     {
                         j = 1;

                     }
                     else
                     {
                         string sir;
                         sir = dr2["Id"].ToString();
                         j = Convert.ToInt32(sir) + 1;
                     }
                 }
             }

             using (SqlDataReader dr3 = cmd3.ExecuteReader())
             {
                 while (dr3.Read())
                 {
                     //verify if the id of the table exists or not
                     if (dr3["Id"].ToString() == null)
                     {
                         k = 1;

                     }
                     else
                     {
                         string sir;
                         sir = dr3["Id"].ToString();
                         k = Convert.ToInt32(sir) + 1;
                     }
                 }
             }

             SqlCommand cmd1 = new SqlCommand();
             SqlCommand cmd12 = new SqlCommand();
             SqlCommand cmd13 = new SqlCommand();

             cmd1.Connection = sql;
             cmd12.Connection = sql;
             cmd13.Connection = sql;



            string comanda = string.Format("INSERT into CarTable VALUES (@Id, @Value, @Date)");
             string comanda2 = string.Format("INSERT into MotionTable VALUES (@Id, @Value, @Date)");
             string comanda3 = string.Format("INSERT into PedestriansTable VALUES (@Id, @Value, @Date)");
 
            String stringRead;
            stringRead = serialPort1.ReadLine().ToString();
            if (stringRead.Contains("C"))
            {
                if (stringRead.Contains("GREEN")) carSensor = "GREEN";
                if (stringRead.Contains("YELLOW")) carSensor = "YELLOW";
                if (stringRead.Contains("RED")) carSensor = "RED";
                   cmd1.Parameters.AddWithValue("@Id", i);
                   cmd1.Parameters.AddWithValue("@Value", carSensor.ToString());
                   cmd1.Parameters.AddWithValue("@Date", Convert.ToString(dataAdaugarii));
                cmd1.CommandText = comanda;
                cmd1.ExecuteNonQuery();
            }
            if (stringRead.Contains("P"))
            {
                if (stringRead.Contains("GREEN")) pedestriansSensor = "GREEN";
                if (stringRead.Contains("RED")) pedestriansSensor = "RED";

             cmd13.Parameters.AddWithValue("@Id", k);
                cmd13.Parameters.AddWithValue("@Value", pedestriansSensor.ToString());
                 cmd13.Parameters.AddWithValue("@Date", Convert.ToString(dataAdaugarii));
                cmd13.CommandText = comanda3;
                cmd13.ExecuteNonQuery();
            }


            if (stringRead.Contains("X"))
            {
                Console.WriteLine("ION HELLO");
                if(stringRead.Contains("ION")) intermitentLEDSensor = "ON";
                if (stringRead.Contains("IOFF")) intermitentLEDSensor = "OFF";
            }
          
            if (stringRead.Contains("Q"))
            {
                if(stringRead.Contains("ON"))  motionSensorA = "Earthquake detected";
                if (stringRead.Contains("OFF")) motionSensorA = "Earthquake not detected";
                cmd12.Parameters.AddWithValue("@Id", j);
                cmd12.Parameters.AddWithValue("@Value", motionSensorA.ToString());
                cmd12.Parameters.AddWithValue("@Date", Convert.ToString(dataAdaugarii));
                cmd12.CommandText = comanda2;
                cmd12.ExecuteNonQuery();
            }
        
        






        

        

        


            //ON UI:
            intermitentLEDTextBox.Text = intermitentLEDSensor.ToString();
            motionTextBox.Text         = motionSensorA.ToString();
            carsColor.Text             = carSensor.ToString();
            pedestriansColor.Text      = pedestriansSensor.ToString();


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

        private void humidityTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
