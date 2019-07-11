using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PredictorPicoPlaca
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                divError.Visible = false;
                divRespuesta.Visible = false;
                //Obteniendo la placa
                string[] placa = txtPlaca.Text.Split('-');
                int number = int.Parse(placa[1]);
                int last = Convert.ToInt32(number.ToString()
                            .AsEnumerable()
                            .Last()
                            .ToString());
                DateTime fecha = DateTime.Parse(txtFecha.Text);
                string[] hora = txtHora.Text.Split(':');
                int hour = int.Parse(hora[0]);
                int min = int.Parse(hora[1]);
                if (puedeCircular(last, fecha, hour, min))
                    divRespuesta.InnerText = "El vehiculo puede circular libremente ✓✓";
                else
                    divRespuesta.InnerText = "El vehiculo puede NO circular ØØ";
                divRespuesta.Visible = true;
            }
            catch (Exception)
            {
                divError.Visible = true;
            }
        }

        private bool puedeCircular(int digito, DateTime fecha, int hour, int min)
        {
            if ((((hour >= 7 && min >= 00) && (hour <= 9 && min <= 30)) || ((hour >= 16 && min >= 00) && (hour <= 19 && min <= 30))) || fecha.DayOfWeek != DayOfWeek.Saturday || fecha.DayOfWeek != DayOfWeek.Sunday)
            {
                if ((digito == 1 || digito == 2) && fecha.DayOfWeek == DayOfWeek.Monday)
                    return false;
                else if ((digito == 3 || digito == 4) && fecha.DayOfWeek == DayOfWeek.Tuesday)
                    return false;
                else if ((digito == 5 || digito == 6) && fecha.DayOfWeek == DayOfWeek.Wednesday)
                    return false;
                else if ((digito == 7 || digito == 8) && fecha.DayOfWeek == DayOfWeek.Thursday)
                    return false;
                else if ((digito == 9 || digito == 0) && fecha.DayOfWeek == DayOfWeek.Friday)
                    return false;
                else
                    return true;
            }
            else
                return true;
        }
    }
}