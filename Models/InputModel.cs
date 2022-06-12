
using System.ComponentModel.DataAnnotations;

namespace MVC_Test.Models
{
    public class InputModel
    {

        //バリデーションでパラメータ属性を指定することが可能
        //必須
        [Required]
        //文字の長さ
        [MaxLength(100)]
        [Display(Name = "名前")]
        public string name { get; set; }


        //Displayで表示する名称を変更することが可能
        [Display(Name = "年齢")]
        public int age { get; set; }
        
    }
}
