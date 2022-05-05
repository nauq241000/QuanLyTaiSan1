using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Public;
using System.Data.SqlClient;

namespace Data
{
    public class HT_PQ_USERData
    {
        //Load Phân quyền người dùng
        ClsKetNoi cls = new ClsKetNoi();
        public DataTable LoadHT_PQ_USER_Para(HT_PQ_USERPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@HT_USER_ID";
            giatri[0] = Public.HT_USER_ID;
            return cls.LayDuLieu("SP_HT_PQ_USER_Load_Para", bien, giatri, thamso);
        }
        public DataTable LoadHT_PQ_USER_Load_Para_NutCon(HT_PQ_USERPublic Public)
        {
            int thamso = 1;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@HT_USER_ID";
            giatri[0] = Public.HT_USER_ID;
            return cls.LayDuLieu("SP_HT_PQ_USER_Load_Para_NutCon", bien, giatri, thamso);
        }
        public SqlDataReader LoadHT_PQ_USER_R_MaND(HT_PQ_USERPublic Public)
        {
            int thamso = 3;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@HT_USER_ID";
            bien[1] = "@HT_ROOT_Form";
            bien[2] = "@HT_ROOT_Active";

            giatri[0] = Public.HT_USER_ID;
            giatri[1] = Public.HT_ROOT_Form;
            giatri[2] = Public.HT_ROOT_Active;

            return cls.LayDuLieu_R("SP_HT_PQ_USER_Load_R_MaND", bien, giatri, thamso);
        }

        public int CopyHT_PQ_USER(HT_PQ_USERPublic Public)
        {
            int thamso = 4;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            //bien[0] = "@HT_PQ_USER_ID";
            bien[0] = "@HT_USER_ID";
            bien[1] = "@HT_GROUPUSER_ID";
            bien[2] = "@HT_USER_Create";
            bien[3] = "@HT_PQ_USER_HienThi";
            //bien[4] = "@HT_PQ_USER_SuDung";

            //giatri[0] = Public.HT_PQ_USER_ID;
            giatri[0] = Public.HT_USER_ID;
            giatri[1] = Public.HT_GROUPUSER_ID;
            giatri[2] = Public.HT_USER_Create;
            giatri[3] = Public.HT_PQ_USER_HienThi;
            //giatri[4] = Public.HT_PQ_USER_SuDung;

            return cls.Update("SP_HT_PQ_USER_Copy", bien, giatri, thamso);
        }

        public int DongBoHT_PQ_USER(HT_PQ_USERPublic Public)
        {
            int thamso = 5;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            //bien[0] = "@HT_PQ_USER_ID";
            bien[0] = "@HT_USER_ID";
            bien[1] = "@HT_GROUPUSER_ID";
            bien[2] = "@HT_USER_Create";
            bien[3] = "@HT_PQ_USER_HienThi";
            bien[4] = "@HT_PQ_GROUP_ID";

            //giatri[0] = Public.HT_PQ_USER_ID;
            giatri[0] = Public.HT_USER_ID;
            giatri[1] = Public.HT_GROUPUSER_ID;
            giatri[2] = Public.HT_USER_Create;
            giatri[3] = Public.HT_PQ_USER_HienThi;
            giatri[4] = Public.HT_PQ_GROUP_ID;

            return cls.Update("SP_HT_PQ_USER_DongBo", bien, giatri, thamso);
        }

        public int SuaHT_PQ_USER(HT_PQ_USERPublic Public)
        {
            int thamso = 9;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            bien[0] = "@HT_PQ_USER_ID";
            bien[1] = "@HT_PQ_USER_Q_Full";
            bien[2] = "@HT_PQ_USER_Q_Xem";
            bien[3] = "@HT_PQ_USER_Q_Them";
            bien[4] = "@HT_PQ_USER_Q_Xoa";
            bien[5] = "@HT_PQ_USER_Q_Sua";
            bien[6] = "@HT_USER_Editor";
            bien[7] = "@HT_PQ_USER_HienThi";
            bien[8] = "@HT_PQ_USER_Q_Active_NutCon";

            giatri[0] = Public.HT_PQ_USER_ID;
            giatri[1] = Public.HT_PQ_USER_Q_Full;
            giatri[2] = Public.HT_PQ_USER_Q_Xem;
            giatri[3] = Public.HT_PQ_USER_Q_Them;
            giatri[4] = Public.HT_PQ_USER_Q_Xoa;
            giatri[5] = Public.HT_PQ_USER_Q_Sua;
            giatri[6] = Public.HT_USER_Editor;
            giatri[7] = Public.HT_PQ_USER_HienThi;
            giatri[8] = Public.HT_PQ_USER_Q_Active_NutCon;

            return cls.Update("SP_HT_PQ_USER_Edit_Para", bien, giatri, thamso);
        }

