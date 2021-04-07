using Carrefour_Projeto.Application.Features.Products.Commands.CreateProduct;
using Carrefour_Projeto.Application.Features.Products.Queries.GetAllProducts;
using AutoMapper;
using Carrefour_Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carrefour_Projeto.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();            
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();            
        }
    }
}
