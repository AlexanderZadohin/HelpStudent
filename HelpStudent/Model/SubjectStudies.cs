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
    
    public partial class SubjectStudies
    {
        public SubjectStudies()
        {
            this.CollegeSubject = new HashSet<CollegeSubject>();
            this.EducationalMaterial = new HashSet<EducationalMaterial>();
            this.SubjectSpecialization = new HashSet<SubjectSpecialization>();
            this.SubjectTask = new HashSet<SubjectTask>();
            this.UserApp = new HashSet<UserApp>();
        }
    
        public int id { get; set; }
        public string SubjectName { get; set; }
        public string AssumedProfession { get; set; }
    
        public virtual ICollection<CollegeSubject> CollegeSubject { get; set; }
        public virtual ICollection<EducationalMaterial> EducationalMaterial { get; set; }
        public virtual ICollection<SubjectSpecialization> SubjectSpecialization { get; set; }
        public virtual ICollection<SubjectTask> SubjectTask { get; set; }
        public virtual ICollection<UserApp> UserApp { get; set; }
    }
}
