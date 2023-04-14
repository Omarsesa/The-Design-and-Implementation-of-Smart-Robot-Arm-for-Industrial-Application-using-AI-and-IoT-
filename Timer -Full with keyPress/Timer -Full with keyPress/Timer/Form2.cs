using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Timer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private DateTime datetime;
        private string in_data;

        string result;
        string intresult;
        SerialPort port = new SerialPort("COM8", 115200, Parity.None, 8, StopBits.One);
        SerialPort portSend = new SerialPort("COM13", 115200, Parity.None, 8, StopBits.One);


        private void Form2_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("COM1");
            comboBox1.Items.Add("COM2");
            comboBox1.Items.Add("COM3");
            comboBox1.Items.Add("COM4");
            comboBox1.Items.Add("COM5");
            comboBox1.Items.Add("COM6");
            comboBox1.Items.Add("COM7");
            comboBox1.Items.Add("COM8");
            comboBox1.Items.Add("COM9");
            comboBox1.Items.Add("COM10");
            comboBox1.Items.Add("COM11");
            comboBox1.Items.Add("COM12");
            comboBox1.Items.Add("COM13");
        }
        private void port_dataRecived(object sender, SerialDataReceivedEventArgs e)
        {

            in_data = port.ReadLine();

            this.Invoke(new EventHandler(displaydata_event));
            /* hena if(awel rakem A) y7otly feh text box1
             
             
             */


        }
        int ip1, ip2, ip3, ip4, ip5, ip6, ip7;
        private void displaydata_event(object sender, EventArgs e)
        {

            datetime = DateTime.Now;
            result = in_data;
            string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
            if (in_data.Contains('A'))
            {
                intresult = result.Substring(2);
                textBox1.AppendText(time + "\t\t" + intresult + "\n");
                int data_value = Convert.ToInt32(intresult);
                progressBar1.Value = data_value;
                ip1 = data_value;
                label9.Text = data_value.ToString();
                /* 3malet check 3ala el motors value bel7rof we ba3ed keda 3amel substring we ba3ed keda 7welt
                 * el kiem l int 3alshan ast5edemha */
            }
            else if (in_data.Contains('B'))
            {
                intresult = result.Substring(2);
                textBox2.AppendText(time + "\t\t" + intresult + "\n");
                int data_value = Convert.ToInt32(intresult);
                progressBar2.Value = data_value;
                ip2 = data_value;
                label10.Text = data_value.ToString();
            }
            else if (in_data.Contains('C'))
            {
                intresult = result.Substring(2);
                textBox3.AppendText(time + "\t\t" + intresult + "\n");
                int data_value = Convert.ToInt32(intresult);
                progressBar3.Value = data_value;
                ip3 = data_value;
                label11.Text = data_value.ToString();
            }
            else if (in_data.Contains('D'))
            {
                intresult = result.Substring(2);
                textBox4.AppendText(time + "\t\t" + intresult + "\n");
                int data_value = Convert.ToInt32(intresult);
                progressBar4.Value = data_value;
                ip4= data_value;
                label12.Text = data_value.ToString();
            }
            else if (in_data.Contains('E'))
            {
                intresult = result.Substring(2);
                textBox5.AppendText(time + "\t\t" + intresult + "\n");
                int data_value = Convert.ToInt32(intresult);
                progressBar5.Value = data_value;
                ip5 = data_value;
                label13.Text = data_value.ToString();
            }
            else if (in_data.Contains('F'))
            {
                intresult = result.Substring(2);
                textBox6.AppendText(time + "\t\t" + intresult + "\n");
                int data_value = Convert.ToInt32(intresult);
                progressBar6.Value = data_value;
                ip6= data_value;
                label14.Text = data_value.ToString();
            }
            else if (in_data.Contains('G'))
            {
                intresult = result.Substring(2);
                textBox7.AppendText(time + "\t\t" + intresult + "\n");
                int data_value = Convert.ToInt32(intresult);
                progressBar7.Value = data_value;
                ip7 = data_value;
                label15.Text = data_value.ToString();
            }


////////////////////////////////////////////////////////////////////

        }

        private void button4_Click(object sender, EventArgs e)
        {
            port.PortName = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.DataReceived += port_dataRecived;
            try
            {
                port.Open();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (port.IsOpen==true)
                { port.Close(); }
                

            }
            catch (Exception ex2)
            {

                MessageBox.Show(ex2.Message, "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string pathfille = @"C:\Users\Sesa\Desktop\work1\timer\Timer -Full with keyPress\Timer -Full with keyPress\Timer -Full with keyPress";
                string filename = "Sesa0.txt";
                string filename1 = "Sesa1.txt";
                string filename2 = "Sesa2.txt";
                string filename3 = "Sesa3.txt";
                string filename4 = "Sesa4.txt";
                string filename5 = "Sesa5.txt";
                string filename6 = "Sesa6.txt";
                System.IO.File.WriteAllText(pathfille + filename, textBox1.Text);
                System.IO.File.WriteAllText(pathfille + filename1, textBox2.Text);
                System.IO.File.WriteAllText(pathfille + filename2, textBox3.Text);
                System.IO.File.WriteAllText(pathfille + filename3, textBox4.Text);
                System.IO.File.WriteAllText(pathfille + filename4, textBox5.Text);
                System.IO.File.WriteAllText(pathfille + filename5, textBox6.Text);
                System.IO.File.WriteAllText(pathfille + filename6, textBox7.Text);
                MessageBox.Show("Data has been saved to " + pathfille, "Save File");

            }
            catch (Exception ex3)
            {

                MessageBox.Show(ex3.Message, "Error");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            if (portSend.IsOpen == true)
            {
                portSend.Close();
            }

        }
        int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            
            //button6.Visible = false;
           // button7.Visible = true;
            if (textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" ||
               textBox12.Text == "")
            { MessageBox.Show("Fill text box with values of potentiometers"); }
            else
            {
                c1 = 0;
                c2 = 0;
                c3 = 0;
                c4 = 0;
                c5 = 0;
                c6 = 0;



               
                    timer1.Enabled = true;
                   // timer3.Enabled = true;
                    timer5.Enabled = true;
                    timer7.Enabled = true;
                    timer9.Enabled = true;
                    



            }


            
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
      
            if (int.Parse(label9.Text) < int.Parse(textBox8.Text))
            {
            portSend.Write("I");
             portSend.Write("A");
            }
            else {timer1.Enabled=false;}
            
        }
     
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (int.Parse(label10.Text) < int.Parse(textBox9.Text))
            {
                portSend.Write("k");
                portSend.Write("B");
              
            }
            else { timer3.Enabled = false; }
            
        }
       

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (int.Parse(label11.Text) < int.Parse(textBox10.Text))
            {
                portSend.Write("M");
                portSend.Write("C");
               
            }
            else { timer5.Enabled = false; }
            
            
        }
      

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (int.Parse(label12.Text) < int.Parse(textBox11.Text))
            {
                portSend.Write("o");
                portSend.Write("D");
            }
            else { timer7.Enabled = false; }
            
        }
       

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (int.Parse(label13.Text) < int.Parse(textBox12.Text))
            {
                portSend.Write("q");
                portSend.Write("E");
            }
            else { timer9.Enabled = false; }
        }
       
        private void timer11_Tick(object sender, EventArgs e)
        {
            //if (c6 < 170 && portSend.IsOpen == true)// 5adt 3aded eloops el ana 3ayzeha men 3'ir loop
            //{
            //    c6++;
            //    portSend.Write("F");

            //}
            portSend.Write("F");
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
           
            try
            {
                if (portSend.IsOpen == true)
                {
                    portSend.Close();
                    timer1.Enabled = false;
                    timer3.Enabled = false;
                    timer5.Enabled = false;
                    timer7.Enabled = false;
                    timer9.Enabled = false;
                    timer11.Enabled = false;
                }
                
                /////////////////////////////////

                
            }
            catch (Exception e3)
            {

                MessageBox.Show(e3.Message, "Error"); ;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
                    
           
           
                c1 = 0;
                c2 = 0;
                c3 = 0;
                c4 = 0;
                c5 = 0;
                c6 = 0;

                timer2.Enabled = true;
           //   timer4.Enabled = true;
                timer6.Enabled = true;
                timer8.Enabled = true;
                timer10.Enabled = true;




        }

        private void button9_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            button8.Enabled = true;
            if (portSend.IsOpen == false)
            {
                portSend.Open();
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if ( 38 < (int.Parse(label9.Text))) 
            {
                portSend.Write("i");
                portSend.Write("A");
            }
            else { timer2.Enabled = false; }
        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {
            if  (74< (int.Parse(label10.Text)))
            {
                portSend.Write("K");
                portSend.Write("B");
            }
            else { timer4.Enabled = false; }
        }

        private void timer6_Tick_1(object sender, EventArgs e)
        {
            if  (26< (int.Parse(label11.Text)))
            {
                portSend.Write("m");
                portSend.Write("C");
            
            }
            else { timer6.Enabled = false; }
        }

        private void timer8_Tick_1(object sender, EventArgs e)
        {
            if  (21<(int.Parse(label12.Text)))
            {
                portSend.Write("O");
                portSend.Write("D");
            }
            else { timer8.Enabled = false; }
        }

        private void timer10_Tick_1(object sender, EventArgs e)
        {
            if  (51> (int.Parse(label13.Text)))
            {
                portSend.Write("Q");
                portSend.Write("E");
            }
            else { timer10.Enabled = false; }
        }
    }
}
