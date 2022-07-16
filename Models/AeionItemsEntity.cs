namespace MVC_Test.Models
{
    public class AeionItemsEntity
    {

        //商品ID
        public int ImteID { get; set; }
        //商品名
        public string ItemName { get; set; }
        //商品購入日
        public DateTime BuyDatetime { get; set; }
        //商品の価格
        public int ItemPrice { get; set; }
        //商品のJanコード
        public int ItemJanCode { get; set; }
    }
}
