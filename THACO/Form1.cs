using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using THACO.MODE;
using THACO.DAL;

namespace THACO
{
    public partial class Form1 : Form
    {
        Results results;
        int prevSelected = -1;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_NSX_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button_GetData_Click(object sender, EventArgs e)
        {
            string NSXstring = textBox_NSX.Text;
            try {
                DateTime NSX = DateTime.Parse(NSXstring);
                results = new Results(NSX);
                var list=results.KQN;
                
                comboBox_sp1.DataSource = new BindingSource(list, "");
                comboBox2.DataSource = new BindingSource(list, "");
                comboBox3.DataSource = new BindingSource(list, "");
                comboBox4.DataSource = new BindingSource(list, "");
                comboBox5.DataSource = new BindingSource(list, "");
                comboBox6.DataSource = new BindingSource(list, "");
                comboBox7.DataSource = new BindingSource(list, "");
                comboBox_sp1.Enter += cbb_enter;
                comboBox2.Enter += cbb_enter;
                comboBox3.Enter += cbb_enter;
                comboBox4.Enter += cbb_enter;
                comboBox5.Enter += cbb_enter;
                comboBox6.Enter += cbb_enter;
                comboBox7.Enter += cbb_enter;
               
            }
            catch {
                MessageBox.Show("Nhap ngay Hop le");
            }
            
            
        }

        private void comboBox_sp1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPKetQuaNgay sp = (SPKetQuaNgay)comboBox_sp1.SelectedItem;
            textBox_THN1.Text = sp.ThucHienNgay.ToString();
            textBox_KHN1.Text = sp.KeHoachNgay.ToString();
            textBox_THT1.Text = sp.KetQuaThang.ToString();
            textBox_KHT1.Text = sp.KeHoachThang.ToString();

            results.change(0, comboBox_sp1.SelectedIndex-1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPKetQuaNgay sp = (SPKetQuaNgay)comboBox2.SelectedItem;
            textBox_THN2.Text = sp.ThucHienNgay.ToString();
            textBox_KHN2.Text = sp.KeHoachNgay.ToString();
            textBox_THT2.Text = sp.KetQuaThang.ToString();
            textBox_KHT2.Text = sp.KeHoachThang.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPKetQuaNgay sp = (SPKetQuaNgay)comboBox3.SelectedItem;
            textBox_THN3.Text = sp.ThucHienNgay.ToString();
            textBox_KHN3.Text = sp.KeHoachNgay.ToString();
            textBox_THT3.Text = sp.KetQuaThang.ToString();
            textBox_KHT3.Text = sp.KeHoachThang.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPKetQuaNgay sp = (SPKetQuaNgay)comboBox4.SelectedItem;
            textBox_THN4.Text = sp.ThucHienNgay.ToString();
            textBox_KHN4.Text = sp.KeHoachNgay.ToString();
            textBox_THT4.Text = sp.KetQuaThang.ToString();
            textBox_KHT4.Text = sp.KeHoachThang.ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPKetQuaNgay sp = (SPKetQuaNgay)comboBox5.SelectedItem;
            textBox_THN5.Text = sp.ThucHienNgay.ToString();
            textBox_KHN5.Text = sp.KeHoachNgay.ToString();
            textBox_THT5.Text = sp.KetQuaThang.ToString();
            textBox_KHT5.Text = sp.KeHoachThang.ToString();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPKetQuaNgay sp = (SPKetQuaNgay)comboBox6.SelectedItem;
            textBox_THN6.Text = sp.ThucHienNgay.ToString();
            textBox_KHN6.Text = sp.KeHoachNgay.ToString();
            textBox_THT6.Text = sp.KetQuaThang.ToString();
            textBox_KHT6.Text = sp.KeHoachThang.ToString();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPKetQuaNgay sp = (SPKetQuaNgay)comboBox7.SelectedItem;
            textBox_THN7.Text = sp.ThucHienNgay.ToString();
            textBox_KHN7.Text = sp.KeHoachNgay.ToString();
            textBox_THT7.Text = sp.KetQuaThang.ToString();
            textBox_KHT7.Text = sp.KeHoachThang.ToString();
        }
        private void comboBoxSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var cbb = sender as ComboBox;
            if (cbb.SelectedIndex!=0&&results.isSelected(cbb.SelectedIndex))
            {
                MessageBox.Show("Da chon");
                cbb.SelectedIndex = 0;
                return;
            }
            SPKetQuaNgay sp = cbb.SelectedItem as SPKetQuaNgay;
            var cbbIndex = (int)cbb.Tag;
            switch (cbbIndex) {
                case 0: 
                    textBox_THN1.Text = sp.ThucHienNgay.ToString();
                    textBox_KHN1.Text = sp.KeHoachNgay.ToString();
                    textBox_THT1.Text = sp.KetQuaThang.ToString();
                    textBox_KHT1.Text = sp.KeHoachThang.ToString();
                    break;
                case 1:
                    textBox_THN2.Text = sp.ThucHienNgay.ToString();
                    textBox_KHN2.Text = sp.KeHoachNgay.ToString();
                    textBox_THT2.Text = sp.KetQuaThang.ToString();
                    textBox_KHT2.Text = sp.KeHoachThang.ToString();
                    break;
                case 2:
                    textBox_THN3.Text = sp.ThucHienNgay.ToString();
                    textBox_KHN3.Text = sp.KeHoachNgay.ToString();
                    textBox_THT3.Text = sp.KetQuaThang.ToString();
                    textBox_KHT3.Text = sp.KeHoachThang.ToString();
                    break;
                case 3:
                    textBox_THN4.Text = sp.ThucHienNgay.ToString();
                    textBox_KHN4.Text = sp.KeHoachNgay.ToString();
                    textBox_THT4.Text = sp.KetQuaThang.ToString();
                    textBox_KHT4.Text = sp.KeHoachThang.ToString();
                    break;
                case 4:
                    textBox_THN5.Text = sp.ThucHienNgay.ToString();
                    textBox_KHN5.Text = sp.KeHoachNgay.ToString();
                    textBox_THT5.Text = sp.KetQuaThang.ToString();
                    textBox_KHT5.Text = sp.KeHoachThang.ToString();
                    break;
                case 5:
                    textBox_THN6.Text = sp.ThucHienNgay.ToString();
                    textBox_KHN6.Text = sp.KeHoachNgay.ToString();
                    textBox_THT6.Text = sp.KetQuaThang.ToString();
                    textBox_KHT6.Text = sp.KeHoachThang.ToString();
                    break;
                case 6:
                    textBox_THN7.Text = sp.ThucHienNgay.ToString();
                    textBox_KHN7.Text = sp.KeHoachNgay.ToString();
                    textBox_THT7.Text = sp.KetQuaThang.ToString();
                    textBox_KHT7.Text = sp.KeHoachThang.ToString();
                    break;
                default: return;                    
            }
            results.change(cbbIndex, cbb.SelectedIndex);
            textBox_TTHN.Text = results.TongThucHienNgay.ToString();
            textBox_TKHN.Text = results.TongKeHoachNgay.ToString();
            textBox_TTHT.Text = results.TongThucHienThang.ToString();
            textBox_TKHT.Text = results.TongKeHoachThang.ToString();
        }

        private void cbb_enter(object sender, EventArgs e)
        {
            var cbb=sender as ComboBox;
            prevSelected = cbb.SelectedIndex;
        }


    }
}
