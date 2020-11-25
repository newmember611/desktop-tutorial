using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Models
{
    public class SanPhamModel
    {
        [Key]
        string ID { get; set; }
        string Img { get; set; }
        string ThongTinSP { get; set; }
        string Ten { get; set; }
        int Gia { get; set; }
        string ThoiGIanBH { get; set; }
        float KhuyenMai { get; set; }
        string LoaiSP { get; set; }
        [ForeignKey("LoaiSP")]
        public virtual  LoaiSPModel Loai { get; set; }
    }
}
