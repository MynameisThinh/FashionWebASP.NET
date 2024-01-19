using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.Models
{
    public class OrderViewModel
    {
        [Required(ErrorMessage = "Tên khách hàng không thể để trống")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Số điện thoại không thể để trống")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ không thể để trống")]
        
        public string Address { get; set; }
        public string Email { get; set; }
        public string CustomerId { get; set; }
        public int TypePayment { get; set; }
    }
}