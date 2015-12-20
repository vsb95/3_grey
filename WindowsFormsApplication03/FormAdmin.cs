using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication03
{
    public partial class FormAdmin : Form
    {
        private readonly Form _backForm;
        
        public FormAdmin(Form backForm)
        {
            this._backForm = backForm;
            InitializeComponent();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            _backForm.Show();
        }
        

        private void bRegister_Click_1(object sender, EventArgs e)
        {

        }

        private void bExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
