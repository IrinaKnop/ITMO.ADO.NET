//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace task03
{
    using System;
    using System.Collections.Generic;
    
    public partial class BusinessEntityAddress
    {
        public int BusinessEntityID { get; set; }
        public int AddressID { get; set; }
        public int AddressTypeID { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
    }
}
