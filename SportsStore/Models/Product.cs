using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
                                    //Введите наименование товара
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a sescription")]
                                    //Введите описание
        public string Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
                                                    //Введите положительное значение для цены
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please specitfy a category")]
                                 //Укажите категорию
        public string Category { get; set; }
    }
}
