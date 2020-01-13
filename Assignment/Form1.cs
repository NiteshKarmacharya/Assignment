using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        Graphics g;
        int? initX = null;
        int? initY = null;
        int? initZ = null;

        public Form1()
        {
            InitializeComponent();
            g = pnlDrawField.CreateGraphics();
        }

        //Close button function

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //minimize button function

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //resoze button function

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        // array of command to store command that can be fired

        string[] command =
        {
            "Rectangle",
            "Triangle",
            "Circle",
            "Reset",
            "Clear",
            "Positionpen",
            "Pendraw",
        };

        private void btnRun_Click(object sender, EventArgs e)
        {
            // to get the number of word input from SingleLinecode
            string[] arrCommand = txtSingleLineCode.Text.Split(' ');
            int arrCommandLength = 0;
            for (int i = 0; i < arrCommand.Length; i++)
            {
                arrCommandLength = arrCommand.Length;
            }
            //MessageBox.Show(Convert.ToString(arrCommandLength));

            // check if the command is null or not 
            // if not then enter
            if (arrCommand[0] != null)
            {
                bool flag = true;
                foreach (string iCommand in command)
                {
                    if (iCommand.Equals(arrCommand[0]))
                    {
                        if(arrCommand[0].Equals("Pendraw"))
                        {
                           
                        }
                        else if (arrCommand[0].ToUpper().Equals("moveto"))
                        {
                            
                        }

                        else if (arrCommand[0].ToUpper().Equals("circle"))
                        {
                            
                        }
                        flag = false;
                        break;
                    }
                }
                if(flag==true)
                {
                    MessageBox.Show("Command not found");
                }
                

                // check if the parameter is provided or not

                if (arrCommandLength == 2)
                {
                    string[] arrParameter = arrCommand[1].Split(',');
                    int arrParameterLength = 0;
                    
                    foreach (string iparameter in arrParameter)
                    {
                        //MessageBox.Show(iparameter);
                    }
                }
                else
                {
                    MessageBox.Show("No parameter found please give parameter !!!");
                   
                }
            }
        }

        private void pnlDrawField_Paint(object sender, PaintEventArgs e)
        {
            g = pnlDrawField.CreateGraphics();

            int? initX = null;
            int? initY = null;
            int? initZ = null;
            bool drawTriangle = false;
            bool drawRectangle = false;
            bool drawCircle = false;

            SolidBrush sb = new SolidBrush(Color.Red);

            if (drawTriangle)
            {
                drawTriangle = false;
            }
            if (drawRectangle)
            {
                drawRectangle = false;
            }
            if (drawCircle)
            {
                drawCircle = false;
            }
        }
    }
}
