using CadParcial2JFAF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnParcial2JFAF
{
    public class HorarioProgramaCln
    {
        public static int crear(HorarioPrograma horarioPrograma)
        {
            using (var context = new Parcial2JFAFEntities())
            {
                var existe = context.HorarioPrograma
                    .Where(x => x.idCanal == horarioPrograma.idCanal &&
                    x.titulo == horarioPrograma.titulo &&
                    x.diaSemana == horarioPrograma.diaSemana &&
                    x.horaInicio == horarioPrograma.horaInicio &&
                    x.clasificacion == horarioPrograma.clasificacion &&
                    x.estado == 1).FirstOrDefault();
                if (existe != null) throw new Exception($"Ya existe un Programa con el título '{horarioPrograma.titulo}' en ese canal, día y hora.");
                context.HorarioPrograma.Add(horarioPrograma);
                context.SaveChanges();
                return horarioPrograma.id;
            }
        }
        public static int actualizar(HorarioPrograma horarioPrograma)
        {
            using (var context = new Parcial2JFAFEntities())
            {
                var existe = context.HorarioPrograma.Find(horarioPrograma.id);
                if (existe == null) throw new Exception($"El programa con id {horarioPrograma.id} no existe");

                existe.idCanal = horarioPrograma.idCanal;
                existe.titulo = horarioPrograma.titulo;
                existe.horaInicio = horarioPrograma.horaInicio;
                existe.horaFin = horarioPrograma.horaFin;
                existe.diaSemana = horarioPrograma.diaSemana;
                existe.conductorPrincipal = horarioPrograma.conductorPrincipal;
                existe.clasificacion = horarioPrograma.clasificacion;

                return context.SaveChanges();
            }
        }
        public static int eliminar(int id)
        {
            using (var context = new Parcial2JFAFEntities())
            {
                var existe = context.HorarioPrograma.Find(id);
                if (existe == null) throw new Exception($"El programa con id {id} no existe");

                existe.estado = (short)Estado.Eliminado;
                return context.SaveChanges();
            }
        }

        public static HorarioPrograma obtenetUno(int id)
        {
            using (var context = new Parcial2JFAFEntities())
            {
                var horarioPrograma = context.HorarioPrograma.Find(id);
                if (horarioPrograma == null) throw new Exception($"El programa con id {id} no existe");
                return horarioPrograma;
            }
        }
        public static List<HorarioPrograma> listar()
        {
            using (var context = new Parcial2JFAFEntities())
            {
                return context.HorarioPrograma.Where(x => x.estado == (short)Estado.Activo).OrderBy(x => x.titulo).ToList();
            }
        }
        public static List<paHorarioProgramaListar_Result> listarPa(string parametro)
        {
            using (var context = new Parcial2JFAFEntities())
            {
                return context.paHorarioProgramaListar(parametro.Trim()).ToList();
            }
        }
    }
}
