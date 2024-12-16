
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectE.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string? Login {  get; set; }
        public byte[] ?ImageData { get; set; }
        public string? Name { get; set; }
        public string? Surname {  get; set; }
        public string ? Patronymic {  get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Telephone { get; set; }
        public double ?Percent { get; set; } //процент за работу
        public double ?Tax { get; set; }//Подоходный налог
        public double? Salary { get; set; }//оклад
        public int RoleId { get; set; }
        public bool Status { get; set;} = false;
        public virtual Role Role { get; set; }
        public virtual ObservableCollectionListSource<Order> Orders { get; set; } = new();
        public User() { }

    }
}
