using JSoft.ControlHorarios.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JSoft.ControlHorarios.WebApp.Models
{
    public class EntradaSalidaModel
    {
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaDesde { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaHasta { get; set; }

        public List<CH_RPT_ENTRADA_SALIDA_POR_EMPLEADO_Result> ReportData { get; set; }
    }
}