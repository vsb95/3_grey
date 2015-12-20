using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UserService;

namespace WindowsFormsApplication03
{
    public partial class MainForm : Form
    {
        private readonly List<Table> _tablesList;
        private readonly string _role;
        private readonly UserService.UserService _service;
        private List<string> _fieldsList;
        private BindingSource bindingSource1 = new BindingSource();
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string role = "Editor";
                //////////////////////////////////////////////////////////////////////////////////
                ///  загрузи список таблиц в comboBoxTables
                
                switch (role)
                {
                    case "Admin":
                        buttonReg.Visible = true;
                        buttonShowMagazine.Visible = true;
                        break;
                    case "Editor":
                        buttonAdd.Visible = true;
                        buttonEdit.Visible = true;
                        buttonDelete.Visible = true;
                        buttonQuerry1.Visible = true;
                        buttonQuerry2.Visible = true;
                        buttonQuerry3.Visible = true;
                        buttonQuerry4.Visible = true;
                        break;
                    case "Reader":
                        break;
                    default: throw new Exception("Чет хз кто ты");
                }
                foreach (var table in _service.Tables)
                    listBoxTables.Items.Add(table.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //// выбрать табу и из нее датагрида вызвать 
            /*
            var fields = _service.Tables.FirstOrDefault(t => t.Name == listBoxTables.SelectedItem.ToString())
                .Fields.Select(field => field.Name).ToList();
            var frm = new FormEdit_Add_(_service, this, fields, listBoxTables.SelectedItem.ToString());
            frm.ShowDialog();
            Refresh();
    */
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //// выбрать табу и из нее датагрида вызвать 
            /*
            var fields = _service.Tables.FirstOrDefault(t => t.Name == listBoxTables.SelectedItem.ToString())
                .Fields.Select(field => field.Name).ToList();
            var frm = new FormEdit_Add_(_service, this, fields, listBoxTables.SelectedItem.ToString());
            frm.ShowDialog();
            Refresh();
    */
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
        

        private void listBoxTables_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                dataGridView2.DataSource = _service.SelectFromTable(listBoxTables.SelectedItem.ToString());
            }
            catch (Exception)
            {
                //
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            var frm = new FormAdmin(this);
            frm.ShowDialog();
        }

        private void buttonShowMagazine_Click(object sender, EventArgs e)
        {

        }
    }
}
