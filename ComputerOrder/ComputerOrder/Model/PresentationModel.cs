using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerOrder
{
    class PresentationModel
    {
        Model _model = new Model();
        ErrorProvider _errorProvider = new ErrorProvider();
        const int BUTTON_POSITION_X = 6;
        const int BUTTON_POSITION_Y = 6;
        const int BUTTON_WIDTH_INTERVAL = 126;
        const int BUTTON_HIGH_INTERVAL = 112;
        const int HALF_TAB_BUTTON_NUMBER = 3;
        const int TAB_BUTTON_NUMBER = 6;
        const int BUTTON_WIDTH = 115;
        const int BUTTON_HIGH = 100;
        const string BUTTON_NAME = "_productButton";
        const int MAX_PRODUCT_NUMBER = 8;
        const string SLASH = "/";
        const string MAIL_ERROR_TEXT = "請輸入正確電子郵件格式";
        const string EMPTY_ERROR_TEXT = "欄位不能為空白";
        int[] _maxProductNumber = { MAX_PRODUCT_NUMBER, MAX_PRODUCT_NUMBER, MAX_PRODUCT_NUMBER, MAX_PRODUCT_NUMBER, MAX_PRODUCT_NUMBER, MAX_PRODUCT_NUMBER };
		Bitmap _deletePicture = new Bitmap("../../Resource/delete.png");

		/// <summary>
		/// 建立按鈕
		/// </summary>
		/// <param name="button"></param>
		/// <param name="currentPage"></param>
		/// <param name="currentTab"></param>
		/// <param name="chooseProduct"></param>
		public void CreateButton(Button button, TabPage currentPage, int currentTab, int chooseProduct)
        {
            if (chooseProduct < _maxProductNumber[currentTab])
            {
                button.Parent = currentPage;
                button.Name = BUTTON_NAME + chooseProduct.ToString();
                button.Image = new Bitmap(_model.GetProductPicture(chooseProduct));
                button.TabIndex = chooseProduct;
                button.Location = new System.Drawing.Point((BUTTON_POSITION_X + BUTTON_WIDTH_INTERVAL * (chooseProduct % HALF_TAB_BUTTON_NUMBER)), (BUTTON_POSITION_Y + BUTTON_HIGH_INTERVAL * (chooseProduct / HALF_TAB_BUTTON_NUMBER)));
                button.Size = new System.Drawing.Size(BUTTON_WIDTH, BUTTON_HIGH);

                currentPage.Controls.Add(button);
            }
        }

        /// <summary>
        /// 切換頁面
        /// </summary>
        /// <param name="button"></param>
        /// <param name="productPage"></param>
        /// <param name="currentTab"></param>
        /// <param name="chooseProduct"></param>
        public void ChangeProductTab(Button button, TabControl productPage, int currentTab, int chooseProduct)
        {
            if (chooseProduct < _maxProductNumber[currentTab])
            {
                button.Parent = productPage.TabPages[currentTab];
                button.Image = new Bitmap(_model.GetProductPicture(chooseProduct, currentTab));
                button.TabIndex = chooseProduct;
                button.Visible = true;
                productPage.TabPages[currentTab].Controls.Add(button);
            }
            else
            {
                button.Visible = false;
            }
        }

        /// <summary>
        /// 確認開啟上下頁
        /// </summary>
        /// <param name="expectedNumber"></param>
        /// <param name="productTab"></param>
        /// <returns></returns>
        public bool GetProductEnable(int expectedNumber, int productTab)
        {
            Product product = new Product(productTab, 0);
            return 0 <= expectedNumber && expectedNumber < _model.GetProductAmount(productTab);
        }

        /// <summary>
        /// 回傳商品總頁數
        /// </summary>
        /// <param name="productTab"></param>
        /// <returns></returns>
        public string GetProductPage(int productTab)
        {
            return SLASH + (Math.Ceiling((double)_model.GetProductAmount(productTab) / TAB_BUTTON_NUMBER));
        }

		public void PaintButtonPicture(DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}
			else if (e.ColumnIndex == 0)
			{
				int x = e.CellBounds.Left + (e.CellBounds.Width - _deletePicture.Width) / 2;
				int y = e.CellBounds.Top + (e.CellBounds.Height - _deletePicture.Height) / 2;
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);
				e.Graphics.DrawImage(_deletePicture, new Rectangle(x, y, _deletePicture.Width, _deletePicture.Height));
				e.Handled = true;
			}
		}

		/// <summary>
		/// 刪除商品
		/// </summary>
		/// <param name="orderView"></param>
		/// <param name="e"></param>
		public void DeleteProduct(DataGridView orderView, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}
			else if (e.ColumnIndex == 0)
			{
				orderView.Rows.RemoveAt(e.RowIndex);
			}
		}

		/// <summary>
		/// 判斷是否為電子郵件格式
		/// </summary>
		/// <param name="strIn"></param>
		/// <returns></returns>
		public void DiscoverMailError(TextBox textBox)
        {
            Regex mailExpression = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.Compiled | RegexOptions.Singleline);
            if (!mailExpression.IsMatch(textBox.Text))
            {
                _errorProvider.SetError(textBox, MAIL_ERROR_TEXT);
            }
            else
            {
                _errorProvider.Clear();
                _model.SetCreditCardFullData(textBox.TabIndex, textBox.Text);
            }
        }

        /// <summary>
        /// 判斷TextBox字串是否為空
        /// </summary>
        /// <param name="textString"></param>
        /// <returns></returns>
        public void DiscoverStringEmpty(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                _errorProvider.SetError(textBox, EMPTY_ERROR_TEXT);
            }
            else
            {
                _errorProvider.Clear();
                _model.SetCreditCardFullData(textBox.TabIndex, textBox.Text);
            }
        }

        /// <summary>
        /// 儲存年月欄位資料
        /// </summary>
        /// <param name="textString"></param>
        /// <returns></returns>
        public void SetMonthYearData(ComboBox comboBox)
        {
            _model.SetCreditCardFullData(comboBox.TabIndex, comboBox.Text);
        }

        /// <summary>
        /// 過濾掉數字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FilterNumber(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        /// <summary>
        /// 過濾掉字元
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FilterChar(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 設定購買按鈕狀態
        /// </summary>
        /// <param name="confirmButton"></param>
        public void SetConfirmButtonEnable(Button confirmButton)
        {
            confirmButton.Enabled = _model.IsCreditCardFullData();
        }

        /// <summary>
        /// 取得信用卡資料
        /// </summary>
        /// <returns></returns>
        public string GetCreditCardData(int dataNumber)
        {
            return _model.GetCreditCardData(dataNumber);
        }
    }
}
