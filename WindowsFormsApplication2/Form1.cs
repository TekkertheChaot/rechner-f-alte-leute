using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private double fn = 0, sn = 0, result = 0, m = 0;
        private ops operation = ops.UNASSIGNED;

        private enum ops
        {
            ADD, SUB, DIV, MULTIP, UNASSIGNED
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            addNumToField(1);
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            addNumToField(2);
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            addNumToField(3);
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            addNumToField(4);
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            addNumToField(5);
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            addNumToField(6);
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            addNumToField(7);
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            addNumToField(8);
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            addNumToField(9);
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            addNumToField(0);
        }

        private void addNumToField(int n)
        {
            String textfieldcontent = tf_lcd.Text;
            tf_lcd.Text = (textfieldcontent + n.ToString());
        }

        private void btn_delchar_Click(object sender, EventArgs e)
        {
            tf_lcd.Text = tf_lcd.Text.Substring(0, tf_lcd.Text.Length - 1);
        }

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            tf_lcd.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tf_lcd.Text != "")
            {
                fn = double.Parse(tf_lcd.Text);
                tf_lcd.Text = "";
                operation = ops.ADD;
            }
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            if (tf_lcd.Text != "")
            {
                sn = double.Parse(tf_lcd.Text);
                switch (operation)
                {
                    case ops.ADD:
                        result = opAdd();
                        break;
                    case ops.SUB:
                        result = opSub();
                        break;
                    case ops.DIV:
                        result = opDiv();
                        break;
                    case ops.MULTIP:
                        result = opMult();
                        break;
                    case ops.UNASSIGNED:
                        tf_lcd.Text = "RE";
                        return;
                    default:
                        tf_lcd.Text = "REeeeeeeeee";
                        break;
                }
                tf_lcd.Text = result.ToString();
            }
            else tf_lcd.Text = "RO";

        }

        private double opAdd()
        {
            return fn + sn;
        }

        private double opSub()
        {
            return fn - sn;
        }

        private double opDiv()
        {
            return fn / sn;
        }

        private double opMult()
        {
            return fn * sn;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (tf_lcd.Text != "")
            {
                fn = double.Parse(tf_lcd.Text);
                tf_lcd.Text = "";
                operation = ops.SUB;
            }
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (tf_lcd.Text != "")
            {
                fn = double.Parse(tf_lcd.Text);
                tf_lcd.Text = "";
                operation = ops.MULTIP;
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (tf_lcd.Text != "")
            {
                fn = double.Parse(tf_lcd.Text);
                tf_lcd.Text = "";
                operation = ops.DIV;
            }
        }

        private void btn_memory_Click(object sender, EventArgs e)
        {
            if (m != 0)
            {
                tf_lcd.Text = m.ToString();
            }
        }

        private void btn_addmem_Click(object sender, EventArgs e)
        {
            m += double.Parse(tf_lcd.Text);
            tf_lcd.Text = m.ToString();
        }

        private void btn_submem_Click(object sender, EventArgs e)
        {
            m -= double.Parse(tf_lcd.Text);
            tf_lcd.Text = m.ToString();
        }

        private void btn_comata_Click(object sender, EventArgs e)
        {
            tf_lcd.Text += ",";
        }
    }
}
