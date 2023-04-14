using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0;



        SerialPort port = new SerialPort("COM4", 115200, Parity.None, 8, StopBits.One);
        private void sendport_BT(object sender, EventArgs e)
        {
            
            port.Open();

            MessageBox.Show("Done");
        }
        private void Test_BT(object sender, EventArgs e)
        {
            try
            {
                port.Open();
                port.Write(textBox13.Text);
                port.Close();
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message, "error");
            }

        }
        private void Start_BT(object sender, EventArgs e)
        {
            button1.Enabled = false;

            c1 = 0;
            c2 = 0;
            c3 = 0;
            c4 = 0;
            c5 = 0;
            c6 = 0;
            

            try
            {
                
                if (port.IsOpen)
                {   
                    port.Close();

                }
                port.Open();
                ///////////////////////////////////////////////////
                if (radioButton14.Checked)
                {
                    E13.Checked = true;
                    E12.Checked = true;
                    E11.Checked = true;
                    E10.Checked = true;
                    E9.Checked = true;
                    E8.Checked = true;
                                    
                }
                else if (radioButton13.Checked)
                {
                    E13.Checked = false;
                    E12.Checked = false;                    
                    E11.Checked = false;
                    E10.Checked = false;
                    E9.Checked = false;
                    E8.Checked = false;
                }
                if (E13.Checked)
                {
                    port.Write("H");

                }
                else
                {
                    port.Write("h");
                    timer1.Enabled = true;

                }
                if (radioButton1.Checked)
                {
                    port.Write("I");
                }
                else if (radioButton2.Checked)
                {
                    port.Write("i");
                }
                if (E12.Checked)
                {
                    port.Write("J");

                }
                else
                {
                    port.Write("j");
                    timer3.Enabled = true;
                }
                if (radioButton3.Checked)
                {
                    port.Write("K");
                }
                else if (radioButton4.Checked)
                {
                    port.Write("k");
                }
                if (E11.Checked)
                {
                    port.Write("L");

                }
                else
                {
                    port.Write("l");
                    timer5.Enabled = true;
                }
                if (radioButton5.Checked)
                {
                    port.Write("M");
                }
                else if (radioButton6.Checked)
                {
                    port.Write("m");
                }
                if (E10.Checked)
                {
                    port.Write("N");

                }
                else
                {
                    port.Write("n");
                    timer7.Enabled = true;
                }
                if (radioButton7.Checked)
                {
                    port.Write("O");
                }
                else if (radioButton8.Checked)
                {
                    port.Write("o");
                }
                if (E9.Checked)
                {
                    port.Write("P");

                }
                else
                {
                    port.Write("p");
                    timer9.Enabled = true;
                }
                if  (radioButton9.Checked)
                {
                    port.Write("Q");
                }
                else if (radioButton10.Checked)
                {
                    port.Write("q");
                }
                if (E8.Checked)
                {
                    port.Write("R");

                }
                else
                {
                    port.Write("r");
                    timer11.Enabled = true;

                }
                if (radioButton11.Checked)
                {
                    port.Write("S");
                }
                else if (radioButton12.Checked)
                {
                    port.Write("s");
                }
              
                //////////////////////////////////////////
                timer1.Interval = int.Parse(textBox2.Text);//ms

                timer3.Interval = int.Parse(textBox5.Text);//ms

                timer5.Interval = int.Parse(textBox8.Text);//ms

                timer7.Interval = int.Parse(textBox11.Text);//ms

                ///////////////
                timer9.Interval = int.Parse(textBox18.Text);//ms

                timer11.Interval = int.Parse(textBox15.Text);//ms

                

                //hainfez deh el awel
               
                
                ////////////////////////////////////////////////////////////////// Checkboxes
            }
            catch (Exception e2)
            {

                MessageBox.Show(e2.Message, "Error"); ;
            }

        }
        private void Close_BT(object sender, EventArgs e)
        {
            button1.Enabled = true;
            try
            {
                timer1.Enabled = false;
                timer3.Enabled = false;
                timer5.Enabled = false;
                timer7.Enabled = false;
                timer9.Enabled = false;
                timer11.Enabled = false;
                timer13.Enabled = false;
                /////////////////////////////////

                port.Close();
            }
            catch (Exception e3)
            {

                MessageBox.Show(e3.Message, "Error"); ;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c1 < int.Parse(textBox1.Text))// 5adt 3aded eloops el ana 3ayzeha men 3'ir loop
            {
               c1++;
                port.Write("A");

            }

        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (c2 < int.Parse(textBox6.Text))// 5adt 3aded eloops el ana 3ayzeha men 3'ir loop
            {
                c2++;
                port.Write("B");

            }
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (c3 < int.Parse(textBox9.Text))// 5adt 3aded eloops el ana 3ayzeha men 3'ir loop
            {
                c3++;
                port.Write("C");

            }

        }
        private void timer7_Tick(object sender, EventArgs e)
        {
            if (c4 < int.Parse(textBox12.Text))// 5adt 3aded eloops el ana 3ayzeha men 3'ir loop
            {
                c4++;
                port.Write("D");
            }
        }
        private void timer9_Tick(object sender, EventArgs e)
        {
            if (c5 < int.Parse(textBox19.Text))// 5adt 3aded eloops el ana 3ayzeha men 3'ir loop
            {
                c5++;
                port.Write("E");

            }
        }
        private void timer11_Tick(object sender, EventArgs e)
        {
            if (c6 < int.Parse(textBox16.Text))// 5adt 3aded eloops el ana 3ayzeha men 3'ir loop
            {
                c6++;
                port.Write("F");

            }
        }
     

        private void Form1_Load(object sender, EventArgs e)
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
            
            textBox1.Text = textBox2.Text = textBox5.Text = textBox6.Text = textBox8.Text = textBox9.Text = textBox11.Text =
            textBox12.Text = textBox15.Text = textBox16.Text = textBox18.Text = textBox19.Text   = "1";

        }




        int count1 = 0;
        void perform(string direction, string enable)
        {
            if (count1 == 0)
            {
                port.Write(direction);

                count1 = 10;
            }

            if (count1 == 10)
            {
                port.Write(enable);
            }
            count1 = 0;

        }
        //nst2zenb7gt mohndes elmeca?


        Boolean Hotkeyys = false;

        private void button5_Click(object sender, EventArgs e)
        {
            port.PortName = comboBox1.SelectedItem.ToString();
        }
        
        private void HotKeys_BT(object sender, EventArgs e)
        {
            if (port.IsOpen==false && Hotkeyys==false)
            {
                
                //try
               // {
                    port.Open();
                    pictureBox1.Visible = true;
                    button4.Text = "Close HK";
                    Hotkeyys = true;
                    
                    

                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("please chosse the correct port name");
                //}
                
           
        }
            else if (pictureBox1.Visible == true && Hotkeyys==true)
            {
                port.Close();
                button4.Text = "HotKeys";
                pictureBox1.Visible = false;
                Hotkeyys = false;
            }

        }

        private void HotKeys_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                perform("I", "A");




            }
            if (e.KeyCode == Keys.D1)
            {
                perform("i", "A");



            }
            /////////////////

            if (e.KeyCode == Keys.F2)
            {
                perform("K", "B");
                perform(" ", " ");
                perform(" ", " ");
                perform("K", "B");
                perform(" ", " ");
                perform(" ", " ");




            }
            if (e.KeyCode == Keys.D2)
            {
                perform("k", "B");
                perform(" ", " ");
                perform(" ", " ");
                perform("k", "B");
                perform(" ", " ");
                perform(" ", " ");





            }
            /////////////////////////

            if (e.KeyCode == Keys.F3)
            {
                perform("M", "C");


            }
            if (e.KeyCode == Keys.D3)
            {
                perform("m", "C");


            }
            ////////////////////////



            if (e.KeyCode == Keys.F4)
            {
                perform("O", "D");


            }
            if (e.KeyCode == Keys.D4)
            {
                perform("o", "D");


            }
            /////////////////////////
            if (e.KeyCode == Keys.F5)
            {
                perform("Q", "E");


            }
            if (e.KeyCode == Keys.D5)
            {
                perform("q", "E");


            }

            ////////////////////////

            if (e.KeyCode == Keys.F6)
            {
                perform("S", "F");
                perform("S", "F");
                perform("S", "F");

            }
            if (e.KeyCode == Keys.D6)
            {
                perform("s", "F");
                perform("s", "F");
                perform("s", "F");

            }
            //////////////


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

       

       
    }
}
