using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectE.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int? NumberRemKart {  get; set; }        
        public decimal InvoiceToClient {  get; set; }//счет клиенту
        public decimal PriceOfmaterials {  get; set; }//цена материалов
        public int CountBaraban {  get; set; }//количество фотобарабанов
        public int TotalCartridges {  get; set; }//всего картриджей
        public string? Profit {  get; set; }//прибыль с клиента
        public string? Created { get; set; }= DateTime.Now.ToString("dd.MM.yyyy");
        public int KontragentId { get; set; }
        public virtual Kontragent Kontragent { get; set; }
        public int UserId {  get; set; }
        public virtual User User { get; set; }
        public Order() { }
    }
}
