﻿namespace EcommerceWebSite.Domain.DTOs
{
    public class GetAllProductDTO
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int SubCategoryId { get; set; }
    }
}
