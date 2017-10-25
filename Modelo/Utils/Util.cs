using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;

namespace PagoAgilFrba.Modelo.Utils
{
    class Util
    {

        // Atributos
        public DateTime appDate = Convert.ToDateTime(ConfigurationManager.AppSettings["AppDate"]);
        public DateTime minTime = new DateTime(1890, 1, 1);

        public static string connectionString = ConfigurationManager.ConnectionStrings["dataBase"].ConnectionString;

        // Metodo para borrar contenido de inputs
        public void clearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    clearTextBoxes(c);
                }

                if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = Convert.ToDateTime(ConfigurationManager.AppSettings["AppDate"]);
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).ResetText();
                }

                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }

        // Metodo para validar fecha
        public Boolean fechaValida(DateTime fecha)
        {
            return fecha.Date > minTime.Date && fecha.Date <= appDate.Date;
        }

        // Metodo para mostrar formatos invalidos
        public void catchearErrorFormato(Exception ex, ToolTip toolTip, TextBox textBox)
        {
            if (ex is FormatException || ex is OverflowException)
            {
                toolTip.Show("Formato inválido.", textBox, 1500);
                textBox.Clear();
            }
        }

        // Metodo para iniciar grillas
        public void iniciarGrids(DataGridView resultadosGrid)
        {
            resultadosGrid.BackgroundColor = Color.LightGray;
            resultadosGrid.BorderStyle = BorderStyle.Fixed3D;
            resultadosGrid.AllowUserToAddRows = false;
            resultadosGrid.AllowUserToDeleteRows = false;
            resultadosGrid.AllowUserToOrderColumns = true;
            resultadosGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            resultadosGrid.DefaultCellStyle.SelectionBackColor = Color.MediumTurquoise;
            resultadosGrid.RowsDefaultCellStyle.BackColor = Color.White;

            resultadosGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            resultadosGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.LightGray;
        }

    }
}
