using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing.Tree;

namespace API.DTO
{
    public class BasketItemDto
    {
        public int productId { get; set; }
        public string Name {get; set;}
        public long Price { get; set; }
        public string PictureUrl { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Quanitiy {get; set;}
    }
}