using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Models
{
    public class LoaiSPModel
    {
        [Key]
        string MaLoai { get; set; }
        string TenLoaiSP { get; set; }
    }
}