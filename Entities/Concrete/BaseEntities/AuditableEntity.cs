using Entities.Abstract;
using System;

namespace Entities.Concrete.BaseEntities
{
    public class AuditableEntity : BaseEntity, ICreatedEntity, IUpdatedEntity
    {
        int ICreatedEntity.CreatedUserId { get; set; }
        DateTime ICreatedEntity.CreatedTime { get; set; }
        public int? UpdatedUserId { get ; set ; }
        public DateTime? UpdatedTime { get; set; }
       
    }
}
