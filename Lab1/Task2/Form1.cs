using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public int[] numProc = { 0, 0 };
        public int[] process_position = { 0, 0 };
        public bool[] InProc = { false, false };
        public int [] iteration = { 0, 0};
        public Form1()
        {
            InitializeComponent();
            process0.SelectedIndex = 0;
            process1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (process_position[0])
            {
                case 0:
                case 1:
                case 5:
                case 6:
                case 10:
                    process_position[0]++;
                    break;

                case 2:
                    InProc[0] = true;
                    process_position[0]++;
                    break;

                case 3:
                    numProc[0] = Math.Max(numProc[0], numProc[1]) + 1;
                    process_position[0]++;
                    break;

                case 4:
                    InProc[0] = false;
                    process_position[0]++;
                    break;

                case 7:
                    if (0 == iteration[0])
                    {
                        process_position[0]++;
                    }
                    else if (!InProc[0])
                    {
                        process_position[0]++;
                    }
                    break;

                case 8:
                    if (numProc[1] == 0)
                    {
                        process_position[0]++;
                    }
                    else if (0 == iteration[0])
                    {
                        process_position[0]++;
                    }
                    else if (numProc[1] > numProc[0])
                    {
                        process_position[0]++;
                    }
                    break;

                case 9:
                    if (iteration[0] == 0)
                    {
                        iteration[0]++;
                        process_position[0] = 5;
                    }
                    else
                    {
                        iteration[0] = 0;
                        process_position[0]++;
                    }
                    break;

                case 11:
                    numProc[0] = 0;
                    process_position[0]++;
                    break;

                case 12:
                    process_position[0] = 0;
                    break;

                default:
                    break;
            }
            process0.SelectedIndex = process_position[0];
            label_j0.Text = "j (0) = " + iteration[0];
            label_numProc0.Text = "numProc [0] = " + numProc[0];
            checkBox1.Checked = InProc[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (process_position[1])
            {
                case 0:
                case 1:
                case 5:
                case 6:
                case 10:
                    process_position[1]++;
                    break;

                case 2:
                    InProc[1] = true;
                    process_position[1]++;
                    break;

                case 3:
                    numProc[1] = Math.Max(numProc[0], numProc[1]) + 1;
                    process_position[1]++;
                    break;

                case 4:
                    InProc[1] = false;
                    process_position[1]++;
                    break;

                case 7:
                    if (1 == iteration[1])
                    {
                        process_position[1]++;
                    }
                    else if (!InProc[1])
                    {
                        process_position[1]++;
                    }
                    break;

                case 8:
                    if (numProc[0] == 0)
                    {
                        process_position[1]++;
                    }
                    else if (1 == iteration[1])
                    {
                        process_position[1]++;
                    }
                    else if (numProc[0] > numProc[1])
                    {
                        process_position[1]++;
                    }
                    break;

                case 9:
                    if (iteration[1] == 0)
                    {
                        iteration[1]++;
                        process_position[1] = 5;
                    }
                    else
                    {
                        iteration[1] = 0;
                        process_position[1]++;
                    }
                    break;

                case 11:
                    numProc[1] = 0;
                    process_position[1]++;
                    break;

                case 12:
                    process_position[1] = 0;
                    break;

                default:
                    break;
            }
            process1.SelectedIndex = process_position[1];
            label_j1.Text = "j (1) = " + iteration[1];
            label_numProc1.Text = "numProc [1] = " + numProc[1];
            checkBox2.Checked = InProc[1];
        }
    }
}
