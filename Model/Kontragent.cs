using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectE.Model
{
    public class Kontragent
    {
        public int Id {  get; set; }
        public string ?Title {  get; set; }
        public string? Telephone {  get; set; }
        public string ?Email { get; set; }  
        public string? Adress {  get; set; }
        public string? ContactUserName {  get; set; }    
        public string? Discription {  get; set; }
        public virtual ObservableCollectionListSource<Order> Orders { get; set; } = new();
        public Kontragent() { }

    }
}
