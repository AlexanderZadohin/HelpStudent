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
    
    public partial class UserSubject
    {
        public int id { get; set; }
        public Nullable<int> idSubject { get; set; }
        public Nullable<int> idUser { get; set; }
    
        public virtual SubjectStudies SubjectStudies { get; set; }
        public virtual UserApp UserApp { get; set; }
    }
}
