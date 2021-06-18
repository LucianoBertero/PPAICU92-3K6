//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImplementacionCU92.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exposicion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exposicion()
        {
            this.DetalleExposicion = new HashSet<DetalleExposicion>();
            this.PublicoDestino = new HashSet<PublicoDestino>();
            this.ReservaVisita = new HashSet<ReservaVisita>();
        }
    
        public int id_exposicion { get; set; }
        public Nullable<System.DateTime> fechaFin { get; set; }
        public Nullable<System.DateTime> fechaFinReplanificada { get; set; }
        public Nullable<System.DateTime> fechaInicio { get; set; }
        public Nullable<System.DateTime> fechaInicioReplanificada { get; set; }
        public Nullable<System.TimeSpan> horaApertura { get; set; }
        public Nullable<System.TimeSpan> horaCierre { get; set; }
        public string nombre { get; set; }
        public Nullable<int> id_sede { get; set; }
        public Nullable<int> id_tipoExposicion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleExposicion> DetalleExposicion { get; set; }
        public virtual Sede Sede { get; set; }
        public virtual TipoExposicion TipoExposicion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PublicoDestino> PublicoDestino { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservaVisita> ReservaVisita { get; set; }
    }
}