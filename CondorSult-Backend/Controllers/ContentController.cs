using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CondorSult_Backend.Data;
using CondorSult_Backend.Models;
using CondorSult_Backend.Repositories;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Authorization;

namespace CondorSult_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;

        public ContentController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        // GET: api/Content
        [HttpGet("GetAllBlogs")]
        public async Task<ActionResult<IEnumerable<Blog>>> GetBlog()
        {
          if (_repositoryManager.Blog == null)
          {
              return NotFound();
          }
            return  Ok(_repositoryManager.Blog.GetAllBlogs());
        }

        
        
        // POST: api/Content
        [HttpPost("AddBlog")]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult<Blog>> PostBlog(Blog blog)
        {
          if (_repositoryManager.Blog == null)
          {
              return Problem(ModelState.ToString());
          }
            _repositoryManager.Blog.AddBlog(blog);
            _repositoryManager.SaveChanges();

            return CreatedAtAction("GetBlog", new { id = blog.BlogId }, blog);
        }


        // DELETE: api/Content/5
        [HttpDelete("DeleteBlog/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            if (_repositoryManager.Blog == null)
            {
                return NotFound();
            }
            
            _repositoryManager.Blog.RemoveBlog(id);
            _repositoryManager.SaveChanges();

            return NoContent();
        }
    }
}
