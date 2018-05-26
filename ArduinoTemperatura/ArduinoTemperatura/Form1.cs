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
        String Eqk="";
        String carS="";
        String pedestrianS="";
        String intermitentS="";

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Port not open!");
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
             sql.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Catal\Documents\Interserction.mdf;Integrated Security=True;Connect Timeout=30";
             sql.Open();


             SqlCommand cmd  = new SqlCommand("SELECT IdCars FROM Semaphores", sql);
             SqlCommand cmd2 = new SqlCommand("SELECT IdInter FROM Semaphores", sql);
             SqlCommand cmd3 = new SqlCommand("SELECT IdPed FROM Semaphores", sql);
             SqlCommand cmd4 = new SqlCommand("SELECT IdEqk FROM Semaphores", sql);

            using (SqlDataReader dr = cmd.ExecuteReader())
             {
                 while (dr.Read())
                 {
                     //verify if the id of the table exists or not
                     if (dr["IdCars"].ToString() == null)
                     {
                         i = 1;

                     }
                     else
                     {
                         string sir;
                         sir = dr["IdCars"].ToString();
                         i = Convert.ToInt32(sir) + 1;
                     }
                 }
             }

             using (SqlDataReader dr2 = cmd2.ExecuteReader())
             {
                 while (dr2.Read())
                 {
                     //verify if the id of the table exists or not
                     if (dr2["IdInter"].ToString() == null)
                     {
                         j = 1;

                     }
                     else
                     {
                         string sir;
                         sir = dr2["IdInter"].ToString();
                         j = Convert.ToInt32(sir) + 1;
                     }
                 }
             }

             using (SqlDataReader dr3 = cmd3.ExecuteReader())
             {
                 while (dr3.Read())
                 {
                     //verify if the id of the table exists or not
                     if (dr3["IdPed"].ToString() == null)
                     {
                         k = 1;

                     }
                     else
                     {
                         string sir;
                         sir = dr3["IdPed"].ToString();
                         k = Convert.ToInt32(sir) + 1;
                     }
                 }
             }

            using (SqlDataReader dr4 = cmd4.ExecuteReader())
            {
                while (dr4.Read())
                {
                    //verify if the id of the table exists or not
                    if (dr4["IdEqk"].ToString() == null)
                    {
                        l = 1;

                    }
                    else
                    {
                        string sir;
                        sir = dr4["IdEqk"].ToString();
                        l = Convert.ToInt32(sir) + 1;
                    }
                }
            }

            SqlCommand cmd1 = new SqlCommand();
            SqlCommand cmd12 = new SqlCommand();
            SqlCommand cmd13 = new SqlCommand();
            SqlCommand cmd14 = new SqlCommand();

            cmd1.Connection = sql;
            cmd12.Connection = sql;
            cmd13.Connection = sql;
            cmd14.Connection = sql;



            string comanda = string.Format("INSERT into Intersection VALUES (@IdCars, @ValueCars, @Date)");
            string comanda2 = string.Format("INSERT into Intersection VALUES (@IdInter, @ValueInter, @Date)");
            string comanda3 = string.Format("INSERT into Intersection VALUES (@IdPed, @ValuePed, @Date)");
            string comanda4 = string.Format("INSERT into Intersection VALUES (@IdEqk, @ValueEqk, @Date)");
 
            String stringRead;
            stringRead = serialPort1.ReadLine().ToString();
            if (stringRead.Contains("CarS"))
            {
                if (stringRead.Contains("GREEN")) carS = "GREEN";
                if (stringRead.Contains("YELLOW")) carS = "YELLOW";
                if (stringRead.Contains("RED")) carS = "RED";
                   cmd1.Parameters.AddWithValue("@IdCars", i);
                   cmd1.Parameters.AddWithValue("@ValueCars", carS.ToString());
                   cmd1.Parameters.AddWithValue("@Date", Convert.ToString(dataAdaugarii));
                cmd1.CommandText = comanda;
                cmd1.ExecuteNonQuery();
            }
            if (stringRead.Contains("Pedestrian"))
            {
                if (stringRead.Contains("ON")) pedestrianS = "GREEN";
                if (stringRead.Contains("OFF")) pedestrianS = "RED";

                cmd13.Parameters.AddWithValue("@IdPed", k);
                cmd13.Parameters.AddWithValue("@ValuePed", pedestrianS.ToString());
                cmd13.Parameters.AddWithValue("@Date", Convert.ToString(dataAdaugarii));
                cmd13.CommandText = comanda3;
                cmd13.ExecuteNonQuery();
            }


            if (stringRead.Contains("IntermitentG"))
            {
                if(stringRead.Contains("ON")) intermitentS = "ON";
                if (stringRead.Contains("OFF")) intermitentS = "OFF";
                cmd14.Parameters.AddWithValue("@IdInter", k);
                cmd14.Parameters.AddWithValue("@ValueInter", pedestrianS.ToString());
                cmd14.Parameters.AddWithValue("@Date", Convert.ToString(dataAdaugarii));
                cmd14.CommandText = comanda2;
                cmd14.ExecuteNonQuery();

            }
          
            if (stringRead.Contains("EarthQ"))
            {
                if(stringRead.Contains("ON"))  Eqk = "Earthquake detected";
                if (stringRead.Contains("OFF")) Eqk = "Earthquake not detected";
                cmd12.Parameters.AddWithValue("@IdEqk", j);
                cmd12.Parameters.AddWithValue("@ValueEqk", Eqk.ToString());
                cmd12.Parameters.AddWithValue("@Date", Convert.ToString(dataAdaugarii));
                cmd12.CommandText = comanda4;
                cmd12.ExecuteNonQuery();
            }
        
        






        

        

        


            //ON UI:
            intermitentLEDTextBox.Text = intermitentS.ToString();
            motionTextBox.Text         = Eqk.ToString();
            carsColor.Text             = carS.ToString();
            pedestriansColor.Text      = pedestrianS.ToString();


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

        private void intermitentLED_Click(object sender, EventArgs e)
        {

        }

        private void motionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
