using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Models.Contacts{
    public class Contact{
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required(ErrorMessage = "Phải nhập {0}")]
        [Display(Name = "Họ Tên")]
        public string FullName { get; set; }
        [Required(ErrorMessage ="Phải nhập {0}")]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Email chưa đúng định dạng")]
        [Display(Name ="Địa chỉ email")]
        public string Email { get; set; }
        public DateTime DateSent { get; set; }
        [Display(Name ="Nội dung")]
        public string Message { get; set; }
        [StringLength(50)]
        [Phone(ErrorMessage ="Sđt chưa đúng định dạng")]
        [Display(Name ="Số điện thoại")]
        public string Phone { get; set; }
    }
}