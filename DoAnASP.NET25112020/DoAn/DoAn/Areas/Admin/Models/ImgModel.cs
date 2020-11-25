using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Models
{
    public class ImgModel
    {
        string TenHinh { get; set; }
        string IDSanPham { get; set; }
        [ForeignKey("IDSanPham")]
        public virtual SanPhamModel ListSanPham { get; set; }
    }
}
