using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratornayaRabota3
{
    public partial class Создать : Form
    {
        public Создать()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get
            {
                string text = TbName.Text;
                return text;
            }
            set { }
        }
        public int W
        {
            get
            {
                string text = TbW.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        public int H
        {
            get
            {
                string text = TbH.Text;
                int value = Convert.ToInt32(text);
                return value;
            }
        }

        bool _canceled = false;
        public bool Canceled 
        { 
            get 
            { 
                return _canceled; 
            
            } 
        }
        private void TbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbW_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbH_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _canceled= true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

  
}
