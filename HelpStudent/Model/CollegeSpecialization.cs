//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelpStudent.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CollegeSpecialization
    {
        public int id { get; set; }
        public Nullable<int> idCollege { get; set; }
        public Nullable<int> idSpecialization { get; set; }
    
        public virtual College College { get; set; }
        public virtual Specialization Specialization { get; set; }
    }
}
