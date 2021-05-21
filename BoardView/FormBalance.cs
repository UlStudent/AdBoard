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
    public partial class FormBalance : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly BalanceLogic logic;

        private int? id;

        public FormBalance(BalanceLogic logic)
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
                    var view = logic.Read(new BalanceBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxCardDate.Text = view.CardDate;
                        textBoxCardFIO.Text = view.CardFIO;
                        textBoxCardNumb.Text = view.CardNumb;
                        textBoxMoney.Text = view.Money;
                        textBoxMoneySpent.Text = view.MoneySpent;
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
            if (string.IsNullOrEmpty(textBoxCardNumb.Text) || string.IsNullOrEmpty(textBoxMoneySpent.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.CreateOrUpdate(new BalanceBindingModel
                {
                    Id = id,
                    Link = textBoxCardNumb.Text,
                    AdName = textBoxMoneySpent.Text,
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