        //Lấy dữ liệu cho frmMain => Kiểm tra quyền người dùng => Hiển thị BarButtonItem thuộc Ribbon
        public int Visible_BarButtonItem_Main(HT_PQ_USERPublic Public)
        {
            int thamso = 4;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            //bien[0] = "@HT_PQ_USER_ID";
            bien[0] = "@HT_USER_ID";
            bien[1] = "@HT_ROOT_Active";
            bien[2] = "@HT_PQ_USER_Q_Xem";
            bien[3] = "@HT_ROOT_Form";

            //giatri[0] = Public.HT_PQ_USER_ID;
            giatri[0] = Public.HT_USER_ID;
            giatri[1] = Public.HT_ROOT_Active;
            giatri[2] = Public.HT_PQ_USER_Q_Xem;
            giatri[3] = Public.HT_ROOT_Form;
            return cls.LayDuLieu_Count("SP_HT_PQ_USER_Visible_BarButtonItem_Main_Para", bien, giatri, thamso);
        }

        //Lấy dữ liệu cho Form chức năng => Kiểm tra quyền người dùng => Hiển thị BarButtonItem thuộc Main menu
        public int Visible_BarButtonItem_Form(HT_PQ_USERPublic Public)
        {
            int thamso = 8;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];

            //bien[0] = "@HT_PQ_USER_ID";
            bien[0] = "@HT_USER_ID";
            bien[1] = "@HT_ROOT_Form";
            bien[2] = "@HT_PQ_USER_Q_Full";
            bien[3] = "@HT_PQ_USER_Q_Xem";
            bien[4] = "@HT_PQ_USER_Q_Them";
            bien[5] = "@HT_PQ_USER_Q_Xoa";
            bien[6] = "@HT_PQ_USER_Q_Sua";
            bien[7] = "@HT_ROOT_Active";

            //giatri[0] = Public.HT_PQ_USER_ID;
            giatri[0] = Public.HT_USER_ID;
            giatri[1] = Public.HT_ROOT_Form;
            giatri[2] = Public.HT_PQ_USER_Q_Full;
            giatri[3] = Public.HT_PQ_USER_Q_Xem;
            giatri[4] = Public.HT_PQ_USER_Q_Them;
            giatri[5] = Public.HT_PQ_USER_Q_Xoa;
            giatri[6] = Public.HT_PQ_USER_Q_Sua;
            giatri[7] = Public.HT_ROOT_Active;

            return cls.LayDuLieu_Count("SP_HT_PQ_USER_Visible_BarButtonItem_Form_Para", bien, giatri, thamso);
        }

        //Lấy dữ liệu cho frmMain => Kiểm tra quyền người dùng => Hiển thị RibbonPageGroup thuộc Ribbon
        public int VisiblePageGroup_Main(HT_PQ_USERPublic Public)
        {
            int thamso = 4;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            //bien[0] = "@HT_PQ_USER_ID";
            bien[0] = "@HT_USER_ID";
            bien[1] = "@HT_ROOT_Active";
            bien[2] = "@HT_PQ_USER_Q_Xem";
            bien[3] = "@HT_ROOT_Module_Cap_2";

            //giatri[0] = Public.HT_PQ_USER_ID;
            giatri[0] = Public.HT_USER_ID;
            giatri[1] = Public.HT_ROOT_Active;
            giatri[2] = Public.HT_PQ_USER_Q_Xem;
            giatri[3] = Public.HT_ROOT_Module_Cap_2;

            return cls.LayDuLieu_Count("SP_HT_PQ_USER_VisiblePageGroup_Main_Para", bien, giatri, thamso);
        }
        //Lấy dữ liệu cho frmMain => Kiểm tra quyền người dùng => Hiển thị RibbonPage thuộc Ribbon
        public int VisiblePage_Main(HT_PQ_USERPublic Public)
        {
            int thamso = 4;
            string[] bien = new string[thamso];
            object[] giatri = new object[thamso];
            //bien[0] = "@HT_PQ_USER_ID";
            bien[0] = "@HT_USER_ID";
            bien[1] = "@HT_ROOT_Active";
            bien[2] = "@HT_PQ_USER_Q_Xem";
            bien[3] = "@HT_ROOT_Module_Cap_1";

            //giatri[0] = Public.HT_PQ_USER_ID;
            giatri[0] = Public.HT_USER_ID;
            giatri[1] = Public.HT_ROOT_Active;
            giatri[2] = Public.HT_PQ_USER_Q_Xem;
            giatri[3] = Public.HT_ROOT_Module_Cap_1;

            return cls.LayDuLieu_Count("SP_HT_PQ_USER_VisiblePage_Main_Para", bien, giatri, thamso);
        }
    }
}
