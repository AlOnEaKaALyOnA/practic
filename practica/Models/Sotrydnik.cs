//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practica.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sotrydnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sotrydnik()
        {
            this.Dogovor = new HashSet<Dogovor>();
            this.Dolshnost = new HashSet<Dolshnost>();
        }
    
        public int ID_Sotrydnik { get; set; }
        public string Familiya { get; set; }
        public string Imya { get; set; }
        public string Otchestvo { get; set; }
        public Nullable<System.DateTime> DataRozdeniya { get; set; }
        public string Telefon { get; set; }
        public string PassportnyeDannye { get; set; }
        public Nullable<System.DateTime> DataPrinyatiaNaRaboty { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dogovor> Dogovor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dolshnost> Dolshnost { get; set; }
    }
}
