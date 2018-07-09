using System;
using System.Collections.Generic;
using System.Text;

namespace PMSCore.EntityFramework
{
    public class EntityBase
    {
        public Guid Createby { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
