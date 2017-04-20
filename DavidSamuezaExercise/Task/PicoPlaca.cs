using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DavidSamuezaExercise.Task
{
    public class PicoPlaca
    
    {
        [Required(ErrorMessage = "Campo requerido. Ingrese el primer nombre")]
        public String Placa { set; get; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MM/dd/yyyy}")]
        public String Fecha { set; get; }
        public String Hora { set; get; }
     /*   public PicoPlaca(String placa, String fecha, String hora)
        {
            this.Placa = placa;
            this.Fecha = fecha;
            this.Hora = hora;

        }
        */
    }
}