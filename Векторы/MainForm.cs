using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Векторы
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            cBOperations.Items.AddRange(new string[] { "Умножение на число", "Длинна вектора", "Сумма векторов", "Разность векторов", "Скалярное произведение"});

            cBOperations.SelectedIndex = 0;
        }

        private void BtnRez_Click(object sender, EventArgs e)
        {

            if (tBx1.Text == string.Empty || tBy1.Text == string.Empty || tBz1.Text == string.Empty)
            {
                MessageBox.Show("Введите координаты вектора А");
                return;
            }

            double x1, y1, z1, x2, y2, z2, num;

            checkDouble(tBx1.Text, out x1);
            checkDouble(tBy1.Text, out y1);
            checkDouble(tBz1.Text, out z1);          

            string result = string.Empty;

            vector C;

            Vector a = new Vector();
            a.A = new vector(x1, y1, z1);

            if (cBOperations.SelectedIndex == 2 || cBOperations.SelectedIndex == 3 || cBOperations.SelectedIndex == 4)
            {

                if (tBx2.Text == string.Empty || tBy2.Text == string.Empty || tBz2.Text == string.Empty)
                {
                    MessageBox.Show("Введите координаты вектора B");
                    return;
                }

                checkDouble(tBx2.Text, out x2);
                checkDouble(tBy2.Text, out y2);
                checkDouble(tBz2.Text, out z2);               

                Vector b = new Vector();
                b.A = new vector(x2, y2, z2);

                if (cBOperations.SelectedIndex == 2)
                {
                    if (tBNum1.Text == string.Empty)
                    {
                        MessageBox.Show("Введите множитель");
                        return;
                    }

                    C = Vector.Sum(a.A, b.A);

                    result = $"Координаты вектора А + B равны ({C.X}; {C.Y}; {C.Z})";
                }
                else if (cBOperations.SelectedIndex == 3)
                {
                    C = Vector.Difference(a.A, b.A);

                    result = $"Координаты вектора А - B равны ({C.X}; {C.Y}; {C.Z})";
                }
                else if (cBOperations.SelectedIndex == 4)
                {
                    double scalar = Vector.Scalar(a.A, b.A);

                    result = $"Скалярное произведение векторов равно {scalar}";
                }
            }
            else
            {
                if (cBOperations.SelectedIndex == 0)
                {

                    if (tBNum1.Text == string.Empty)
                    {
                        MessageBox.Show("Введите множитель для вектора А");
                        return;
                    }

                    checkDouble(tBNum1.Text, out num);

                    C = a.MultiplicationByNumber(num);

                    result = $"Координаты вектора А равны ({C.X}; {C.Y}; {C.Z})";

                }
                else if (cBOperations.SelectedIndex == 1)
                {

                    double l1 = a.Length();

                    result += $"Длинна вектора А = {l1}";

                }
            }
            tBResult.Text = result;
        }

        private void notVisibleB()
        {
            label2.Visible = false;
            tBx2.Visible = false;
            tBy2.Visible = false;
            tBz2.Visible = false;
        }

        private void VisibleB()
        {
            label2.Visible = true;
            tBx2.Visible = true;
            tBy2.Visible = true;
            tBz2.Visible = true;
            label4.Visible = false;
            tBNum1.Visible = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBOperations_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (cBOperations.SelectedIndex == 0)
            {
                notVisibleB();
                label4.Visible = true;
                tBNum1.Visible = true;
            }
            else if (cBOperations.SelectedIndex == 1)
            {
                notVisibleB();
                label4.Visible = false;
                tBNum1.Visible = false;

            }
            else
            {
                VisibleB();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(Panel))
                {
                    foreach(Control c in control.Controls)
                    {
                        if (c.GetType() == typeof(TextBox))
                        {
                            c.Text = string.Empty;
                        }
                    }
                }
                
            }
        }

        private void checkDouble(string num, out double Num)
        {
            Num = 0;

            if (Double.TryParse(num, out double doubleNum))
            {
                Num = doubleNum;             
            }
            else
            {
                MessageBox.Show("Значения должны быть числовыми");
                return;
            }
        }
    }
}
