using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller

    {
        private readonly ILanchesRepository _lancheRepository;

        public LancheController(ILanchesRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }



        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if(string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                if( string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches
                        .Where(l=> l.Categoria.categoriaName.Equals("Normal"))
                        .OrderBy(l => l.Nome);
                        
                 }
                else
                {
                    lanches = _lancheRepository.Lanches
                        .Where(l =>l.Categoria.categoriaName.Equals("Natural"))
                        .OrderBy(l => l.Nome);
                        }
                categoriaAtual = categoria;
            }
            var lanchesListViewModel = new LancheListViewModel

            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };
            return View(lanchesListViewModel);
       }
        public IActionResult Details(int lancheId)
        {
            var lanche = _lancheRepository.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
          return View(lanche);
        }
    }
    }

