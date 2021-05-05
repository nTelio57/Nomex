using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Nomex.Data;
using Nomex.Dtos.Recipe;
using Nomex.Models;

namespace Nomex.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepo _repository;
        private readonly IMapper _mapper;

        public RecipeController(IRecipeRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("by-user-id/{userId}", Name = "GetAllRecipesByUserId")]
        public ActionResult<IEnumerable<RecipeReadDto>> GetAllRecipesByUserId(int userId)
        {
            var recipeItems = _repository.GetAllRecipesByUserId(userId);
            return Ok(_mapper.Map<IEnumerable<RecipeReadDto>>(recipeItems));
        }

        [HttpGet("{id}")]
        public ActionResult<RecipeReadDto> GetRecipeById(int id)
        {
            var recipeItem = _repository.GetRecipeById(id);
            if (recipeItem == null)
                return NotFound();
            return _mapper.Map<RecipeReadDto>(recipeItem);
        }

        [HttpPost]
        public ActionResult<RecipeReadDto> CreateRecipe(RecipeCreateDto recipeCreateDto)
        {
            var recipeModel = _mapper.Map<Recipe>(recipeCreateDto);

            _repository.CreateRecipe(recipeModel);
            _repository.SaveChanges();

            var recipeReadDto = _mapper.Map<RecipeReadDto>(recipeModel);
            return CreatedAtRoute(nameof(GetRecipeById), new {Id = recipeReadDto.Id}, recipeReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateRecipe(int id, RecipeUpdateDto recipeUpdateDto)
        {
            var recipeModelFromRepo = _repository.GetRecipeById(id);
            if (recipeModelFromRepo == null)
                return NotFound();

            _mapper.Map(recipeUpdateDto, recipeModelFromRepo);
            
            _repository.UpdateRecipe(recipeModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteRecipe(int id)
        {
            var recipeFromRepo = _repository.GetRecipeById(id);
            if (recipeFromRepo == null)
                return NotFound();

            _repository.DeleteRecipe(recipeFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpPost("list")]
        public ActionResult AddRecipeList(ICollection<RecipeCreateDto> recipeListDto)
        {
            
            foreach (var recipe in recipeListDto)
            {
                var recipeModel = _mapper.Map<Recipe>(recipe);

                _repository.CreateRecipe(recipeModel);
            }

            _repository.SaveChanges();

            return Ok();
        }
    }
}
