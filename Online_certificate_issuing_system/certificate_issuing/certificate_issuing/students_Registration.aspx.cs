using certificate_issuing.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace certificate_issuing
{
    public partial class students_Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadStudents();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var CertificateSession = NhibernateDataProvider.OpenSession();
            {
                using (var SaveCertificate = CertificateSession.BeginTransaction())
                {
                    certificate NewCertificate = new certificate();

                    NewCertificate.AdmNo = TextBox2.Text;
                    NewCertificate.course = DropDownList1.SelectedIndex.ToString();
                    NewCertificate.DateJoined = Convert.ToDateTime(TextBox3.Text);
                    NewCertificate.dob = Convert.ToDateTime(TextBox7.Text);
                    NewCertificate.guardianEmail = TextBox10.Text;
                    NewCertificate.guardiansContact = TextBox11.Text;
                    NewCertificate.guardiansName = TextBox12.Text;
                    NewCertificate.StudentsFullNames = TextBox6.Text+ " "+ TextBox5.Text+" "+ TextBox4.Text;
                    NewCertificate.StudentsID = TextBox1.Text;
                    NewCertificate.year = DropDownList1.SelectedIndex;

                    CertificateSession.Save(NewCertificate);
                    SaveCertificate.Commit();
                    
                    loadStudents();
                }
            }
        }

        private void loadStudents()
        {
            throw new NotImplementedException();
        }
    }
}