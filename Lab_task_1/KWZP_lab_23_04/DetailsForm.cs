using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP_lab_23_04
{
    public partial class DetailsForm : Form
    {
        public DetailsForm(SzwalniaEntities db, String employeeLastName)
        {
            InitializeComponent();

            Pracownicy employee = db.Pracownicy.Where(pracownik => pracownik.Nazwisko == employeeLastName).First();

            lblTitle.Text = employee.ID_Pracownika + ' ' + employee.Imie + ' ' + employee.Nazwisko.Trim();
            txtName.Text = employee.Imie.Trim();
            txtSurname.Text = employee.Nazwisko.Trim();
            txtPesel.Text = employee.Pesel.Trim();
            txtAdres.Text = employee.Adres.Trim();

            dgvEmployment.DataSource = db.vZatrudnienie.Where(employment => employment.ID_Pracownika == employee.ID_Pracownika).ToList();
        }

    }
}
