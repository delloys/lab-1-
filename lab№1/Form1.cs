using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        private Button currentButton;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.LightBlue; ;
                    currentButton.ForeColor = Color.Snow;     
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold,
                        System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.LightSteelBlue;
                    previousBtn.ForeColor = Color.DimGray;                  
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void buttonReplaceStr_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormeplaceStr(), sender);
        }

        private void buttonMatrix_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMatrix(), sender);
        }
    }
}
