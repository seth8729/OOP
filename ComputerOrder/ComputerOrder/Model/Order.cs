using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerOrder
{
    class Order
    {
        List<Product> _productList = new List<Product>();

        /// <summary>
        /// 回傳購物車內容
        /// </summary>
        /// <param name="productNumber"></param>
        /// <returns></returns>
        public string[] AddProductToOrder(int productTab, int productNumber)
        {
            Product product = new Product(productTab, productNumber);
            _productList.Add(product);
            return _productList.Last<Product>().GetProductOrderDetail();
        }

        /// <summary>
        /// 取得購物車總金額
        /// </summary>
        /// <returns></returns>
        public int GetOrderTotalPrice()
        {
            int totalPrice = 0;
            for (int i = 0; i < _productList.Count; i++)
            {
                totalPrice += _productList[i].GetProductPrice();
            }
            return totalPrice;
        }

		/// <summary>
		/// 刪除購物車商品
		/// </summary>
		/// <param name="productNumber"></param>
		public void DeleteProductFormOrder(int productNumber)
		{
			_productList.RemoveAt(productNumber);
		}
    }
}
