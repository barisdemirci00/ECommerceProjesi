using System;

namespace Entities.Abstract
{
    public interface ICreatedEntity
    {
        int CreatedUserId { get; set; } 
        DateTime CreatedTime { get; set; }  

    }
}
