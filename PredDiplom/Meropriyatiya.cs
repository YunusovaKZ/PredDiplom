//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PredDiplom
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meropriyatiya
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meropriyatiya()
        {
            this.Aktivnosti_Meropriyatiya = new HashSet<Aktivnosti_Meropriyatiya>();
            this.Merop_Guri = new HashSet<Merop_Guri>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Date { get; set; }
        public int Days { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aktivnosti_Meropriyatiya> Aktivnosti_Meropriyatiya { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Merop_Guri> Merop_Guri { get; set; }
    }
}
