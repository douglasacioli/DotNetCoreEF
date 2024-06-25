using System.Collections.Generic;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        private IList<Post> lista;
        public PostController()
        {
            this.lista = new List<Post>
            {
                new Post() {Titulo = "Harry Potter 1", Resumo="Pedra Filosofal", Categoria="Filme, Livro"},
                new Post() {Titulo = "Cassino Royale", Resumo="007", Categoria="Filme"},
                new Post() {Titulo = "Monge e o Executivo", Resumo="Romance sobre liderança", Categoria="livro"},
                new Post() {Titulo = "New York, New York", Resumo="Sucesso de Frank Sinatra", Categoria="Música"},
            };

        }
        public IActionResult Index()
        {
            var listaDePosts = new List<Post>()
            {
                new Post() {Titulo = "Harry Potter 1", Resumo="Pedra Filosofal", Categoria="Filme, Livro"},
                new Post() {Titulo = "Cassino Royale", Resumo="007", Categoria="Filme"},
                new Post() {Titulo = "Monge e o Executivo", Resumo="Romance sobre liderança", Categoria="livro"},
                new Post() {Titulo = "New York, New York", Resumo="Sucesso de Frank Sinatra", Categoria="Música"},
            };

            // ViewBag.Posts = listaDePosts;
            return View(listaDePosts);
        }

        public IActionResult Novo()
        {
            return View();
        }

        public IActionResult Adiciona(Post post)
        {
            lista.Add(post);
            return View("Index", lista);
        }
    }
}