//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCkursach.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pasports
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Seria { get; set; }
        public Nullable<int> Numer { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Country { get; set; }
        public string Sex { get; set; }
    }
}
