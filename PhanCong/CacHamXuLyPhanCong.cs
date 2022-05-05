using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhanCong
{
    public class CacHamXuLyPhanCong
    {
        public void KhoiTaoNhanSu(NhanSu[] nhansu, int sonhansu)
        {
	        int i;
	        for(i = 0; i < sonhansu; i++)
	        {
		        nhansu[i].NS_TongThoiGian = 0;
		        nhansu[i].NS_SoCongViec = 0;
	        }
        }

        public void SapXepCongViec(CongViec[] congviec, int socongviec)
        {
	        int i, j;
	        for(i = 0; i < socongviec - 1; i++)
		        for(j = i + 1; j < socongviec; j++)
			        if(congviec[i].CV_ThoiGian < congviec[j].CV_ThoiGian)
				        HoanViCongViec(congviec[i], congviec[j]);
        }

        public void HoanViCongViec(CongViec Cv1, CongViec Cv2)
        {
            CongViec temp = new CongViec();

            //Hoan vi thoi gian cong viec
            temp.CV_ThoiGian = Cv1.CV_ThoiGian;
            Cv1.CV_ThoiGian = Cv2.CV_ThoiGian;
            Cv2.CV_ThoiGian = temp.CV_ThoiGian;

            // Hoan vi chi so cong viec
            temp.CV_MaCongViec = Cv1.CV_MaCongViec;
            Cv1.CV_MaCongViec = Cv2.CV_MaCongViec;
            Cv2.CV_MaCongViec = temp.CV_MaCongViec;
        }

        int NhanSuLamItNhat(NhanSu[] nhansu, int sonhansu)
        {
	        int i, f = 0;
	        int min = nhansu[0].NS_TongThoiGian;
	        for(i = 1; i < sonhansu; i++)
	        {
		        if(min > nhansu[i].NS_TongThoiGian)
		        {
			        min = nhansu[i].NS_TongThoiGian;
			        f = i;
		        }
	        }
	        return f;
        }

        public void ChiaCongViec(NhanSu[] nhansu, int sonhansu, CongViec[] congviec, int socongviec)
        {
	        int f, k, i;
            
            for (i = 0; i < sonhansu; i++)
            {
                nhansu[i].NS_CongViec = new CongViec[socongviec];
            }
                for (i = 0; i < socongviec; i++)
                {
                    // Chon nhan su co thoi gian lam viec it nhat
                    if (sonhansu > 1)
                        f = NhanSuLamItNhat(nhansu, sonhansu);
                    else
                        f = 0;
                    // So viec nhan su duoc chon da lam
                    k = nhansu[f].NS_SoCongViec;
                    // Them cong viec tiep theo cho may da chon
                    nhansu[f].NS_TongThoiGian += congviec[i].CV_ThoiGian;
                    nhansu[f].NS_CongViec[k] = new CongViec();
                    nhansu[f].NS_CongViec[k].CV_ThoiGian = congviec[i].CV_ThoiGian;
                    nhansu[f].NS_CongViec[k].CV_MaCongViec = congviec[i].CV_MaCongViec;
                    nhansu[f].NS_SoCongViec++;
                }
        }
    }
}
