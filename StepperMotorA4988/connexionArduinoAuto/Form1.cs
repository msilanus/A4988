using System;
using System.Management;
using System.Collections.Generic;
using System.IO.Ports;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private String Rx;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnON_OFF_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string arduinoLine="";
            string arduPort="";
            int arduinoItem = -1;
            using (var searcher = new ManagementObjectSearcher
                ("SELECT * FROM WIN32_SerialPort"))
            {
                string[] portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                var tList = (from n in portnames
                             join p in ports on n equals p["DeviceID"].ToString()
                             select n + " - " + p["Caption"]).ToList();
                
                foreach (string s in tList)
                {
                    comboBox1.Items.Add(s);
                    if (s.Contains("Arduino")) 
                    {
                        arduinoLine = s;
                        arduinoItem = comboBox1.Items.IndexOf(s);
                        arduPort = s.Substring(0,5).Replace(" ",string.Empty);
                    }
                }
                if (arduinoItem > -1)
                {
                    comboBox1.SelectedIndex = arduinoItem;
                    serialPort1.PortName = arduPort;
                    try
                    {
                        serialPort1.Open();
                        toolStripStatusLabel1.Text = "Connecté à " + arduinoLine;
                        comboBox1.Enabled = false;
                        timer1.Enabled = true;
                        serialPort1.Write("STATUS\nSTATUS\nSTATUS\n");
                    }
                    catch
                    {
                        DialogResult result;
                        result = MessageBox.Show("Impossible d'ouvrir le port " + serialPort1.PortName + " !\n" +
                                                 "Ce port est peut être déja ouvert.\n" +
                                                 "Voulez-vous recommencé ?" 
                                                 , "Erreur !", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes) Application.Restart();
                        else Application.Exit();
                    }
                }
                else
                {
                    DialogResult result;
                    result=MessageBox.Show("Pas de carte Arduino détectée !\nConnectez une Arduino maintenant.", "Erreur !", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.OK) Application.Restart();
                    else Application.Exit();
                }
                
            } 
        }

        private void btPort_Click(object sender, EventArgs e)
        {
            if (btPort.Text == "Connecter")
            {
                timer1.Enabled = false;
                serialPort1.Close();
                serialPort1.PortName = comboBox1.SelectedItem.ToString().Substring(0, 5).Replace(" ", string.Empty);
                try
                { 
                    serialPort1.Open();
                    comboBox1.Enabled = false;
                    btPort.Text = "Modifier";
                    toolStripStatusLabel1.Text = "Connecté à " + comboBox1.SelectedItem.ToString();
                    timer1.Enabled = true;
                    serialPort1.Write("STATUS\n");
                }
                catch
                {
                    DialogResult result;
                    result = MessageBox.Show("Impossible d'ouvrir le port " + serialPort1.PortName + " !\n" +
                                                 "Ce port est peut être déja ouvert.\n" +
                                                 "Voulez-vous recommencé ?"
                                                 , "Erreur !", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes) Application.Restart();
                    else Application.Exit();
                }
            }
            else if (comboBox1.Enabled)
            {
                comboBox1.Enabled = false;
                btPort.Text = "Modifier";
            }
            else
            {
                comboBox1.Enabled = true;
                btPort.Text = "Connecter";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Rx = serialPort1.ReadTo("\r\n");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                char[] separator = { ';' };
                string[] state = Rx.Split(separator);
                lblStatusOnOff.Text = state[0];
                if (state[0] == "ON")
                {
                    btnOnOff.Text = "OFF";
                    btnOnOff.BackColor = Color.Red;
                }
                else
                {
                    btnOnOff.Text = "ON";
                    btnOnOff.BackColor = Color.Green;
                }
                lblWise.Text = state[1];
                if (state[1] == "Clockwise")
                {
                    btnAvRec.Text = "Avance";
                }
                else
                {
                    btnAvRec.Text = "Recule";
                }

                lblResolution.Text = state[2];
                if (state[2].Contains("Full")) rbFull.Checked = true;
                if (state[2].Contains("Half")) rbHalf.Checked = true;
                if (state[2].Contains("Quarter")) rbQuarter.Checked = true;
                if (state[2].Contains("Eighth")) rbEighth.Checked = true;
                if (state[2].Contains("Sixteenth")) rbSixteenth.Checked = true;

                lblTpm.Text = state[3] + " tr/min";
                
            }
            catch { }
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (btnOnOff.Text == "ON")
            {
                btnOnOff.Text = "OFF";
                btnOnOff.BackColor = Color.Red;
                serialPort1.Write("M\n");
            }
            else
            {
                btnOnOff.Text = "ON";
                btnOnOff.BackColor = Color.Green;
                serialPort1.Write("S\n");
            }
        }

        private void btnAvRec_Click(object sender, EventArgs e)
        {
            if (btnAvRec.Text == "Avance")
            {
                btnAvRec.Text = "Recule";
                serialPort1.Write("A\n");
            }
            else
            {
                btnAvRec.Text = "Avance";
                serialPort1.Write("R\n");
            }
        }

        private void Resolution()
        {
            if (rbEighth.Checked) serialPort1.Write("E\n");
            if (rbFull.Checked) serialPort1.Write("F\n");
            if (rbHalf.Checked) serialPort1.Write("H\n");
            if (rbQuarter.Checked) serialPort1.Write("Q\n");
            if (rbSixteenth.Checked) serialPort1.Write("X\n");
        }

        private void rbSixteenth_Click(object sender, EventArgs e)
        {
            Resolution();
        }


        private void btnAppliquerRPM_Click(object sender, EventArgs e)
        {
            try
            {
                String rpmStr = tbRPM.Text.Replace('.', ',');
                int resolution=1;
                float rpm = Convert.ToSingle(rpmStr);
                
                if (rbFull.Checked) resolution = 1;
                if (rbHalf.Checked) resolution = 2;
                if (rbQuarter.Checked) resolution = 4;
                if (rbEighth.Checked) resolution = 8;
                if (rbSixteenth.Checked) resolution = 16;

                int dureeImp = (int)(150000 / (rpm*resolution));
                serialPort1.Write(dureeImp.ToString());

                //MessageBox.Show(dureeImp.ToString());
            }
            catch 
            {
                MessageBox.Show("Entrée non valide", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            serialPort1.Write("+\n");
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            serialPort1.Write("-\n");
        }


    }
}
