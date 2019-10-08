using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerOrder
{
    class Model
    {
        private Order _order = new Order();
        private CreditCardPayment _creditCardPayment = new CreditCardPayment();
        private const string PRICE_TEXT = "單價：";
        private const string DOLLAR_TEXT = "元";
        private const string TOTAL_PRICE_TEXT = "總金額：";
		

        /// <summary>
        /// 回傳商品價格
        /// </summary>
        public string GetProductPrice(int productTab, int chooseProduct)
        {
            Product product = new Product(productTab, chooseProduct);
            return PRICE_TEXT + AddCommaToText(product.GetProductPrice().ToString()) + DOLLAR_TEXT;
        }

        /// <summary>
        /// 回傳商品介紹
        /// </summary>
        public string GetProductIntroduction(int productTab, int chooseProduct)
        {
            Product product = new Product(productTab, chooseProduct);
            return product.GetProductIntroduction();
        }

        /// <summary>
        /// 回傳購物車內容
        /// </summary>
        /// <param name="chooseProduct"></param>
        /// <returns></returns>
        public string[] AddProductToOrderView(int productTab, int chooseProduct)
        { 
			string[] productData = _order.AddProductToOrder(productTab, chooseProduct);
			AddCommaToText(productData.Last<string>());
			return _order.AddProductToOrder(productTab, chooseProduct);
        }

        /// <summary>
        /// 取得購物車內總金額
        /// </summary>
        /// <returns></returns>
        public string GetOrderTotalPrice()
        {
            return TOTAL_PRICE_TEXT + AddCommaToText(_order.GetOrderTotalPrice().ToString()) + DOLLAR_TEXT;
        }

        /// <summary>
        /// 取得商品照片
        /// </summary>
        /// <param name="chooseProduct"></param>
        /// <param name="productTab"></param>
        /// <returns></returns>
        public string GetProductPicture(int chooseProduct, int productTab = 0)
        {
            Product product = new Product(productTab, chooseProduct);
            return product.GetProductPicture();
        }

        /// <summary>
        /// 回傳商品數量
        /// </summary>
        /// <param name="productTab"></param>
        /// <returns></returns>
        public int GetProductAmount(int productTab)
        {
            Product product = new Product(productTab, 0);
            return product.GetProductAmount();
        }

		/// <summary>
		/// 刪除購物車商品
		/// </summary>
		/// <param name="productNumber"></param>
		public void DeleteProductFromOrder(int productNumber)
		{
			_order.DeleteProductFormOrder(productNumber);
		}

        /// <summary>
        /// 回傳信用卡資料狀態
        /// </summary>
        /// <returns></returns>
        public bool IsCreditCardFullData()
        {
            return _creditCardPayment.GetFullData();
        }

        /// <summary>
        /// 設定信用卡資料
        /// </summary>
        /// <returns></returns>
        public void SetCreditCardFullData(int dataNumber, string dataText)
        {
            _creditCardPayment.SetCreditCardData(dataNumber, dataText);
        }

        /// <summary>
        /// 取得信用卡資料
        /// </summary>
        /// <returns></returns>
        public string GetCreditCardData(int dataNumber)
        {
            return _creditCardPayment.GetCreditCardData(dataNumber);
        }

		/// <summary>
		/// 每三位加一個逗號
		/// </summary>
		/// <param name="productPrice"></param>
		/// <returns></returns>
		private string AddCommaToText(string productPrice)
		{
			for(int i = productPrice.Length - 3; i > 0; i -= 3)
			{
				productPrice = productPrice.Insert(i, ",");
			}
			return productPrice;
		}
    }
}
