//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaymentsExam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public System.DateTime Date { get; set; }
        public string Name { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
    }
}