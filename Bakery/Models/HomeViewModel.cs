using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }
        public Product Featured { 
            get { 
                return Products[new Random().Next(Products.Count)]; 
            } 
        }
    }
}