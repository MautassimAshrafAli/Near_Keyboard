using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace keyboard_
{
    public partial class keyboard_form : Form
    {
        protected override CreateParams CreateParams
        {

            get
            {

                CreateParams param_ = base.CreateParams;
                param_.ExStyle |= 0x08000000;
                return param_;

            }

        }

        public keyboard_form()
        {
            InitializeComponent();

            arrow_l_btn.name_btn_ = char.ConvertFromUtf32(0xE016);
            arrow_r_btn.name_btn_ = char.ConvertFromUtf32(0xE017);
            arrow_up_btn.name_btn_ = char.ConvertFromUtf32(0xE018);
            arrow_down_btn.name_btn_ = char.ConvertFromUtf32(0xE011);

            this.CenterToScreen();

            TopMost = true;

            this.KeyPreview = true;

            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    timer4.Stop();
                }

                if (this.Opacity < 1)
                {
                    this.Opacity += .1;
                }
                else
                {
                    timer4.Stop();
                }
            }
            catch (Exception)
            {

            }
        }

        private void a_h_Tick(object sender, EventArgs e)
        {
            this.Opacity -= .1;

            if (this.Opacity < .90)
            {

                a_h.Stop();

            }
        }

        private void keyboard_form_MouseDown(object sender, MouseEventArgs e)
        {
            a_h.Start();
        }

        private void keyboard_form_MouseUp(object sender, MouseEventArgs e)
        {
            timer4.Start();
        }

        private void close_win_Click(object sender, EventArgs e)
        {
            keybd_event(VK_SHIFT, 0, KEYEVENTF_KEYUP, 0);

            this.Close();
        }

        private void min_win_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            { this.WindowState = FormWindowState.Minimized; }
        }

        #region invoke key

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private const int KEYEVENTF_KEYDOWN = 0;
        private const int KEYEVENTF_EXTENDEDKEY = 1;
        private const int KEYEVENTF_KEYUP = 2;

        public static void KeyDown_(Keys vKey)
        {
            keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY, 0);
        }

        public static void KeyUp_(Keys vKey)
        {
            keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        private static void PressKey(byte keyCode)
        {
            keybd_event(keyCode, 0x45, KEYEVENTF_EXTENDEDKEY, 0);
            keybd_event(keyCode, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }


        #endregion

        #region AB

        int caps = 0;

        private void caps_Click(object sender, EventArgs e)
        {

            caps += 1;

            caps_up_Tick_task();
        }
        private void caps_up()
        {
            if (caps == 1)
            {

                q_.name_btn_ = "Q";
                w_.name_btn_ = "W";
                e_.name_btn_ = "E";
                r_.name_btn_ = "R";
                t_.name_btn_ = "T";
                y_.name_btn_ = "Y";
                u_.name_btn_ = "U";
                i_.name_btn_ = "I";
                o_.name_btn_ = "O";
                p_.name_btn_ = "P";
                a_.name_btn_ = "A";
                s_.name_btn_ = "S";
                d_.name_btn_ = "D";
                f_.name_btn_ = "F";
                g_.name_btn_ = "G";
                h_.name_btn_ = "H";
                j_.name_btn_ = "J";
                k_.name_btn_ = "K";
                l_.name_btn_ = "L";
                z_.name_btn_ = "Z";
                x_.name_btn_ = "X";
                c_.name_btn_ = "C";
                v_.name_btn_ = "V";
                b_.name_btn_ = "B";
                n_.name_btn_ = "N";
                m_.name_btn_ = "M";

            }
            else if (caps == 2)
            {

                q_.name_btn_ = "q";
                w_.name_btn_ = "w";
                e_.name_btn_ = "e";
                r_.name_btn_ = "r";
                t_.name_btn_ = "t";
                y_.name_btn_ = "y";
                u_.name_btn_ = "u";
                i_.name_btn_ = "i";
                o_.name_btn_ = "o";
                p_.name_btn_ = "p";
                a_.name_btn_ = "a";
                s_.name_btn_ = "s";
                d_.name_btn_ = "d";
                f_.name_btn_ = "f";
                g_.name_btn_ = "g";
                h_.name_btn_ = "h";
                j_.name_btn_ = "j";
                k_.name_btn_ = "k";
                l_.name_btn_ = "l";
                z_.name_btn_ = "z";
                x_.name_btn_ = "x";
                c_.name_btn_ = "c";
                v_.name_btn_ = "v";
                b_.name_btn_ = "b";
                n_.name_btn_ = "n";
                m_.name_btn_ = "m";


                caps = 0;

            }
        }
        private void caps_up_Tick_task()
        {
            caps_up();

            KeyDown_(Keys.CapsLock);
            KeyUp_(Keys.CapsLock);

        }

        private void q_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Q);
            KeyUp_(Keys.Q);
        }

        private void w_Click(object sender, EventArgs e)
        {

            KeyDown_(Keys.W);
            KeyUp_(Keys.W);

        }

        private void e_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.E);
            KeyUp_(Keys.E);
        }

        private void r_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.E);
            KeyUp_(Keys.E);
        }

        private void t_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.T);
            KeyUp_(Keys.T);
        }

        private void y_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Y);
            KeyUp_(Keys.Y);
        }

        private void u_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.U);
            KeyUp_(Keys.U);
        }

        private void i_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.U);
            KeyUp_(Keys.U);
        }

        private void o_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.U);
            KeyUp_(Keys.U);
        }

        private void p_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.U);
            KeyUp_(Keys.U);
        }

        private void a_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.A);
            KeyUp_(Keys.A);
        }

        private void s_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.S);
            KeyUp_(Keys.S);
        }

        private void d_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.D);
            KeyUp_(Keys.D);
        }

        private void f_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.F);
            KeyUp_(Keys.F);
        }

        private void g_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.G);
            KeyUp_(Keys.G);
        }

        private void h_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.H);
            KeyUp_(Keys.H);
        }

        private void j_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.J);
            KeyUp_(Keys.J);
        }

        private void k_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.K);
            KeyUp_(Keys.K);
        }

        private void l_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.L);
            KeyUp_(Keys.L);
        }

        private void z_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.L);
            KeyUp_(Keys.L);
        }

        private void x_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.X);
            KeyUp_(Keys.X);
        }

        private void c_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.C);
            KeyUp_(Keys.C);
        }

        private void v_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.V);
            KeyUp_(Keys.V);
        }

        private void b_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.B);
            KeyUp_(Keys.B);
        }

        private void n_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.N);
            KeyUp_(Keys.N);
        }

        private void m_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.M);
            KeyUp_(Keys.M);
        }


        #endregion

        #region 1_@

        private const int VK_SHIFT = 0x10;

        int sh = 0;
        private void shift_Click(object sender, EventArgs e)
        { 
            sh += 1;
            caps += 1;
            shift__Tick_task();
            caps_up();
            
        }
        private void shift__Tick_task()
        {
            if (sh == 1)
            {

                s1_.name2_btn_color = Color.White;
                s2_.name2_btn_color = Color.White;
                s3_.name2_btn_color = Color.White;
                s4_.name2_btn_color = Color.White;
                s5_.name2_btn_color = Color.White;
                s6_.name2_btn_color = Color.White;
                s7_.name2_btn_color = Color.White;
                s8_.name2_btn_color = Color.White;
                s9_.name2_btn_color = Color.White;
                s10_.name2_btn_color = Color.White;
                s11_.name2_btn_color = Color.White;
                s12_.name2_btn_color = Color.White;
                s13_.name2_btn_color = Color.White;
                s14_.name2_btn_color = Color.White;
                s15_.name2_btn_color = Color.White;
                s16_.name2_btn_color = Color.White;
                s17_.name2_btn_color = Color.White;
                s18_.name2_btn_color = Color.White;
                s19_.name2_btn_color = Color.White;
                s20_.name2_btn_color = Color.White;
                s21_.name2_btn_color = Color.White;

                s1_.name_btn_color = Color.Silver;
                s2_.name_btn_color = Color.Silver;
                s3_.name_btn_color = Color.Silver;
                s4_.name_btn_color = Color.Silver;
                s5_.name_btn_color = Color.Silver;
                s6_.name_btn_color = Color.Silver;
                s7_.name_btn_color = Color.Silver;
                s8_.name_btn_color = Color.Silver;
                s9_.name_btn_color = Color.Silver;
                s10_.name_btn_color = Color.Silver;
                s11_.name_btn_color = Color.Silver;
                s12_.name_btn_color = Color.Silver;
                s13_.name_btn_color = Color.Silver;
                s14_.name_btn_color = Color.Silver;
                s15_.name_btn_color = Color.Silver;
                s16_.name_btn_color = Color.Silver;
                s17_.name_btn_color = Color.Silver;
                s18_.name_btn_color = Color.Silver;
                s19_.name_btn_color = Color.Silver;
                s20_.name_btn_color = Color.Silver;
                s21_.name_btn_color = Color.Silver;
                
                keybd_event(VK_SHIFT, 0, KEYEVENTF_KEYDOWN, 0);

            }
            else if (sh == 2)
            {
                keybd_event(VK_SHIFT, 0, KEYEVENTF_KEYUP, 0);

                s1_.name2_btn_color = Color.Silver;
                s2_.name2_btn_color = Color.Silver;
                s3_.name2_btn_color = Color.Silver;
                s4_.name2_btn_color = Color.Silver;
                s5_.name2_btn_color = Color.Silver;
                s6_.name2_btn_color = Color.Silver;
                s7_.name2_btn_color = Color.Silver;
                s8_.name2_btn_color = Color.Silver;
                s9_.name2_btn_color = Color.Silver;
                s10_.name2_btn_color = Color.Silver;
                s11_.name2_btn_color = Color.Silver;
                s12_.name2_btn_color = Color.Silver;
                s13_.name2_btn_color = Color.Silver;
                s14_.name2_btn_color = Color.Silver;
                s15_.name2_btn_color = Color.Silver;
                s16_.name2_btn_color = Color.Silver;
                s17_.name2_btn_color = Color.Silver;
                s18_.name2_btn_color = Color.Silver;
                s19_.name2_btn_color = Color.Silver;
                s20_.name2_btn_color = Color.Silver;
                s21_.name2_btn_color = Color.Silver;

                s1_.name_btn_color = Color.White;
                s2_.name_btn_color = Color.White;
                s3_.name_btn_color = Color.White;
                s4_.name_btn_color = Color.White;
                s5_.name_btn_color = Color.White;
                s6_.name_btn_color = Color.White;
                s7_.name_btn_color = Color.White;
                s8_.name_btn_color = Color.White;
                s9_.name_btn_color = Color.White;
                s10_.name_btn_color = Color.White;
                s11_.name_btn_color = Color.White;
                s12_.name_btn_color = Color.White;
                s13_.name_btn_color = Color.White;
                s14_.name_btn_color = Color.White;
                s15_.name_btn_color = Color.White;
                s16_.name_btn_color = Color.White;
                s17_.name_btn_color = Color.White;
                s18_.name_btn_color = Color.White;
                s19_.name_btn_color = Color.White;
                s20_.name_btn_color = Color.White;
                s21_.name_btn_color = Color.White;

                sh = 0;

            }


        }
        private void s2_Click(object sender, EventArgs e)
        {

            KeyDown_(Keys.D1);
            KeyUp_(Keys.D1);

        }

        private void s3_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.D2);
            KeyUp_(Keys.D2);

        }

        private void s4_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.D3);
            KeyUp_(Keys.D3);
        }

        private void s5_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.D4);
            KeyUp_(Keys.D4);
        }

        private void s6_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.D5);
            KeyUp_(Keys.D5);
        }

        private void s7_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.D6);
            KeyUp_(Keys.D6);
        }

        private void s8_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.D7);
            KeyUp_(Keys.D7);
        }

        private void s9_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.D8);
            KeyUp_(Keys.D8);
        }

        private void s10_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.D9);
            KeyUp_(Keys.D9);
        }
        
        private void s11_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.D0);
            KeyUp_(Keys.D0);
        }

        private void s12_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.OemMinus);
            KeyUp_(Keys.OemMinus);
        }

        private void s13_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Oemplus);
            KeyUp_(Keys.Oemplus);
        }

        private void s1_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Oemtilde);
            KeyUp_(Keys.Oemtilde);
        }

        private void s14_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.OemOpenBrackets);
            KeyUp_(Keys.OemOpenBrackets);
        }

        private void s15_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.OemCloseBrackets);
            KeyUp_(Keys.OemCloseBrackets);
        }

        private void s16_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.OemPipe);
            KeyUp_(Keys.OemPipe);
        }

        private void s17_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.OemSemicolon);
            KeyUp_(Keys.OemSemicolon);
        }

        private void s18_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.OemQuotes);
            KeyUp_(Keys.OemQuotes);
        }

        private void s19_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Oemcomma);
            KeyUp_(Keys.Oemcomma);
        }

        private void s20_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.OemPeriod);
            KeyUp_(Keys.OemPeriod);
        }

        private void s21_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.OemQuestion);
            KeyUp_(Keys.OemQuestion);
        }

        #endregion

        #region key_v


        private void tab_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Tab);
            KeyUp_(Keys.Tab);
        }

        private void enter_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Enter);
            KeyUp_(Keys.Enter);
        }

        private void ctrl_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Control);
            KeyUp_(Keys.Control);
        }

        private void alt_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Alt);
            KeyUp_(Keys.Alt);
        }

        private void arrow_l_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Left);
            KeyUp_(Keys.Left);
        }

        private void arrow_r_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Right);
            KeyUp_(Keys.Right);
        }

        private void arrow_up_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Up);
            KeyUp_(Keys.Up);
        }

        private void arrow_dwon_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Down);
            KeyUp_(Keys.Down);
        }
        private void esc_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Escape);
            KeyUp_(Keys.Escape);
        }

        #endregion

        #region fn
        int fn__ = 0;
        private void fn_Click(object sender, EventArgs e)
        {
            fn__ += 1;
            fn__Tick_task();
        }

        private void fn__Tick_task()
        {
            if (fn__ == 1)
            {

                _f1_.name_btn_color = Color.White;
                _f2_.name_btn_color = Color.White;
                _f3_.name_btn_color = Color.White;
                _f4_.name_btn_color = Color.White;
                _f5_.name_btn_color = Color.White;
                _f6_.name_btn_color = Color.White;
                _f7_.name_btn_color = Color.White;
                _f8_.name_btn_color = Color.White;
                _f9_.name_btn_color = Color.White;
                _f10_.name_btn_color = Color.White;
                _f11_.name_btn_color = Color.White;
                _f12_.name_btn_color = Color.White;

            }
            else if (fn__ == 2)
            {

                _f1_.name_btn_color = Color.Silver;
                _f2_.name_btn_color = Color.Silver;
                _f3_.name_btn_color = Color.Silver;
                _f4_.name_btn_color = Color.Silver;
                _f5_.name_btn_color = Color.Silver;
                _f6_.name_btn_color = Color.Silver;
                _f7_.name_btn_color = Color.Silver;
                _f8_.name_btn_color = Color.Silver;
                _f9_.name_btn_color = Color.Silver;
                _f10_.name_btn_color = Color.Silver;
                _f11_.name_btn_color = Color.Silver;
                _f12_.name_btn_color = Color.Silver;

                fn__ = 0;
            }

            PressKey(0x3F);
        }

        private void _f1_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.F1);
            KeyUp_(Keys.F1);

        }

        private void _f2_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.F2);
            KeyUp_(Keys.F2);
        }

        private void _f3_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.F3);
            KeyUp_(Keys.F3);
        }

        private void _f4_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.F4);
            KeyUp_(Keys.F4);
        }

        private void _f5_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.F5);
            KeyUp_(Keys.F5);
        }

        private void _f6_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.F6);
            KeyUp_(Keys.F6);
        }

        private void _f7_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.F7);
            KeyUp_(Keys.F7);
        }

        private void _f8_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.F8);
            KeyUp_(Keys.F8);
        }

        private void _f9_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.F9);
            KeyUp_(Keys.F9);
        }

        private void _f10_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.F10);
            KeyUp_(Keys.F10);
        }

        private void _f11_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.F11);
            KeyUp_(Keys.F11);
        }

        private void _f12_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.F12);
            KeyUp_(Keys.F12);
        }


        #endregion

        #region del

        private void del2_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Delete);
            KeyUp_(Keys.Delete);
        }
        private void backspace_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.Back);
            KeyUp_(Keys.Back);
        }

        #endregion

        #region win btn

        private void start_Click(object sender, EventArgs e)
        {
            KeyDown_(Keys.LWin);
            KeyUp_(Keys.LWin);

        }

        #endregion

        private void space_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void keyboard_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.M)
            {
                e.SuppressKeyPress = true;

                this.WindowState = FormWindowState.Minimized;

            }

        }
    }
}
