//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CITA
    {
        public int id { get; set; }
        public long idPaciente { get; set; }
        public long idDoctor { get; set; }
        public System.DateTime fecha { get; set; }
        public string motivoCita { get; set; }
        public float costo { get; set; }
    
        public virtual DOCTOR DOCTOR { get; set; }
        public virtual PACIENTE PACIENTE { get; set; }
    }
}
