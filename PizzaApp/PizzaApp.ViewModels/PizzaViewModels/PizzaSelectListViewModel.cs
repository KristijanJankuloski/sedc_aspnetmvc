using PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ViewModels.PizzaViewModels
{
    public class PizzaSelectListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSizeEnum PizzaSize { get; set; }
    }
}
