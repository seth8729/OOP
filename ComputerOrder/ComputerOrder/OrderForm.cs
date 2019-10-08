using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerOrder
{
    public partial class OrderForm : Form
    {
        Model _model = new Model();
        PresentationModel _presentationModel = new PresentationModel();
        List<Button> _productButtonList = new List<Button>();
		CreditCardPaymentForm _creditCardPaymentForm = new CreditCardPaymentForm();
		int _currentProduct = -1;
        int _currentTab = 0;
        int _startButtonNumber = 0;
        int _pageNumber = 1;
        const int TAB_BUTTON_NUMBER = 6;
        const string PAGE_TEXT = "Page：";
        

        public OrderForm()
        {
            InitializeComponent();
            CreateButton();
			_orderView.CellPainting += PaintGridButton;
			_orderView.CellClick += ClickDeleteButton;
			_pageLabel.Text = PAGE_TEXT + _pageNumber + _presentationModel.GetProductPage(_currentTab);
        }

        /// <summary>
        /// 建立按鈕
        /// </summary>
        private void CreateButton()
        {
            for (int i = 0; i < TAB_BUTTON_NUMBER; i++)
            {
                Button button = new Button();
                _presentationModel.CreateButton(button, _motherBoardPage, _currentTab, i);
                _productButtonList.Add(button);
                button.Click += new EventHandler(ClickProductButton);
            }
            _frontButton.Enabled = _presentationModel.GetProductEnable(_startButtonNumber - TAB_BUTTON_NUMBER, _currentTab);
            _backButton.Enabled = _presentationModel.GetProductEnable(_startButtonNumber + TAB_BUTTON_NUMBER, _currentTab);
        }

        /// <summary>
        /// 切換頁面
        /// </summary>
        private void ChangePage()
        {
            for (int i = _startButtonNumber; i < _startButtonNumber + TAB_BUTTON_NUMBER; i++)
            {
                _presentationModel.ChangeProductTab(_productButtonList[i % TAB_BUTTON_NUMBER], _productTab, _currentTab, i);
            }
            _frontButton.Enabled = _presentationModel.GetProductEnable(_startButtonNumber - TAB_BUTTON_NUMBER, _currentTab);
            _backButton.Enabled = _presentationModel.GetProductEnable(_startButtonNumber + TAB_BUTTON_NUMBER, _currentTab);
        }

        /// <summary>
        /// 顯示商品介紹及價格
        /// </summary>
        private void ShowProductPriceAndIntroduction()
        {
            _productPrice.Visible = true;
            _introductionView.Visible = true;
            _productPrice.Text = _model.GetProductPrice(_currentTab, _currentProduct);
            _introductionView.Text = _model.GetProductIntroduction(_currentTab, _currentProduct);
        }

        /// <summary>
        /// 清空商品介紹欄
        /// </summary>
        private void ClearIntroductionBox()
        {
            _productPrice.Visible = false;
            _introductionView.Visible = false;
            _addProduct.Enabled = false;
        }

        /// <summary>
        /// 按下商品按鈕
        /// </summary>
        private void ClickProductButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _currentProduct = button.TabIndex;
            _currentTab = _productTab.SelectedIndex;
            ShowProductPriceAndIntroduction();
            _addProduct.Enabled = true;
        }

        /// <summary>
        /// 更換商品分類
        /// </summary>
        private void ClickProductTab(object sender, EventArgs e)
        {
            _currentTab = _productTab.SelectedIndex;
            _currentProduct = -1;
            _startButtonNumber = 0;
            _pageNumber = 1;
            ChangePage();
            ClearIntroductionBox();
            _pageLabel.Text = PAGE_TEXT + _pageNumber + _presentationModel.GetProductPage(_currentTab);
        }
        
        /// <summary>
        ///按下上一頁 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickFrontButton(object sender, EventArgs e)
        {
            _startButtonNumber -= TAB_BUTTON_NUMBER;
            _pageNumber--;
            ChangePage();
            ClearIntroductionBox();
            _pageLabel.Text = PAGE_TEXT + _pageNumber + _presentationModel.GetProductPage(_currentTab);
        }

        /// <summary>
        /// 按下下一頁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBackButton(object sender, EventArgs e)
        {
            _startButtonNumber += TAB_BUTTON_NUMBER;
            _pageNumber++;
            ChangePage();
            ClearIntroductionBox();
            _pageLabel.Text = PAGE_TEXT + _pageNumber + _presentationModel.GetProductPage(_currentTab);
        }

        /// <summary>
        /// 加入購物車
        /// </summary>
        private void ClickAddProduct(object sender, EventArgs e)
        {
            _orderView.Rows.Add(_model.AddProductToOrderView(_currentTab, _currentProduct));
            _totalPrice.Text = _model.GetOrderTotalPrice();
        }

		/// <summary>
		/// 繪製按鈕圖片
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PaintGridButton(object sender, DataGridViewCellPaintingEventArgs e)
		{
			_presentationModel.PaintButtonPicture(e);
		}

		/// <summary>
		/// 按下刪除按鈕
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClickDeleteButton(object sender, DataGridViewCellEventArgs e)
		{
			_presentationModel.DeleteProduct(_orderView, e);
			_model.DeleteProductFromOrder(e.RowIndex);
			_totalPrice.Text = _model.GetOrderTotalPrice();
		}

		/// <summary>
		/// 按下訂購按鈕
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClickBuyButton(object sender, EventArgs e)
        {
            _creditCardPaymentForm.ShowDialog(this);
        }
    }
}
