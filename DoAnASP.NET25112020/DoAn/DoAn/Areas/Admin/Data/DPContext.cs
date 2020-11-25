using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Areas.Admin.Data
{
    public class DPContext : DbContext
    {
        DPContext(DbContextOptions<DPContext> options) : base(options) {}
        public DbSet<Models.SanPhamModel> SanPham { get; set; }
        public DbSet<Models.LoaiSPModel> LoaiSP { get; set; }
        public DbSet<Models.ImgModel> IMG { get; set; }
    
    }
}
