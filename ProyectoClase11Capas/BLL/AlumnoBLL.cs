using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
   public class AlumnoBLL
    {

        public bool InscribirAlumno(Alumno alumno, int idmateria) {
            var resultadopago = VerificarPagoCuota(alumno.Dni);
            var resultadocorrelativa = VerificarMateriaCorrelativa(idmateria);

            if (resultadopago && resultadocorrelativa)
            {
                var alumnoDAL = new AlumnoDAL();
                alumnoDAL.Inscribir(alumno);
            }
            return true;
        }

        private bool VerificarPagoCuota(int DNI) {
            //verifique el dni en base
            var cuotasDAL = new CuotasDAL();
            cuotasDAL.Verificar(DNI);
            return true;
        }
        private bool VerificarMateriaCorrelativa(int materia) { 
            //
        }

    }
}
