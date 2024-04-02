﻿using CaloriesCounterAPI.Data;
using CaloriesCounterAPI.DTO;
using CaloriesCounterAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaloriesCounterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductControler : ControllerBase
    {

        private readonly CaloriesCounterAPIContext _context;

        public ProductControler(CaloriesCounterAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {

            return await _context.Product.ToListAsync();
        }

        [HttpPost]

        public async Task<ActionResult<Product>> PostNewProduct(CreateProductDTO productDTO)
        {
            var newProduct = new Product
            {
                Protein = productDTO.Protein,
                Fat = productDTO.Fat,
                Carbs = productDTO.Carbs,
                Name = productDTO.Name,
                Kcal = productDTO.Kcal
            };

            _context.Product.Add(newProduct);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}