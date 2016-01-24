using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using THACO.DAL;

namespace THACO.MODE
{
    class Results
    {
        public List<SPKetQuaNgay> KQN { get; set; }
        public DateTime NgaySX { get; set; }
        int[] vitrisps;
        public int TongThucHienNgay
        {
            get
            {
                int temp = 0;
                foreach (var i in vitrisps)
                {
                    if (i != 0)
                    {
                        temp += KQN.ElementAt(i).ThucHienNgay;
                    }
                }
                return temp;
            }
        }
        public int TongKeHoachNgay
        {
            get
            {
                int temp = 0;
                foreach (var i in vitrisps)
                {
                    if (i != 0)
                    {
                        temp += KQN.ElementAt(i).KeHoachNgay;
                    }
                }
                return temp;
            }
        }
        public int TongThucHienThang
        {
            get
            {
                int temp = 0;
                foreach (var i in vitrisps)
                {
                    if (i != 0)
                    {
                        temp += KQN.ElementAt(i).KetQuaThang;
                    }
                }
                return temp;
            }
        }
        public int TongKeHoachThang
        {
            get
            {
                int temp = 0;
                foreach (var i in vitrisps)
                {
                    if (i != 0)
                    {
                        temp += KQN.ElementAt(i).KeHoachThang;
                    }
                }
                return temp;
            }
        }
        public List<SPKetQuaNgay> SelectedSP
        {
            get
            {
                var selectedSP = new List<SPKetQuaNgay>();
                foreach (var i in vitrisps)
                {
                    if (i != 0)
                    {
                        selectedSP.Add(KQN.ElementAt(i));
                    }
                }
                return selectedSP;
            }
        }

        public Results(DateTime NSX)
        {
            List<SPKetQuaNgay> list = updateList(NSX);
            if (list == null) throw new ArgumentNullException();
            KQN = list;
            NgaySX = NSX;
            vitrisps = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        }

        public void change(int vitricbb, int vitrisp)
        {
            vitrisps[vitricbb] = vitrisp;
        }

        public List<SPKetQuaNgay> updateList(DateTime NSX)
        {
            Service service = new Service();
            List<SPKetQuaNgay> list = service.LayKetQuaNgay(NSX);
            list.Insert(0, new SPKetQuaNgay() { TenSanPham = "---Select---" });
            return list;

        }
        public bool isSelected(int p)
        {
            foreach (var i in vitrisps) {
                if (p == i) return true;
            }
            return false;
        }
    }
}
