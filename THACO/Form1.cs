using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using THACO.MODE;
using THACO.DAL;

namespace THACO
{
    public partial class Form1 : Form
    {
        Results results;
        int prevSelected = -1;
        bool autoupdate

;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            LISTCOM.Items.AddRange(ports);
        }

        private void textBox_NSX_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button_GetData_Click(object sender, EventArgs e) // DUA VAO TIMER2
        {
            string NSXstring = TB_NSX.Text;
            try {
                DateTime NSX = DateTime.Parse(NSXstring);
                try {
                    results = new Results(NSX);
                    var list = results.KQN;
                }
                catch {
                    MessageBox.Show("Loi Ket Noi CSDL");
                    return;
                }
                
                updateData();
                //selected item
                CB_SP1.Enter += cbb_enter;
                CB_SP2.Enter += cbb_enter;
                CB_SP3.Enter += cbb_enter;
                CB_SP4.Enter += cbb_enter;
                CB_SP5.Enter += cbb_enter;
                CB_SP6.Enter += cbb_enter;
                CB_SP7.Enter += cbb_enter;

                //hien thi datagridview
                Service s = new Service();
                var list2 = s.LayKetQuaNgay(NSX);
                dataGridView1.DataSource = new BindingSource(list2, "");
            }
            catch {
                MessageBox.Show("Nhập Ngày Hợp Lệ");
                return;
            }
            
            
        }

