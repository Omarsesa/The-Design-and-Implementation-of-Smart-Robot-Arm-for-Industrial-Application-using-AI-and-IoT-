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

namespace Repeating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string in_data;
        string result;
        bool SaveMoves = false;
        bool remote = false;
        SerialPort port13 = new SerialPort("COM13", 115200, Parity.None, 8, StopBits.One);
        List<string> list = new List<string>();

        private void port_dataRecived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = port13.ReadLine();
            this.Invoke(new EventHandler(displaydata_event));

        }


        private void displaydata_event(object sender, EventArgs e)
        {
            result = in_data;
            if (port13.IsOpen == true)
            {
                if(in_data.Contains('X'))
                {
                    SaveMoves = true;
                    counter = 0;
                    remote = false;

                    label1.BackColor = Color.Red;
                   
                 
                    
                }
                if (in_data.Contains('Y') && SaveMoves == true)
                {
                    SaveMoves = false;
                    remote = false;
                    label1.BackColor = Color.Red;
                }
                if (in_data.Contains('Z') && SaveMoves==false && remote==false)
                {
                    remote = true;

                }

               
                
                if (SaveMoves == true)
                {
                    if ((in_data.Contains('X')) || (in_data.Contains('Y')) || (in_data.Contains('Z')))
                    {
                        label1.Text="Takking Orders";
                        label1.BackColor = Color.Green;
                        
                        
                    }
                    else{
                    label1.Text = "Saving";
                    textBox1.AppendText(result + "\n");
                    list.Add(result);
                    }
                    //// mtnsash el add v 
                }
                

                    if (remote == true && counter==0)
                    {
                        RepeatFromArduino(true);
                        counter++;
                    }
                }

            }
        
    int counter=0;
        private void RepeatFromArduino(bool ArduinoRemote)
        {
            repeating(list);
            label1.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Start";
            port13.DataReceived += port_dataRecived;
            try
            {
                port13.Open();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void repeating(List<string> list)
        {
            label1.Text = "repeating";
            string[] array1 = list.ToArray();
            string[] array2 = list.ToArray();
            string[] right = list.ToArray();
            string[] left = list.ToArray();
            string[] array = list.ToArray();
            for (int i = 0; i < array1.Length; i++)
            {

                left[i] = array1[i].Substring(0, 1);
                right[i] = array2[i].Substring(1, 2);
                listBox2.Items.Add(left[i]);
                listBox3.Items.Add(right[i]);


                if (left[i] == left[i].ToUpper())
                {
                    array[i] = left[i].ToLower() + right[i];

                }
                else if (left[i] == left[i].ToLower())
                {
                    array[i] = left[i].ToUpper() + right[i];
                }
                listBox1.Items.Add(array[i]);

            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                port13.Write(array[i]);
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                
                port13.Write(" ");
                port13.Write(" ");
                listBox4.Items.Add(array[i]);
            }
            for (int i = 0; i < array1.Length; i++)
            {
                port13.Write(array1[i]);
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");

                port13.Write(" ");
                port13.Write(" ");


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveMoves = true;
            label1.Text = "SaveFromC#";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveMoves = false;
            label1.Text = "DataSaved";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox2.Text); i++)
            {
                repeating(list);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] array1 = list.ToArray();
            string[] array2 = list.ToArray();
            string[] right = list.ToArray();
            string[] left = list.ToArray();
            string[] array = list.ToArray();
            for (int i = 0; i < array1.Length; i++)
            {

                left[i] = array1[i].Substring(0, 1);
                right[i] = array2[i].Substring(1, 2);
                listBox2.Items.Add(left[i]);
                listBox3.Items.Add(right[i]);


                if (left[i] == left[i].ToUpper())
                {
                    array[i] = left[i].ToLower() + right[i];

                }
                else if (left[i] == left[i].ToLower())
                {
                    array[i] = left[i].ToUpper() + right[i];
                }
                listBox1.Items.Add(array[i]);
              
            }
            
            for (int i = 0; i < array1.Length; i++)
            {
                port13.Write(array1[i]);
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                
                
            }
          
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] array1 = list.ToArray();
            string[] array2 = list.ToArray();
            string[] right = list.ToArray();
            string[] left = list.ToArray();
            string[] array = list.ToArray();
            for (int i = 0; i < array1.Length; i++)
            {

                left[i] = array1[i].Substring(0, 1);
                right[i] = array2[i].Substring(1, 2);
                listBox2.Items.Add(left[i]);
                listBox3.Items.Add(right[i]);


                if (left[i] == left[i].ToUpper())
                {
                    array[i] = left[i].ToLower() + right[i];

                }
                else if (left[i] == left[i].ToLower())
                {
                    array[i] = left[i].ToUpper() + right[i];
                }
                listBox1.Items.Add(array[i]);

            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                port13.Write(array[i]);
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                port13.Write(" ");
                listBox4.Items.Add(array[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "1";
        }
    }
}
