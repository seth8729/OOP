using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerOrder
{
    class Product
    {
        private Constant _constant = new Constant();
        private string _name = "";
        private string _category = "";
        private string _introduction = "";
        private int _price = 0;
        private string _picture = "";
        private int _amount = 0;

        /// <summary>
        /// 建立商品
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="introduction"></param>
        /// <param name="price"></param>
        public Product(int productTab, int productNumber)
        {
            _name = _constant.GetProductName(productTab, productNumber);
            _category = _constant.GetProductCategory(productTab);
            _introduction = _constant.GetProductIntroduction(productTab, productNumber);
            _price = _constant.GetProductPrice(productTab, productNumber);
            _picture = _constant.GetProductPicture(productTab, productNumber);
            _amount = _constant.GetProductAmount(productTab);
        }

        //回傳商品的名稱
        public string GetProductName()
        {
            return _name;
        }

        //回傳商品的價錢
        public int GetProductPrice()
        {
            return _price;
        }

        //回傳商品的介紹
        public string GetProductIntroduction()
        {
            return _introduction;
        }

        //回傳商品的類別
        public string GetProductCategory()
        {
            return _category;
        }

        //回傳商品資料
        public string[] GetProductOrderDetail()
        {
            return new string[] { "", _name, _category, _price.ToString() };
        }

        //回傳商品圖片位址
        public string GetProductPicture()
        {
            return _picture;
        }

        //回傳商品數量
        public int GetProductAmount()
        {
            return _amount;
        }
    }
}
