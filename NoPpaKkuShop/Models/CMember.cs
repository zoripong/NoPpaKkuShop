using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace NoPpaKkuShop.Models
{
    public class CMember
    {
        public int theUniqueID { get; set; }
        [Required(ErrorMessage = "아이디를 입력하세요.")]
        public string theID { get; set; }
        [Required(ErrorMessage = "암호를 입력하세요.")]
        public string thePW { get; set; }
        [Required(ErrorMessage = "휴대폰 번호를 입력하세요.")]
        public string thePhone { get; set; }
        [Required(ErrorMessage = "이메일을 입력하세요.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "정확한 이메일 주소를 입력하세요.")]
        public string theEMail { get; set; }
       
    }
}