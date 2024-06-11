//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemontRequestApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FixRequest
    {
        public long Id { get; set; }
        public System.DateTime StartDate { get; set; }
        public long TechTypeId { get; set; }
        public string ModelName { get; set; }
        public string ProblemDescription { get; set; }
        public long RequestStatusId { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public string RepairParts { get; set; }
        public Nullable<long> MasterId { get; set; }
        public long ClientId { get; set; }
    
        public virtual RequestStatus RequestStatus { get; set; }
        public virtual TechTypeId TechTypeId1 { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}