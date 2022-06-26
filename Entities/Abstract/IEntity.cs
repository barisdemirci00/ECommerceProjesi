using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IEntity
    {
        /// <summary>
        /// veritabanında karşılık gelen tablolardaki alanlar olacak;
        /// </summary>
        int Id { get; set; }


    }
}
