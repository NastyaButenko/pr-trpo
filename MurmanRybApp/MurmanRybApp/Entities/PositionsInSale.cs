//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MurmanRybApp.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PositionsInSale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PositionsInSale()
        {
            this.Store = new HashSet<Store>();
        }
    
        public int Product { get; set; }
        public int SaleId { get; set; }
        public int Count { get; set; }
    
        public virtual Sale Sale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store> Store { get; set; }
    }
}
