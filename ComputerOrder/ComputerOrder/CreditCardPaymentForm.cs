using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerOrder
{
    public partial class CreditCardPaymentForm : Form
    {
        ErrorProvider _errorProvider = new ErrorProvider();
        PresentationModel _presentationModel = new PresentationModel();
        public CreditCardPaymentForm()
        {
            InitializeComponent();
			Load += CreditCardPaymentFormLoad;
			_lastNameTextBox.KeyPress += FindStringTextError;
            _nameTextBox.KeyPress += FindStringTextError;
            _numberTextBox1.KeyPress += FindNumberTextError;
            _numberTextBox2.KeyPress += FindNumberTextError;
            _numberTextBox3.KeyPress += FindNumberTextError;
            _numberTextBox4.KeyPress += FindNumberTextError;
            _codeTextBox.KeyPress += FindNumberTextError;
            _lastNameTextBox.TextChanged += FindTextBoxEmptyError;
            _nameTextBox.TextChanged += FindTextBoxEmptyError;
            _numberTextBox1.TextChanged += FindTextBoxEmptyError;
            _numberTextBox2.TextChanged += FindTextBoxEmptyError;
            _numberTextBox3.TextChanged += FindTextBoxEmptyError;
            _numberTextBox4.TextChanged += FindTextBoxEmptyError;
            _monthComboBox.TextChanged += FindComboBoxEmptyError;
            _yearComboBox.TextChanged += FindComboBoxEmptyError;
            _codeTextBox.TextChanged += FindTextBoxEmptyError;
            _mailTextBox.TextChanged += FindMailError;
            _addressTextBox.TextChanged += FindTextBoxEmptyError;
        }

		/// <summary>
		/// 初始化欄位
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CreditCardPaymentFormLoad(object sender, EventArgs e)
		{
			_lastNameTextBox.Text = _presentationModel.GetCreditCardData(_lastNameTextBox.TabIndex);
			_nameTextBox.Text = _presentationModel.GetCreditCardData(_nameTextBox.TabIndex);
			_numberTextBox1.Text = _presentationModel.GetCreditCardData(_numberTextBox1.TabIndex);
			_numberTextBox2.Text = _presentationModel.GetCreditCardData(_numberTextBox2.TabIndex);
			_numberTextBox3.Text = _presentationModel.GetCreditCardData(_numberTextBox3.TabIndex);
			_numberTextBox4.Text = _presentationModel.GetCreditCardData(_numberTextBox4.TabIndex);
			_monthComboBox.Text = _presentationModel.GetCreditCardData(_monthComboBox.TabIndex);
			_yearComboBox.Text = _presentationModel.GetCreditCardData(_yearComboBox.TabIndex);
			_codeTextBox.Text = "";
			_mailTextBox.Text = _presentationModel.GetCreditCardData(_mailTextBox.TabIndex);
			_addressTextBox.Text = _presentationModel.GetCreditCardData(_addressTextBox.TabIndex);
		}

        /// <summary>
        /// 排除數字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindStringTextError(object sender, KeyPressEventArgs e)
        {
            _presentationModel.FilterNumber(e);
        }

        /// <summary>
        /// 排除字串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindNumberTextError(object sender, KeyPressEventArgs e)
        {
            _presentationModel.FilterChar(e);
        }

        /// <summary>
        /// 檢查TextBox欄位空白錯誤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FindTextBoxEmptyError(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            _presentationModel.DiscoverStringEmpty(textBox);
            _presentationModel.SetConfirmButtonEnable(_confirm);
        }

        /// <summary>
        /// 儲存年月欄位資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FindComboBoxEmptyError(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            _presentationModel.SetMonthYearData(comboBox);
            _presentationModel.SetConfirmButtonEnable(_confirm);
        }

        /// <summary>
        /// 檢查電子郵件欄位錯誤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FindMailError(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            _presentationModel.DiscoverMailError(textBox);
            _presentationModel.SetConfirmButtonEnable(_confirm);
        }

        /// <summary>
        /// 按下訂購按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickConfirmButton(object sender, EventArgs e)
        {
            MessageBox.Show("訂購完成");
            this.Close();
        }
    }
}
