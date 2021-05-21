using BoardBusinessLogic.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace BoardView
{
    public partial class FormReq : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly UsersLogic logic;
        public int Id { set => id = value; }
        private int? id;
        public FormReq(UsersLogic taskLogic)
        {
            InitializeComponent();
            logic = taskLogic;
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {

        }

        private void buttonToTask_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormUser>();
            form.ShowDialog();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

        }

        private void FormTask_Load(object sender, EventArgs e)
        {
            try
            {
                var list = logic.Read(null);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView.Columns[7].Visible = false;
                    dataGridView.Columns[8].Visible = false;
                    dataGridView.Columns[9].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {

        }
    }
}
