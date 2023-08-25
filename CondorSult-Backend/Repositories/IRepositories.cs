﻿using CondorSult_Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CondorSult_Backend.Repositories
{
    public interface IUtilisateurRepository
    {
        
    }

    public interface IArticleRepository
    {
        public IQueryable<Article> GetAllArticles();
        public void AddArticle(Article article);
    }

    public interface IVarianteRepository
    {
        public void AddVariantesRange(IEnumerable<Variante> variantes);

    }

    public interface ICategorieRepository
    {
        public IEnumerable<Categorie> GetAllCategories();
    }

    public interface IImageRepository
    {
        public void AddImagesRange(IEnumerable<Image> images);
    }

    public interface ICommentaireRepository
    {

    }
}
