using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerOrder
{
    class CreditCardPayment
    {
        private string[] _creditCardData = { "", "", "", "", "", "", "", "", "", "", "" };

        public CreditCardPayment()
        {
            
        }

        /// <summary>
        /// 設定信用卡資料
        /// </summary>
        /// <param name="dataNumber"></param>
        public void SetCreditCardData(int dataNumber, string dataText)
        {
            _creditCardData[dataNumber] = dataText;
        }

        /// <summary>
        /// 確認欄位是否填好
        /// </summary>
        /// <returns></returns>
        public bool GetFullData()
        {
            foreach (string data in _creditCardData)
            {
                if (string.IsNullOrEmpty(data))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 回傳欄位資料
        /// </summary>
        /// <returns></returns>
        public string GetCreditCardData(int dataNumber)
        {
            return _creditCardData[dataNumber];
        }
    }
}
