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
    
    public partial class CollegeSubject
    {
        public int id { get; set; }
        public int idCollege { get; set; }
        public int idSubject { get; set; }
        public Nullable<int> idProfession { get; set; }
    
        public virtual AssumedProfession AssumedProfession { get; set; }
        public virtual College College { get; set; }
        public virtual SubjectStudies SubjectStudies { get; set; }
    }
}
