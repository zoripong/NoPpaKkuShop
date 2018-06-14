using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace NoPpaKkuShop.Models
{
    public class CLoginUser
    {
        [Required(ErrorMessage = "아이디를 입력하세요.")]
        public string theID { get; set; }
        [Required(ErrorMessage = "암호를 입력하세요.")]
        public string thePW { get; set; }

    }
}