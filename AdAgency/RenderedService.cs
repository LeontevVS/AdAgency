//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdAgency
{
    using System;
    using System.Collections.Generic;
    
    public partial class RenderedService
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Service Service { get; set; }
    }
}
