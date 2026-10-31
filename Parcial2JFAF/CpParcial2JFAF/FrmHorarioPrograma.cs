using CadParcial2JFAF;
using ClnParcial2JFAF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpParcial2JFAF
{
    public partial class FrmHorarioPrograma : Form
    {
        private bool esNuevo;
        public FrmHorarioPrograma()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var programas = HorarioProgramaCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = programas;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idCanal"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombreCanal"].HeaderText = "Nombre de Canal";
            dgvLista.Columns["titulo"].HeaderText = "Título";
            dgvLista.Columns["horaInicio"].HeaderText = "Hora de Inicio";
            dgvLista.Columns["horaFin"].HeaderText = "Hora de Fin";
            dgvLista.Columns["diaSemana"].HeaderText = "Dia del Programa";
            dgvLista.Columns["conductorPrincipal"].HeaderText = "Conductor Principal";

            if (programas.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["nombreCanal"];
            btnEditar.Enabled = programas.Count > 0;
            btnEliminar.Enabled = programas.Count > 0;
        }
        private void cargarCanales()
        {
            cbxCanal.DataSource = CanalCln.listar();
            cbxCanal.ValueMember = "id";
            cbxCanal.DisplayMember = "nombre";
            cbxCanal.SelectedIndex = -1;
        }
        private void FrmHorarioPrograma_Load(object sender, EventArgs e)
        {
            Size = new Size(800, 360);
            listar();
            cargarCanales();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void resetearCampos()
        {
            cbxCanal.SelectedIndex = -1;
            txtTitulo.Clear();
            mtbHoraInicio.Clear();
            mtbHoraFin.Clear();
            txtDiaSemana.Clear();
            txtConductorPrincipal.Clear();
            resetearErrores();
        }
        private void resetearErrores()
        {
            erpCanal.Clear();
            erpTitulo.Clear();
            erpHoraInicio.Clear();
            erpHoraFin.Clear();
            erpDiaSemana.Clear();
            erpConductorPrincipal.Clear();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(800, 520);
            pnlAcciones.Enabled = false;
            resetearCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size(800, 520);
            pnlAcciones.Enabled = false;
            resetearErrores();

            try
            {
                int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
                var horarioPrograma = HorarioProgramaCln.obtenetUno(id);
                cbxCanal.SelectedValue = horarioPrograma.idCanal;
                txtTitulo.Text = horarioPrograma.titulo;
                mtbHoraInicio.Text = horarioPrograma.horaInicio?.ToString(@"hh\:mm") ?? "";
                mtbHoraFin.Text = horarioPrograma.horaFin?.ToString(@"hh\:mm") ?? "";
                txtDiaSemana.Text = horarioPrograma.diaSemana;
                txtConductorPrincipal.Text = horarioPrograma.conductorPrincipal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "::: Error - 2º Parcial :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(800, 360);
            pnlAcciones.Enabled = true;
        }

        private bool validarCampos()
        {
            bool esValido = true;
            resetearErrores();

            if (cbxCanal.SelectedIndex == -1)
            {
                erpCanal.SetError(cbxCanal, "El Canal es Obligatorio");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                erpTitulo.SetError(txtTitulo, "El Título es Obligatorio");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(mtbHoraInicio.Text) || mtbHoraInicio.Text.Contains("_"))
            {
                erpHoraInicio.SetError(mtbHoraInicio, "La hora de inicio es Obligatoria");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(mtbHoraFin.Text) || mtbHoraFin.Text.Contains("_"))
            {
                erpHoraFin.SetError(mtbHoraFin, "La hora de fin es Obligatoria");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaSemana.Text))
            {
                erpDiaSemana.SetError(txtDiaSemana, "El día de la semana es Obligatoria");
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(txtConductorPrincipal.Text))
            {
                erpConductorPrincipal.SetError(txtConductorPrincipal, "El Conductor Principal es Obligatorio");
                esValido = false;
            }

            return esValido;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                TimeSpan horaInicio = TimeSpan.Parse(mtbHoraInicio.Text);
                TimeSpan horaFin = TimeSpan.Parse(mtbHoraFin.Text);

                if (horaInicio >= horaFin)
                {
                    erpHoraInicio.SetError(mtbHoraInicio, "La hora de inicio debe ser menor que la hora de fin");
                    return;
                }
                var horarioPrograma = new HorarioPrograma
                {
                    idCanal = (int)cbxCanal.SelectedValue,
                    titulo = txtTitulo.Text.Trim(),
                    horaInicio = horaInicio,
                    horaFin = horaFin,
                    diaSemana = txtDiaSemana.Text.Trim(),
                    conductorPrincipal = txtConductorPrincipal.Text.Trim(),
                };

                try
                {
                    if (esNuevo)
                    {
                        horarioPrograma.estado = (short)Estado.Activo;
                        HorarioProgramaCln.crear(horarioPrograma);
                    }
                    else
                    {
                        horarioPrograma.id = (int)dgvLista.CurrentRow.Cells["id"].Value;
                        HorarioProgramaCln.actualizar(horarioPrograma);
                    }

                    listar();
                    btnCancelar.PerformClick();
                    MessageBox.Show("Horario guardado correctamente", "::: Mensaje - 2º Parcial",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "::: Error - 2º Parcial :::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            string titulo = dgvLista.CurrentRow.Cells["titulo"].Value.ToString();
            string horaInicio = dgvLista.CurrentRow.Cells["horaInicio"].Value.ToString();
            string dia = dgvLista.CurrentRow.Cells["diaSemana"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja el horario '{titulo}' del {dia} a las {horaInicio}?",
                "::: Confirmación - 2º Parcial :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                HorarioProgramaCln.eliminar(id);
                listar();
                MessageBox.Show("Horario dado de baja correctamente", "::: Mensaje - 2º Parcial :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
