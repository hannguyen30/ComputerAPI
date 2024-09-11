﻿namespace ComputerAPI.Models.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? ImageUrl { get; set; }
        public Guid BrandId { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}

