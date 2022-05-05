using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public
{
    public class QuanLyPhongPublic
    {
        private int _QLP_Ma ;

        public int QLP_Ma 
        {
            get { return _QLP_Ma ; }
            set { _QLP_Ma  = value; }
        }

        private string _QLP_CoSo ;

        public string QLP_CoSo
        {
            get { return _QLP_CoSo ; }
            set { _QLP_CoSo  = value; }
        }

        private string _QLP_DiaDiem ;

        public string QLP_DiaDiem
        {
            get { return _QLP_DiaDiem ; }
            set { _QLP_DiaDiem= value; }
        }

        private string _QLP_ToaNha ;

        public string QLP_ToaNha
        {
            get { return _QLP_ToaNha ; }
            set { _QLP_ToaNha = value; }
        }

        private string _QLP_MaPhong ;

        public string QLP_MaPhong
        {
            get { return _QLP_MaPhong ; }
            set { _QLP_MaPhong  = value; }
        }

        private string _QLP_TenPhong ;

        public string QLP_TenPhong
        {
            get { return _QLP_TenPhong ; }
            set { _QLP_TenPhong = value; }
        }

        private string _QLP_LoaiPhong ;

        public string QLP_LoaiPhong
        {
            get { return _QLP_LoaiPhong ; }
            set { _QLP_LoaiPhong  = value; }
        }

        private string _QLP_MoTa ;

        public string QLP_MoTa
        {
            get { return _QLP_MoTa ; }
            set { _QLP_MoTa  = value; }
        }

        private bool? _QLP_TinhTrangSuDung;

        public bool? QLP_TinhTrangSuDung
        {
            get { return _QLP_TinhTrangSuDung ; }
            set { _QLP_TinhTrangSuDung = value; }
        }

        private string _QLP_KichThuocDai;

        public string QLP_KichThuocDai
        {
            get { return _QLP_KichThuocDai; }
            set { _QLP_KichThuocDai = value; }
        }

        private string _QLP_KichThuocRong;

        public string QLP_KichThuocRong
        {
            get { return _QLP_KichThuocRong; }
            set { _QLP_KichThuocRong = value; }
        }

        private string _QLP_KichThuocCao;

        public string QLP_KichThuocCao
        {
            get { return _QLP_KichThuocCao; }
            set { _QLP_KichThuocCao = value; }
        }

        private int _QLP_SoCho ;

        public int QLP_SoCho
        {
            get { return _QLP_SoCho ; }
            set { _QLP_SoCho  = value; }
        }

        private int _QLP_BGSV_Ban ;

        public int QLP_BGSV_Ban
        {
            get { return _QLP_BGSV_Ban ; }
            set { _QLP_BGSV_Ban  = value; }
        }

        private int _QLP_BGSV_Ghe ;

        public int QLP_BGSV_Ghe 
        {
            get { return _QLP_BGSV_Ghe; }
            set { _QLP_BGSV_Ghe  = value; }
        }

        private int _QLP_BGGV_Ban ;

        public int QLP_BGGV_Ban 
        {
            get { return _QLP_BGGV_Ban ; }
            set { _QLP_BGGV_Ban  = value; }
        }

        private int _QLP_BGGV_Ghe ;

        public int QLP_BGGV_Ghe
        {
            get { return _QLP_BGGV_Ghe ; }
            set { _QLP_BGGV_Ghe  = value; }
        }

        private int _QLP_NSSD_Ma ;

        public int QLP_NSSD_Ma
        {
            get { return _QLP_NSSD_Ma ; }
            set { _QLP_NSSD_Ma  = value; }
        }

        private int _QLP_NSQL_Ma ;

        public int QLP_NSQL_Ma
        {
            get { return _QLP_NSQL_Ma ; }
            set { _QLP_NSQL_Ma  = value; }
        }

        private byte[] _QLP_AnhPhong;

        public byte[] QLP_AnhPhong
        {
            get { return _QLP_AnhPhong ; }
            set { _QLP_AnhPhong  = value; }
        }

        private byte[] _QLP_BanVe;

        public byte[] QLP_BanVe
        {
            get { return _QLP_BanVe; }
            set { _QLP_BanVe = value; }
        }        

        private string _QLP_GhiChu ;

        public string QLP_GhiChu
        {
            get { return _QLP_GhiChu; }
            set { _QLP_GhiChu  = value; }
        }

        private bool? _QLP_HoanThanh ;

        public bool? QLP_HoanThanh
        {
            get { return _QLP_HoanThanh ; }
            set { _QLP_HoanThanh = value; }
        }

        private bool? _QLP_HT_MoTa ;

        public bool? QLP_HT_MoTa
        {
            get { return _QLP_HT_MoTa ; }
            set { _QLP_HT_MoTa = value; }
        }

        private string _QLP_HT_MoTaChiTiet ;

        public string QLP_HT_MoTaChiTiet
        {
            get { return _QLP_HT_MoTaChiTiet; }
            set { _QLP_HT_MoTaChiTiet  = value; }
        }

        private int? _HT_UserCreate;

        public int? HT_UserCreate
        {
            get { return _HT_UserCreate; }
            set { _HT_UserCreate = value; }
        }

        private DateTime? _QLP_DateCreate;

        public DateTime? QLP_DateCreate
        {
          get { return _QLP_DateCreate; }
          set { _QLP_DateCreate = value; }
        }

        private int? _HT_UserEditor;

        public int? HT_UserEditor
        {
            get { return _HT_UserEditor; }
            set { _HT_UserEditor = value; }
        }

        private DateTime? _QLP_DateEditor;

        public DateTime? QLP_DateEditor
        {
            get { return _QLP_DateEditor; }
            set { _QLP_DateEditor = value; }
        }    
        
        private string _QLP_SuDung;

        public string QLP_SuDung
        {
            get { return _QLP_SuDung; }
            set { _QLP_SuDung = value; }
        }

        private bool? _QLP_HienThi;

        public bool? QLP_HienThi
        {
            get { return _QLP_HienThi; }
            set { _QLP_HienThi = value; }
        }
    }
}
