using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;
using System.ComponentModel;

namespace THACO.DAL
{
    public class Service
    {
        public List<KetQuaNgay> LayKetQuaNgay(DateTime datetime)
        {
            DataTable table = GetData(datetime);
            var List = new List<KetQuaNgay>(table.Rows.Count);
            foreach (DataRow row in table.Rows)
            {
                var values = row.ItemArray;
                var KetQuaNgay = new KetQuaNgay()
                {
                    ID =int.Parse(values[0].ToString()),
                    SanPhamID = int.Parse(values[1].ToString()),
                    MaSanPham = values[1].ToString(),
                    TenLoaiSP = values[1].ToString(),
                    LoaiSPID = int.Parse(values[1].ToString()),
                    MaLoaiSP = values[1].ToString(),
                    TenSanPham = values[1].ToString(),
                    KeHoachNgay = int.Parse(values[1].ToString()),
                    ThucHienNgay = int.Parse(values[1].ToString()),
                    ChenhLech = int.Parse(values[1].ToString()),
                    KeHoachThang = int.Parse(values[1].ToString()),
                    KetQuaThang = int.Parse(values[1].ToString())
                };
                List.Add(KetQuaNgay);
            }
            return List;
        }

        public DataTable GetData(DateTime datetime) {
            THACOEntities te = new THACOEntities();
            DataTable datatable = new DataTable();
            datatable = ToDataTable(te.KetQua_Ngay(datetime).ToList());
            return datatable;
        }

        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}
