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
    
    public partial class BronirovanieTransporta
    {
        public int ID_BroniTransporta { get; set; }
        public Nullable<int> ID_Klient { get; set; }
        public Nullable<int> ID_Transport { get; set; }
        public Nullable<System.DateTime> DataArendy { get; set; }
    
        public virtual Klient Klient { get; set; }
        public virtual Transport Transport { get; set; }
    }
}
