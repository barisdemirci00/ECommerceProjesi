using System;

namespace Entities.Abstract
{
    public interface IUpdatedEntity
    {
        int? UpdatedUserId { get; set; }
        DateTime? UpdatedTime { get; set; }
    }
}
