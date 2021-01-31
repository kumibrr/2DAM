using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    class Empleado
    {
        public int id;
        public string name;
        public string appPaterno;
        public string appMaterno;
        public string fechaContrato;
        public Double sueldo;
        public int iDTipoUsuario;
        public int idTipoContrato;
        public int idSexo;
        public int bHabilitado;
        public int bTieneUsuario;
        public string tipoUsuario;

        public Empleado(int id, string name, string appPaterno, string appMaterno, string fechaContrato, double sueldo, int iDTipoUsuario, int idTipoContrato, int idSexo, int bHabilitado, int bTieneUsuario, string tipoUsuario)
        {
            this.id = id;
            this.name = name;
            this.appPaterno = appPaterno;
            this.appMaterno = appMaterno;
            this.fechaContrato = fechaContrato;
            this.sueldo = sueldo;
            this.iDTipoUsuario = iDTipoUsuario;
            this.idTipoContrato = idTipoContrato;
            this.idSexo = idSexo;
            this.bHabilitado = bHabilitado;
            this.bTieneUsuario = bTieneUsuario;
            this.tipoUsuario = tipoUsuario;
        }
    }
}
