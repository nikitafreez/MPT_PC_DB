using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPT_PC_DB
{
    public partial class EmailCodeCheck : Form
    {
        public EmailCodeCheck()
        {
            InitializeComponent();
            codeCheckTextBox.MaxLength = 6;
        }

        private void codeCheckButton_Click(object sender, EventArgs e)
        {
            if(codeCheckTextBox.Text == Registration.RandomCode.ToString())
            {
                MessageBox.Show("Вы вошли!!!");
            }
        }
    }
}
