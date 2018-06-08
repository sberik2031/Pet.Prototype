//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pet.Prototype.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Announcements
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Announcements()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public System.Guid Id { get; set; }
        public System.DateTime DateCreate { get; set; }
        public Nullable<System.DateTime> DateUpdate { get; set; }
        public System.Guid SellerId { get; set; }
        public Nullable<System.DateTime> DateBidding { get; set; }
        public decimal StartPrice { get; set; }
        public Nullable<decimal> Margin { get; set; }
        public Nullable<System.DateTime> DeadlineDate { get; set; }
        public string GoodsName { get; set; }
        public string Composition { get; set; }
        public string LotSize { get; set; }
        public Nullable<int> LotCount { get; set; }
        public Nullable<int> TypeDelivery { get; set; }
        public Nullable<System.DateTime> DateDelivery { get; set; }
        public string PaymentType { get; set; }
        public Nullable<int> Status { get; set; }
        public string XmlSign { get; set; }
        public string XmlSign2 { get; set; }
        public int No { get; set; }
    
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}