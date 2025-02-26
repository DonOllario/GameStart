﻿using GameStart.Core.Entities;

namespace GameStart.Endpoints.Products
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockBalance { get; set; }
    }
}
