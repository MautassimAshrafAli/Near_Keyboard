using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyboard_
{
    public partial class btn_3 : UserControl
    {
        public btn_3()
        {
            InitializeComponent();
        }

        public Color btn_color 
        {
            get 
            {
                return btn.BaseColor;
            }
            set
            {
                btn.BaseColor = value;
            }
        }

        public string name_btn_
        {
            get 
            {
                return name_btn.Text;
            }
            set 
            {
                name_btn.Text = value;
            } 
        }

        public Color name_btn_color
        {
            get 
            {
                return name_btn.ForeColor;
            }
            set 
            {
                name_btn.ForeColor = value;
            }
        }

        public Point btn_name_loc
        {
            get
            {
                return name_btn.Location;
            }
            set 
            {
                name_btn.Location = value;
            }
        }

        public string name2_btn_
        {
            get
            {
                return name2_btn.Text;
            }
            set
            {
                name2_btn.Text = value;
            }
        }

        public Color name2_btn_color
        {
            get
            {
                return name2_btn.ForeColor;
            }
            set
            {
                name2_btn.ForeColor = value;
            }
        }

        public Point btn_name2_loc
        {
            get
            {
                return name2_btn.Location;
            }
            set
            {
                name2_btn.Location = value;
            }
        }

        public Padding btn_padding
        {
            get
            {
                return btn.Padding;
            }
            set 
            {
                btn.Padding = value;
            }
        }

        public Font btn_font 
        {
            get 
            {
                return name_btn.Font;
            }
            set 
            {
                name_btn.Font = value;
            }
        }

        public event EventHandler btn_click;
        private void btn_Click(object sender, EventArgs e)
        {
            this.btn_click(this, e);
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            btn.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            btn.BaseColor = Color.FromArgb(46, 46, 46);
        }
    }
}
