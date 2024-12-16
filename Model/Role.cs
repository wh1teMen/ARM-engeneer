using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectE.Model
{
    public class Role
    {
        public int RoleId { get; set; }
        public string? Name { get; set; }
        public virtual ObservableCollectionListSource<User> Users { get; set; } = new();
        public Role() { }
    }
}
