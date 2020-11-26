using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Models
{
    public class DongDienThoaiModel
    {
        [Key]
        public string IMEI { get; set; }
        public string MaDongDT { get; set; }
        public string MauSac { get; set; }
        public ICollection<DienThoaiModel> listDienThoai { get; set; }

    }
}