        private void comboBoxSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var cbb = sender as ComboBox;
            if (cbb.SelectedIndex!=0&&results.cbbIndex(cbb.SelectedIndex)!=-1&&(int)cbb.Tag!=results.cbbIndex(cbb.SelectedIndex))
            {
                MessageBox.Show("Da chon");
                cbb.SelectedIndex = 0;
                return;
            }
            //
            ChangeDataSelected(cbb);
        }

        private void cbb_enter(object sender, EventArgs e)
        {
            var cbb=sender as ComboBox;
            prevSelected = cbb.SelectedIndex;
        }

        private void BT_CONNECT_Click(object sender, EventArgs e)
        {
            if (BT_CONNECT.Text == "KẾT NỐI")
            {
                COM.PortName = LISTCOM.Text;
                COM.Open();
                TIMER1.Enabled = true;
                TIMER2.Enabled = true;
                BT_CONNECT.Text = "NGẮT KẾT NỐI";
            }
            else
            {
                try
                {
                    COM.Close();
                    TIMER1.Enabled = false;
                    TIMER2.Enabled = false;
                    BT_CONNECT.Text = "KẾT NỐI";
                }
                catch
                { return; }
            }
        }

        private void TIMER1_Tick(object sender, EventArgs e)
        {
            //textBox_NSX.Text = DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second;
            TB_NSX2.Text = DateTime.Now.Day + " / " + DateTime.Now.Month;
            TB_LKT.Text = DateTime.Now.Month + " ";
        }

        private void TIMER2_Tick(object sender, EventArgs e)
        {

            updateData();
            COM.Write("+" + CB_SP1.Text + "@" + CB_SP2.Text + "#" + CB_SP3.Text + "$" + CB_SP4.Text + "%" + CB_SP5.Text + "^" + CB_SP6.Text + "&" + CB_SP7.Text + "*" +
                      "-" + TB_THN1.Text + "A" + TB_THN2.Text + "B" + TB_THN3.Text + "C" + TB_THN4.Text + "D" + TB_THN5.Text + "E" + TB_THN6.Text + "F" + TB_THN7.Text + "G" + TB_TTHN.Text + "H" +
                            TB_TKHN.Text + "I" + TB_KHN7.Text + "J" + TB_KHN6.Text + "K" + TB_KHN5.Text + "L" + TB_KHN4.Text + "M" + TB_KHN3.Text + "N" + TB_KHN2.Text + "O" + TB_KHN1.Text + "P" +
                            TB_THT1.Text + "a" + TB_THT2.Text + "b" + TB_THT3.Text + "c" + TB_THT4.Text + "d" + TB_THT5.Text + "e" + TB_THT6.Text + "f" + TB_THT7.Text + "g" + TB_TTHT.Text + "h" +
                            TB_TKHT.Text + "i" + TB_KHT7.Text + "j" + TB_KHT6.Text + "k" + TB_KHT5.Text + "l" + TB_KHT4.Text + "m" + TB_KHT3.Text + "n" + TB_KHT2.Text + "o" + TB_KHT1.Text + "p" +
                            DateTime.Now.Month + "Q" + DateTime.Now.Second + "R" + DateTime.Now.Minute + "S" + DateTime.Now.Hour + "T" + DateTime.Now.Month + "U" + DateTime.Now.Day + "V");
        }
        public void updateData()
        {
            var list = results.updateList(results.NgaySX);
            autoupdate = true;
            CB_SP1.DataSource = new BindingSource(list, "");


            CB_SP2.DataSource = new BindingSource(list, "");


            CB_SP3.DataSource = new BindingSource(list, "");

            CB_SP4.DataSource = new BindingSource(list, "");

            CB_SP5.DataSource = new BindingSource(list, "");

            CB_SP6.DataSource = new BindingSource(list, "");

            CB_SP7.DataSource = new BindingSource(list, "");
            autoupdate = false;

            ChangeDataUpdated(CB_SP1);

            ChangeDataUpdated(CB_SP2);

            ChangeDataUpdated(CB_SP3);

            ChangeDataUpdated(CB_SP4);

            ChangeDataUpdated(CB_SP5);

            ChangeDataUpdated(CB_SP6);

            ChangeDataUpdated(CB_SP7);
            
        }
        public void ChangeDataUpdated(ComboBox cbb)
        {
            var cbbIndex = (int)cbb.Tag;
            cbb.SelectedIndex = results.ViTriSP(cbbIndex);
            ChangeData(cbb);
        }

        public void ChangeDataSelected(ComboBox cbb)
        {
            if (autoupdate) return;  
            var cbbIndex = (int)cbb.Tag;
            results.change(cbbIndex, cbb.SelectedIndex);
            ChangeData(cbb);
           
        }

        public void ChangeData(ComboBox cbb){
            var cbbIndex = (int)cbb.Tag;
            SPKetQuaNgay sp = cbb.SelectedItem as SPKetQuaNgay;
            # region swtich
            switch (cbbIndex)
            {
                case 0:
                    TB_THN1.Text = sp.ThucHienNgay.ToString();
                    TB_KHN1.Text = sp.KeHoachNgay.ToString();
                    TB_THT1.Text = sp.KetQuaThang.ToString();
                    TB_KHT1.Text = sp.KeHoachThang.ToString();
                    break;
                case 1:
                    TB_THN2.Text = sp.ThucHienNgay.ToString();
                    TB_KHN2.Text = sp.KeHoachNgay.ToString();
                    TB_THT2.Text = sp.KetQuaThang.ToString();
                    TB_KHT2.Text = sp.KeHoachThang.ToString();
                    break;
                case 2:
                    TB_THN3.Text = sp.ThucHienNgay.ToString();
                    TB_KHN3.Text = sp.KeHoachNgay.ToString();
                    TB_THT3.Text = sp.KetQuaThang.ToString();
                    TB_KHT3.Text = sp.KeHoachThang.ToString();
                    break;
                case 3:
                    TB_THN4.Text = sp.ThucHienNgay.ToString();
                    TB_KHN4.Text = sp.KeHoachNgay.ToString();
                    TB_THT4.Text = sp.KetQuaThang.ToString();
                    TB_KHT4.Text = sp.KeHoachThang.ToString();
                    break;
                case 4:
                    TB_THN5.Text = sp.ThucHienNgay.ToString();
                    TB_KHN5.Text = sp.KeHoachNgay.ToString();
                    TB_THT5.Text = sp.KetQuaThang.ToString();
                    TB_KHT5.Text = sp.KeHoachThang.ToString();
                    break;
                case 5:
                    TB_THN6.Text = sp.ThucHienNgay.ToString();
                    TB_KHN6.Text = sp.KeHoachNgay.ToString();
                    TB_THT6.Text = sp.KetQuaThang.ToString();
                    TB_KHT6.Text = sp.KeHoachThang.ToString();
                    break;
                case 6:
                    TB_THN7.Text = sp.ThucHienNgay.ToString();
                    TB_KHN7.Text = sp.KeHoachNgay.ToString();
                    TB_THT7.Text = sp.KetQuaThang.ToString();
                    TB_KHT7.Text = sp.KeHoachThang.ToString();
                    break;
                default: return;
            }
            #endregion swtich

            TB_TTHN.Text = results.TongThucHienNgay.ToString();
            TB_TKHN.Text = results.TongKeHoachNgay.ToString();
            TB_TTHT.Text = results.TongThucHienThang.ToString();
            TB_TKHT.Text = results.TongKeHoachThang.ToString();
        }




    }
}
