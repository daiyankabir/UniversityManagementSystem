using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagementSystem
{
    public partial class HomeForm : BaseForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            UserInfoForm uif = new UserInfoForm(this);
            uif.Show();
            this.Hide();
        }
        
    }
}
