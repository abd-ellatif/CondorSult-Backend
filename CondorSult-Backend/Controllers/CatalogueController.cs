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
using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json.Linq;

namespace CondorSult_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogueController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;

        public CatalogueController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        

        // GET: api/Categories
        [HttpGet("Articles")]
        public async Task<ActionResult<IEnumerable<Article>>> GetAllArticles()
        {
          if (_repositoryManager.Article == null)
          {
              return BadRequest(ModelState);
          }

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            IEnumerable<Article> articles = _repositoryManager.Article.GetAllArticles();

            var filteredArticles = articles.Select(a => new Article
            {
                ArticleId = a.ArticleId,
                Nom = a.Nom,
                Description = a.Description,
                Categorie = a.Categorie,
                Variantes = a.Variantes,
                Images = a.Images,
                Commentaires = a.Commentaires.Select(c => new Commentaire
                {
                    CommentaireID = c.CommentaireID,
                    Contenu = c.Contenu,
                    Utilisateur = new Utilisateur
                    {
                        Id = c.Utilisateur.Id,
                        UserName = c.Utilisateur.UserName
                    }
                }).ToList()

            });

            string serializedArticles = JsonSerializer.Serialize(articles, options);
            
            return Content(serializedArticles, "application/json");
        }


        [HttpGet("Categories")]
        public async Task<ActionResult<IEnumerable<Article>>> GetAllCategories()
        {
            if (_repositoryManager.Categorie == null)
            {
                return BadRequest(ModelState);
            }

            return Ok(_repositoryManager.Categorie.GetAllCategories());
        }

        [HttpPost("AjouterArticle")]
        [Authorize(Roles="Admin")]
        public async Task<ActionResult> AddArticle(DTOs.CompositeArticleDto compositeArticleDto)
        {
            if (compositeArticleDto == null)
            {
                return BadRequest("Article body missing");
            }
                
            var articleDto = compositeArticleDto.Article;
            var imageDtos = compositeArticleDto.Images;
            var varianteDtos = compositeArticleDto.Variantes;

            var article = new Article 
            {
                Nom = articleDto.Nom,
                Description = articleDto.Description,
                Marque = articleDto.Marque,
                Visible = articleDto.Visible,
                CategorieID = articleDto.CategorieID
            };
            
            try
            {
        
                _repositoryManager.Article.AddArticle(article);
                _repositoryManager.SaveChanges();

                IEnumerable<Image> images = imageDtos.Select(imageDto => new Image
                {
                    Url = imageDto.Url,
                    ArticleID = article.ArticleId
                }).ToList();

                IEnumerable<Variante> variantes = varianteDtos.Select(varianteDto => new Variante
                {
                    Nom = varianteDto.Nom,
                    Couleur = varianteDto.Couleur,
                    Reference = varianteDto.Reference,
                    Visible = varianteDto.Visible,
                    Prix = varianteDto.Prix,
                    ArticleID = article.ArticleId
                }).ToList();

                _repositoryManager.Image.AddImagesRange(images);
                _repositoryManager.Variante.AddVariantesRange(variantes);

                _repositoryManager.SaveChanges();

                return Ok("Article added");
            }
            catch (Exception exception)
            {
                // explain the error later
                return Problem("Error"+exception.Message);
            }
            
        }

        [HttpPost("AjouterCommentaire")]
        [Authorize(Roles ="Utilisateur")]
        public async Task<IActionResult> AddComment(DTOs.CommentaireDto commentaireDto)
        {
            var commentaire = new Commentaire
            {
                Contenu = commentaireDto.Contenu,
                UserID = commentaireDto.UserID,
                ArticleID = commentaireDto.ArticleID
            };
            try
            {
                _repositoryManager.Commentaire.AddCommentaire(commentaire);
                _repositoryManager.SaveChanges();
                return  Ok(commentaire.ToString());
            }catch(Exception ex)
            {
                return Problem("Error happened "+ex.Message);
            }
            
        }

        [HttpGet("PointsVente")]
        public async Task<ActionResult<IEnumerable<PointVente>>> GetAllPointsVente()
        {
            if (_repositoryManager.PointVente == null)
            {
                return BadRequest(ModelState);
            }
            return Ok(_repositoryManager.PointVente.GetAllPointsVente());
        }

    }
}
