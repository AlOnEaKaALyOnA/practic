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
    
    public partial class Dolshnost
    {
        public int ID_Dolshost { get; set; }
        public Nullable<int> ID_Sotrydnik { get; set; }
        public string NazvanieDolshosti { get; set; }
        public Nullable<decimal> Zarplata { get; set; }
    
        public virtual Sotrydnik Sotrydnik { get; set; }
    }
}
