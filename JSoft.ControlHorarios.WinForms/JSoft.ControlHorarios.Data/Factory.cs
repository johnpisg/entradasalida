using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSoft.ControlHorarios.Data
{
    public class Factory
    {
        /// <summary>
        /// Obtiene un empleado por su código
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public Empleado GetEmpleadoByCode(string code)
        {
            using(ControlHorarioEntities db = new ControlHorarioEntities())
            {
                var emp = (from e in db.Empleado
                           where e.Codigo == code
                           select e).FirstOrDefault();
                return emp;
            }
        }

        /// <summary>
        /// Registra una operación de entrada o salida.
        /// </summary>
        /// <param name="empleadoId"></param>
        /// <param name="fechaHoraRegistro"></param>
        /// <returns></returns>
        public bool RegistrarOperacion(int empleadoId, DateTime fechaHoraRegistro)
        {
            try
            {
                using (ControlHorarioEntities db = new ControlHorarioEntities())
                {
                    Registro reg = new Registro();
                    reg.IdEmpleado = empleadoId;
                    reg.FechaHora = fechaHoraRegistro;
                    reg.Tipo = "E";

                    //Obtener ultimo registro.
                    var lastReg = (from r in db.Registro
                                   where r.FechaHora >= fechaHoraRegistro.Date
                                    && r.IdEmpleado == empleadoId
                                   orderby r.FechaHora descending
                                   select r).FirstOrDefault();

                    if(lastReg != null)
                    {
                        if (lastReg.Tipo == "E")
                        {
                            reg.Tipo = "S";
                        }
                        else if (lastReg.Tipo == "S")
                        {
                            reg.Tipo = "E";
                        }
                    }

                    db.Entry(reg).State = System.Data.Entity.EntityState.Added;
                    db.Registro.Add(reg);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Genera el reporte de entradas y salidas.
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <returns></returns>
        public List<CH_RPT_ENTRADA_SALIDA_POR_EMPLEADO_Result> GenerarReporteEntradaSalida(DateTime fechaDesde, DateTime fechaHasta)
        {
            var lista = new List<CH_RPT_ENTRADA_SALIDA_POR_EMPLEADO_Result>();
            using (ControlHorarioEntities db = new ControlHorarioEntities())
            {
                var result = db.CH_RPT_ENTRADA_SALIDA_POR_EMPLEADO(fechaDesde, fechaHasta);
                lista = result.ToList();
            }
            return lista;
        }
    }
}
