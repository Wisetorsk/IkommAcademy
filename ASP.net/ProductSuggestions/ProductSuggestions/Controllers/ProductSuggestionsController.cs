using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductSuggestions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSuggestionsController : ControllerBase
    {
        public IProductSuggestionsRepository Psro { get; set; }
        public ProductSuggestionsController(IProductSuggestionsRepository psro)
        {
            Psro = psro;
        }

    }

}
