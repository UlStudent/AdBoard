using BoardBusinessLogic.BindingModels;
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
    public partial class FormUser : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly UsersLogic logic;

        private int? id;

        public FormUser(UsersLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = logic.Read(new UsersBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxUsername.Text = view.Username;
                        textBoxLogin.Text = view.Login;
                        textBoxPhone.Text = view.Phone;
                        textBoxPassword.Text = view.Password;
                        checkBoxIsAdmin.Checked = view.IsAdmin;
                        checkBoxIsVerificated.Checked = view.IsVerificated;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxLogin.Text) ||
                string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.CreateOrUpdate(new UsersBindingModel
                {
                    Id = id,
                    Username = textBoxUsername.Text,
                    Login = textBoxLogin.Text,
                    Password = textBoxPassword.Text,
                    Phone = textBoxPhone.Text,
                    IsAdmin = checkBoxIsAdmin.Checked,
                    IsVerificated = checkBoxIsVerificated.Checked
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
