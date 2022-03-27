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

            label95.Text = "";
            label96.Text = "";
            label97.Text = "";
            label98.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                    Application.OpenForms[this.Name].Focus();

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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                

                this.WindowState = FormWindowState.Minimized;

            }
        }

        #region mouse_live_enter

       

        private void gunaElipsePanel1_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel1.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel1_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel1.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel2_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel2.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel2_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel2.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel3_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel3.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel3_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel3.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel4_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel4.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel4_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel4.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel5_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel5.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel5_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel5.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel6_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel6.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel6_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel6.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel7_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel7.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel7_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel7.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel8_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel8.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel8_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel8.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel9_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel9.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel9_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel9.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel10_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel10.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel10_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel10.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel11_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel11.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel11_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel11.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel12_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel12.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel12_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel12.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel13_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel13.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel13_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel13.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel14_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel14.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel14_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel14.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel15_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel15.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel15_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel15.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel16_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel16.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel16_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel16.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel17_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel17.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel17_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel17.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel18_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel18.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel18_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel18.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel19_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel19.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel19_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel19.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel20_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel20.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel20_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel20.BaseColor = Color.FromArgb(75, 75, 75);
        }
        private void gunaElipsePanel21_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel21.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel21_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel21.BaseColor = Color.FromArgb(75, 75, 75);
        }
        private void gunaElipsePanel22_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel22.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel22_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel22.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel23_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel23.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel23_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel23.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel24_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel24.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel24_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel24.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel25_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel25.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel25_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel25.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel26_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel26.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel26_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel26.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel27_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel27.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel27_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel27.BaseColor = Color.FromArgb(75, 75, 75);
        }
        private void gunaElipsePanel28_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel28.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel28_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel28.BaseColor = Color.FromArgb(75, 75, 75);
        }
        private void gunaElipsePanel29_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel29.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel29_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel29.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel30_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel30.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel30_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel30.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel31_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel31.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel31_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel31.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel32_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel32.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel32_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel32.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel33_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel33.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel33_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel33.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel34_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel34.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel34_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel34.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel35_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel35.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel35_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel35.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel36_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel36.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel36_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel36.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel37_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel37.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel37_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel37.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel38_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel38.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel38_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel38.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel39_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel39.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel39_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel39.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel40_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel40.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel40_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel40.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel41_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel41.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel41_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel41.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel42_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel42.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel42_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel42.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel43_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel43.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel43_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel43.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel44_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel44.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel44_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel44.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel45_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel45.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel45_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel45.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel46_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel46.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel46_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel46.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel47_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel47.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel47_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel47.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel48_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel48.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel48_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel48.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel49_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel49.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel49_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel49.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel50_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel50.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel50_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel50.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel51_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel51.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel51_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel51.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel52_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel52.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel52_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel52.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel53_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel53.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel53_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel53.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel54_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel54.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel54_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel54.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel55_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel55.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel55_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel55.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel56_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel56.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel56_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel56.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel57_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel57.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel57_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel57.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel58_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel58.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel58_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel58.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel59_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel59.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel59_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel59.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel60_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel60.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel60_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel60.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel61_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel61.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel61_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel61.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel62_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel62.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel62_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel62.BaseColor = Color.FromArgb(49, 49, 49);
        }

        private void gunaElipsePanel63_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel63.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel63_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel63.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel64_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel64.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel64_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel64.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel65_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel65.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel65_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel65.BaseColor = Color.FromArgb(49, 49, 49);
        }
        private void gunaElipsePanel66_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel66.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel66_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel66.BaseColor = Color.FromArgb(75, 75, 75);
        }
        private void gunaElipsePanel67_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel67.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel67_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel67.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel68_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel68.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel68_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel68.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel69_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel69.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel69_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel69.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel70_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel70.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel70_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel70.BaseColor = Color.FromArgb(75, 75, 75);
        }
        private void gunaElipsePanel71_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel71.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel71_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel71.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel72_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel72.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel72_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel72.BaseColor = Color.FromArgb(75, 75, 75);
        }

        private void gunaElipsePanel73_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel73.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel73_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel73.BaseColor = Color.FromArgb(75, 75, 75);
        }
        private void gunaElipsePanel74_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel74.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel74_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel74.BaseColor = Color.FromArgb(75, 75, 75);
        }
        private void gunaElipsePanel75_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel75.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel75_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel75.BaseColor = Color.FromArgb(75, 75, 75);
        }
        private void gunaElipsePanel76_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel76.BaseColor = Color.FromArgb(41, 41, 41);
        }
        private void gunaElipsePanel76_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel76.BaseColor = Color.FromArgb(75, 75, 75);
        }
        private void gunaElipsePanel77_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel77.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel77_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel77.BaseColor = Color.FromArgb(75, 75, 75);
        }
        private void gunaElipsePanel78_MouseEnter(object sender, EventArgs e)
        {
            gunaElipsePanel78.BaseColor = Color.FromArgb(41, 41, 41);
        }

        private void gunaElipsePanel78_MouseLeave(object sender, EventArgs e)
        {
            gunaElipsePanel78.BaseColor = Color.FromArgb(75, 75, 75);
        }

        #endregion

        #region AB

        int caps = 0;

        private void label59_Click(object sender, EventArgs e)
        {

            caps_up.Start();

            caps += 1;



        }
        

        private void caps_up_Tick(object sender, EventArgs e)
        {

            if (caps == 1) {

                q_.Text = "Q";
                w_.Text = "W";
                e_.Text = "E";
                r_.Text = "R";
                t_.Text = "T";
                y_.Text = "Y";
                u_.Text = "U";
                i_.Text = "I";
                o_.Text = "O";
                p_.Text = "P";
                a_.Text = "A";
                s_.Text = "S";
                d_.Text = "D";
                f_.Text = "F";
                g_.Text = "G";
                h_.Text = "H";
                j_.Text = "J";
                k_.Text = "K";
                l_.Text = "L";
                z_.Text = "Z";
                x_.Text = "X";
                c_.Text = "C";
                v_.Text = "V";
                b_.Text = "B";
                n_.Text = "N";
                m_.Text = "M";


            }
            if (caps == 2) {

                q_.Text = "q";
                w_.Text = "w";
                e_.Text = "e";
                r_.Text = "r";
                t_.Text = "t";
                y_.Text = "y";
                u_.Text = "u";
                i_.Text = "i";
                o_.Text = "o";
                p_.Text = "p";
                a_.Text = "a";
                s_.Text = "s";
                d_.Text = "d";
                f_.Text = "f";
                g_.Text = "g";
                h_.Text = "h";
                j_.Text = "j";
                k_.Text = "k";
                l_.Text = "l";
                z_.Text = "z";
                x_.Text = "x";
                c_.Text = "c";
                v_.Text = "v";
                b_.Text = "b";
                n_.Text = "n";
                m_.Text = "m";


                caps = 0;

            }
            
        }

        private void label44_Click(object sender, EventArgs e)
        {

            if (caps == 1)
            {

                SendKeys.Send("Q");

            }
            else {

                SendKeys.Send("q");
              
            }

            

        }

        private void label43_Click(object sender, EventArgs e)
        {

            if (caps == 1)
            {

                SendKeys.Send("W");

            }
            else
            {

                SendKeys.Send("w");

            }

        }

        private void e__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("E");

            }
            else
            {

                SendKeys.Send("e");

            }
        }

        private void r__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("R");

            }
            else
            {

                SendKeys.Send("r");

            }
        }

        private void t__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("T");

            }
            else
            {

                SendKeys.Send("t");

            }
        }

        private void y__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("Y");

            }
            else
            {

                SendKeys.Send("y");

            }
        }

        private void u__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("U");

            }
            else
            {

                SendKeys.Send("u");

            }
        }

        private void i__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("I");

            }
            else
            {

                SendKeys.Send("i");

            }
        }

        private void o__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("O");

            }
            else
            {

                SendKeys.Send("o");

            }
        }

        private void p__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("P");

            }
            else
            {

                SendKeys.Send("p");

            }
        }

        private void a__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("A");

            }
            else
            {

                SendKeys.Send("a");

            }
        }

        private void s__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("S");

            }
            else
            {

                SendKeys.Send("s");

            }
        }

        private void d__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("D");

            }
            else
            {

                SendKeys.Send("d");

            }
        }

        private void f__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("F");

            }
            else
            {

                SendKeys.Send("f");

            }
        }

        private void g__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("G");

            }
            else
            {

                SendKeys.Send("g");

            }
        }

        private void h__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("H");

            }
            else
            {

                SendKeys.Send("h");

            }
        }

        private void j__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("J");

            }
            else
            {

                SendKeys.Send("j");

            }
        }

        private void k__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("K");

            }
            else
            {

                SendKeys.Send("k");

            }
        }

        private void l__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("L");

            }
            else
            {

                SendKeys.Send("l");

            }
        }

        private void z__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("Z");

            }
            else
            {

                SendKeys.Send("z");

            }
        }

        private void x__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("X");

            }
            else
            {

                SendKeys.Send("x");

            }
        }

        private void c__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("C");

            }
            else
            {

                SendKeys.Send("c");

            }
        }

        private void v__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("V");

            }
            else
            {

                SendKeys.Send("v");

            }
        }

        private void b__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("B");

            }
            else
            {

                SendKeys.Send("b");

            }
        }

        private void n__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("N");

            }
            else
            {

                SendKeys.Send("n");

            }
        }

        private void m__Click(object sender, EventArgs e)
        {
            if (caps == 1)
            {

                SendKeys.Send("M");

            }
            else
            {

                SendKeys.Send("m");

            }
        }




        #endregion

        #region 1_@

       

        int sh = 0;
        private void label73_Click(object sender, EventArgs e)
        {
            shift_.Start();

            sh += 1;

        }
        private void shift__Tick(object sender, EventArgs e)
        {

            if (sh == 1) {

                _info_.ForeColor = Color.White;
                _at_.ForeColor = Color.White;
                _hash_.ForeColor = Color.White;
                _do_.ForeColor = Color.White;
                _mo_.ForeColor = Color.White;
                _up_.ForeColor = Color.White;
                _and_.ForeColor = Color.White;
                _as_.ForeColor = Color.White;
                _ob_.ForeColor = Color.White;
                _cb_.ForeColor = Color.White;
                _min_.ForeColor = Color.White;
                _add_.ForeColor = Color.White;
                _wav_.ForeColor = Color.White;
                _op_.ForeColor = Color.White;
                _cp_.ForeColor = Color.White;
                _or_.ForeColor = Color.White;
                _scop_.ForeColor = Color.White;
                _str_.ForeColor = Color.White;
                _smal_.ForeColor = Color.White;
                _large_.ForeColor = Color.White;
                _qs_.ForeColor = Color.White;

                _1_.ForeColor = Color.Silver;
                _2_.ForeColor = Color.Silver;
                _3_.ForeColor = Color.Silver;
                _4_.ForeColor = Color.Silver;
                _5_.ForeColor = Color.Silver;
                _6_.ForeColor = Color.Silver;
                _7_.ForeColor = Color.Silver;
                _8_.ForeColor = Color.Silver;
                _9_.ForeColor = Color.Silver;
                __0__.ForeColor = Color.Silver;

                _p1_.ForeColor = Color.Silver;
                _p2_.ForeColor = Color.Silver;
                _bs_.ForeColor = Color.Silver;
                _sime_.ForeColor = Color.Silver;
                _oc_.ForeColor = Color.Silver;
                _pa_.ForeColor = Color.Silver;
                _po_.ForeColor = Color.Silver;
                _s_.ForeColor = Color.Silver;
                _co_.ForeColor = Color.Silver;



            }
            if (sh == 2) {

                _info_.ForeColor = Color.Silver;
                _at_.ForeColor = Color.Silver;
                _hash_.ForeColor = Color.Silver;
                _do_.ForeColor = Color.Silver;
                _mo_.ForeColor = Color.Silver;
                _up_.ForeColor = Color.Silver;
                _and_.ForeColor = Color.Silver;
                _as_.ForeColor = Color.Silver;
                _ob_.ForeColor = Color.Silver;
                _cb_.ForeColor = Color.Silver;
                _min_.ForeColor = Color.Silver;
                _add_.ForeColor = Color.Silver;
                _wav_.ForeColor = Color.Silver;
                _op_.ForeColor = Color.Silver;
                _cp_.ForeColor = Color.Silver;
                _or_.ForeColor = Color.Silver;
                _scop_.ForeColor = Color.Silver;
                _str_.ForeColor = Color.Silver;
                _smal_.ForeColor = Color.Silver;
                _large_.ForeColor = Color.Silver;
                _qs_.ForeColor = Color.Silver;             

                _1_.ForeColor = Color.White;
                _2_.ForeColor = Color.White;
                _3_.ForeColor = Color.White;
                _4_.ForeColor = Color.White;
                _5_.ForeColor = Color.White;
                _6_.ForeColor = Color.White;
                _7_.ForeColor = Color.White;
                _8_.ForeColor = Color.White;
                _9_.ForeColor = Color.White;
                __0__.ForeColor = Color.White;

                _p1_.ForeColor = Color.White;
                _p2_.ForeColor = Color.White;
                _bs_.ForeColor = Color.White;
                _sime_.ForeColor = Color.White;
                _oc_.ForeColor = Color.White;
                _pa_.ForeColor = Color.White;
                _po_.ForeColor = Color.White;
                _s_.ForeColor = Color.White;
                _co_.ForeColor = Color.White;


                sh = 0;

            }

        }
        private void _1__Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

               
                SendKeys.Send("!");

            }
            else
            {

                SendKeys.Send("1");

            }
        }

        private void gunaElipsePanel12_Click(object sender, EventArgs e)
        {

            if (sh == 1)
            {

              
                SendKeys.Send("@");

            }
            else
            {

                  SendKeys.Send("2");

            }

        }

        private void _hash__Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

               
                SendKeys.Send("#");

            }
            else
            {

                SendKeys.Send("3");

            }
        }

        private void gunaElipsePanel10_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                
                SendKeys.Send("$");

            }
            else
            {

               SendKeys.Send("4"); 

            }
        }

        private void _mo__Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

             
                SendKeys.Send("{%}");

            }
            else
            {
                
                   SendKeys.Send("5");

            }
        }

        private void gunaElipsePanel7_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

               
                SendKeys.Send("{^}");

            }
            else
            {

                 SendKeys.Send("6");

            }
        }

        private void gunaElipsePanel6_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                
                SendKeys.Send("&");

            }
            else
            {

               SendKeys.Send("7");

            }
        }

        private void gunaElipsePanel5_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                
                SendKeys.Send("*");

            }
            else
            {

               SendKeys.Send("8");

            }
        }

        private void gunaElipsePanel4_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

               
                SendKeys.Send("{(}");

            }
            else
            {

                SendKeys.Send("9");

            }
        }

        private void gunaElipsePanel3_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

            
                SendKeys.Send("{)}");

            }
            else
            {
           
                   SendKeys.Send("0");

            }
        }

        private void gunaElipsePanel2_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                SendKeys.Send("{_}");

            }
            else
            {

                SendKeys.Send("{-}");

            }
        }

        private void gunaElipsePanel1_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                SendKeys.Send("{+}");

            }
            else
            {

                SendKeys.Send("{=}");

            }
        }

        private void _co__Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                SendKeys.Send("{~}");

            }
            else
            {

                SendKeys.Send("{`}");

            }
        }

        private void gunaElipsePanel39_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                SendKeys.Send("{{}");

            }
            else
            {

                SendKeys.Send("{[}");

            }
        }

        private void gunaElipsePanel40_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                SendKeys.Send("{}}");

            }
            else
            {

                SendKeys.Send("{]}");

            }
        }

        private void gunaElipsePanel41_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                SendKeys.Send("{|}");

            }
            else
            {

                SendKeys.Send("{\\}");

            }
        }

        private void gunaElipsePanel52_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                SendKeys.Send("{:}");

            }
            else
            {

                SendKeys.Send("{;}");

            }
        }

        private void gunaElipsePanel53_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                SendKeys.Send("{\"}");

            }
            else
            {

                SendKeys.Send("{'}");

            }
        }

        private void _smal__Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                SendKeys.Send("{<}");

            }
            else
            {

                SendKeys.Send("{,}");

            }
        }

        private void gunaElipsePanel64_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                SendKeys.Send("{>}");

            }
            else
            {

                SendKeys.Send("{.}");

            }
        }

        private void gunaElipsePanel65_Click(object sender, EventArgs e)
        {
            if (sh == 1)
            {

                SendKeys.Send("{?}");

            }
            else
            {

                SendKeys.Send("{/}");

            }
        }



        #endregion

        #region key_v

       
        private void gunaElipsePanel28_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void gunaElipsePanel54_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void gunaElipsePanel67_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^");
        }

        private void gunaElipsePanel70_Click(object sender, EventArgs e)
        {
            SendKeys.Send("%");
        }

        private void label95_Click(object sender, EventArgs e)
        {      
            SendKeys.Send("{LEFT}");
        }

        private void label96_Click(object sender, EventArgs e)
        {
          SendKeys.Send("{RIGHT}");
        }

        private void label97_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

        private void label98_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }
        private void gunaElipsePanel15_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{END}");
        }

        #endregion

        #region fn

        


        int fn__ = 0;
        private void gunaElipsePanel68_Click(object sender, EventArgs e)
        {

            fn_.Start();
            fn__ += 1;

        }

        private void fn__Tick(object sender, EventArgs e)
        {

            if (fn__ == 1) {

                _f1_.ForeColor = Color.White;
                _f2_.ForeColor = Color.White;
                _f3_.ForeColor = Color.White;
                _f4_.ForeColor = Color.White;
                _f5_.ForeColor = Color.White;
                _f6_.ForeColor = Color.White;
                _f7_.ForeColor = Color.White;
                _f8_.ForeColor = Color.White;
                _f9_.ForeColor = Color.White;
                _f10_.ForeColor = Color.White;
                _f11_.ForeColor = Color.White;
                _f12_.ForeColor = Color.White;

            }
            if (fn__ == 2) {

                _f1_.ForeColor = Color.Silver;
                _f2_.ForeColor = Color.Silver;
                _f3_.ForeColor = Color.Silver;
                _f4_.ForeColor = Color.Silver;
                _f5_.ForeColor = Color.Silver;
                _f6_.ForeColor = Color.Silver;
                _f7_.ForeColor = Color.Silver;
                _f8_.ForeColor = Color.Silver;
                _f9_.ForeColor = Color.Silver;
                _f10_.ForeColor = Color.Silver;
                _f11_.ForeColor = Color.Silver;
                _f12_.ForeColor = Color.Silver;

                fn__ = 0;
            }


        }

        private void gunaElipsePanel16_Click(object sender, EventArgs e)
        {
            if (fn__ == 1)
            {
            
                SendKeys.Send("{F1}");

            }

        }

        private void _f2__Click(object sender, EventArgs e)
        {
            if (fn__ == 1)
            {

                SendKeys.Send("{F2}");

            }
        }

        private void gunaElipsePanel18_Click(object sender, EventArgs e)
        {
            if (fn__ == 1)
            {

                SendKeys.Send("{F3}");

            }
        }

        private void gunaElipsePanel19_Click(object sender, EventArgs e)
        {
            if (fn__ == 1)
            {

                SendKeys.Send("{F4}");

            }
        }

        private void gunaElipsePanel20_Click(object sender, EventArgs e)
        {
            if (fn__ == 1)
            {

                SendKeys.Send("{F5}");

            }
        }

        private void gunaElipsePanel21_Click(object sender, EventArgs e)
        {
            if (fn__ == 1)
            {

                SendKeys.Send("{F6}");

            }
        }

        private void gunaElipsePanel22_Click(object sender, EventArgs e)
        {
            if (fn__ == 1)
            {

                SendKeys.Send("{F7}");

            }
        }

        private void gunaElipsePanel23_Click(object sender, EventArgs e)
        {
            if (fn__ == 1)
            {

                SendKeys.Send("{F8}");

            }
        }

        private void gunaElipsePanel24_Click(object sender, EventArgs e)
        {
            if (fn__ == 1)
            {

                SendKeys.Send("{F9}");

            }
        }

        private void _f10__Click(object sender, EventArgs e)
        {
            if (fn__ == 1)
            {

                SendKeys.Send("{F10}");

            }
        }

        private void gunaElipsePanel26_Click(object sender, EventArgs e)
        {
            if (fn__ == 1)
            {

                SendKeys.Send("{F11}");

            }
        }

        private void gunaElipsePanel27_Click(object sender, EventArgs e)
        {
            if (fn__ == 1)
            {

                SendKeys.Send("{F2}");

            }
        }


        #endregion

        #region del

        private void gunaElipsePanel78_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DELETE}");
        }
        private void gunaElipsePanel9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        #endregion

        private void label91_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            p.StandardInput.WriteLine("cd/ & cd windows & cd NEAR_OS & echo 1 > start_m_.txt");
            p.StandardInput.Flush();
            p.StandardInput.Close();

        }

        private void gunaElipsePanel71_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            p.StandardInput.WriteLine("cd/ & start osk.exe");
            p.StandardInput.Flush();
            p.StandardInput.Close();
        }
    }
}
