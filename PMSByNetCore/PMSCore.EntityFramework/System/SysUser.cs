using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace PMSCore.EntityFramework
{
    [Table("blogs")]
    public class SysUser:EntityBase
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string LoginName { get; set; }

        public string Pwd { get; set; }


    }
}
