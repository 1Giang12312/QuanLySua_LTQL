//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnCuoiKi
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblTaiKhoan
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public byte QuyenHan { get; set; }
        public string GhiChu { get; set; }
    
        public virtual TblNhanVien TblNhanVien { get; set; }
    }
}
