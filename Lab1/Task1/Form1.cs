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
        public Form1()
        {
            InitializeComponent();
            numproc = 0;
            process0.SelectedIndex = 0;
            process1.SelectedIndex = 0;
        }
        public int numproc;
        public int[] process_position = {0,0};

        private void button1_Click(object sender, EventArgs e)
        {
            switch (process_position[0])
            {
                case 0:
                case 1:
                case 3:
                    process_position[0]++; 
                    break;
                case 2:
                    if (numproc == 1) break;
                    process_position[0]++; 
                    break;
                case 4:
                    numproc = 1;
                    process_position[0]++;
                    break;
                case 5:
                    process_position[0] = 0;
                    break;
            }
            process0.SelectedIndex = process_position[0];
            if (numproc == 0)
                label_process_num.Text = "Номер процесса = 0";
            else
                label_process_num.Text = "Номер процесса = 1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (process_position[1])
            {
                case 0:
                case 1:
                case 3:
                    process_position[1]++;
                    break;
                case 2:
                    if (numproc == 0) break;
                    process_position[1]++;
                    break;
                case 4:
                    numproc = 0;
                    process_position[1]++;
                    break;
                case 5:
                    process_position[1] = 0;
                    break;
            }
            process1.SelectedIndex = process_position[1];
            if (numproc == 0)
                label_process_num.Text = "Номер процесса = 0";
            else
                label_process_num.Text = "Номер процесса = 1";
        }
    }
}
