using JSoft.ControlHorarios.Data;
using JSoft.ControlHorarios.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSoft.ControlHorarios.WinForms
{
    public partial class FrmInfoEmpleado : Form
    {
        private FrmMensaje msg;
        public FrmInfoEmpleado()
        {
            InitializeComponent();
        }

        private void TxtCodigoEmpleado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtCodigoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtCodigoEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Factory data = new Factory();
                Empleado empleado = data.GetEmpleadoByCode(TxtCodigoEmpleado.Text);

                if (empleado != null)
                {
                    TxtCodigoEmpleado.Enabled = false;
                    LblHoraRegistrada.Text = "Hora: " + DateTime.Now.ToString("hh:mm:ss tt");
                    TimerButton.Start();

                    TxtEmpleadoId.Text = empleado.Id.ToString();
                    LblNombres.Text = empleado.Nombre1 + ((" " + empleado.Nombre2) ?? "") + ((" " + empleado.Nombre3) ?? "");
                    LblApellidos.Text = empleado.Apellido1 + ((" " + empleado.Apellido2) ?? "") + ((" " + empleado.Apellido3) ?? "");
                    LblCargo.Text = (empleado.Cargo ?? "");
                    BtnRegistrar.Focus();
                    PanelEmpleado.Visible = true;
                }
                else
                {
                    TxtCodigoEmpleado.Text = "";
                }
            }
        }

        private void FrmInfoEmpleado_Load(object sender, EventArgs e)
        {
            LblHora.Text = "Hora: " + DateTime.Now.ToString("hh:mm:ss tt");
            TxtCodigoEmpleado.Focus();
            TimerHora.Start();
        }

        private void FrmInfoEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                PanelEmpleado.Visible = false;
                TxtCodigoEmpleado.Enabled = true;
                TimerButton.Stop();
                TxtCodigoEmpleado.Focus();
            }
        }

        private void TimerHora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = "Hora: " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void TimerButton_Tick(object sender, EventArgs e)
        {
            if (BtnRegistrar.BackColor == Color.Blue)
            {
                BtnRegistrar.BackColor = Color.Green;
            }
            else
            {
                BtnRegistrar.BackColor = Color.Blue;
            }
            BtnRegistrar.Focus();
        }

        private void BtnRegistrar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnRegistrar.PerformClick();
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Factory data = new Factory();
            if(data.RegistrarOperacion(Convert.ToInt32(TxtEmpleadoId.Text), DateTime.Now))
            {
                msg = new FrmMensaje("Operación registrada.");
                TimerMsg.Interval = 2000;
                TimerMsg.Start();
                msg.StartPosition = FormStartPosition.CenterParent;
                msg.ShowDialog(this);
            }
        }

        private void TimerMsg_Tick(object sender, EventArgs e)
        {
            if (msg != null)
            {
                TimerButton.Stop();
                msg.Close();
                msg = null;
                PanelEmpleado.Visible = false;
                TxtCodigoEmpleado.Enabled = true;                
                TxtCodigoEmpleado.Text = "";
                TxtCodigoEmpleado.Focus();
                TimerMsg.Interval = 500;
            }
            else
            {
                TxtCodigoEmpleado.Focus();
                TimerMsg.Stop();
            }
        }
    }
}
