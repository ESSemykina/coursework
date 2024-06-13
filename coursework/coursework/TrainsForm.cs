using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class TrainsForm : Form
    {
        public TrainsForm()
        {
            InitializeComponent();
        }

        private void вагонBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вагонBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainsDataSet);

        }

        private void вагонBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.вагонBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainsDataSet);

        }

        private void TrainsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainsDataSet.Тип_вагона".
            // При необходимости она может быть перемещена или удалена.
            this.тип_вагонаTableAdapter.Fill(this.trainsDataSet.Тип_вагона);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainsDataSet.Списание".
            // При необходимости она может быть перемещена или удалена.
            this.списаниеTableAdapter.Fill(this.trainsDataSet.Списание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainsDataSet.Ремонт".
            // При необходимости она может быть перемещена или удалена.
            this.ремонтTableAdapter.Fill(this.trainsDataSet.Ремонт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainsDataSet._Рейс_товар".
            // При необходимости она может быть перемещена или удалена.
            this.рейс_товарTableAdapter.Fill(this.trainsDataSet._Рейс_товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainsDataSet.Рейс".
            // При необходимости она может быть перемещена или удалена.
            this.рейсTableAdapter.Fill(this.trainsDataSet.Рейс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainsDataSet.Причина".
            // При необходимости она может быть перемещена или удалена.
            this.причинаTableAdapter.Fill(this.trainsDataSet.Причина);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainsDataSet.Груз".
            // При необходимости она может быть перемещена или удалена.
            this.грузTableAdapter.Fill(this.trainsDataSet.Груз);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainsDataSet.Город".
            // При необходимости она может быть перемещена или удалена.
            this.городTableAdapter.Fill(this.trainsDataSet.Город);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainsDataSet.Владелец".
            // При необходимости она может быть перемещена или удалена.
            this.владелецTableAdapter.Fill(this.trainsDataSet.Владелец);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainsDataSet.Вагон".
            // При необходимости она может быть перемещена или удалена.
            this.вагонTableAdapter.Fill(this.trainsDataSet.Вагон);

        }

        private void владелецSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.владелецBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainsDataSet);
        }

        private void городSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.городBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainsDataSet);
        }

        private void грузSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.грузBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainsDataSet);
        }

        private void причинаSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.причинаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainsDataSet);
        }

        private void рейсSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рейсBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainsDataSet);
        }

        private void рейс_товарSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рейс_товарBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainsDataSet);
        }

        private void ремонтSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ремонтBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainsDataSet);
        }

        private void списаниеSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.списаниеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainsDataSet);
        }

        private void типSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_вагонаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainsDataSet);
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
