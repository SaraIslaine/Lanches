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

        public IActionResult List()
        {
            //var lanches = _lancheRepository.Lanches;
            //return View( lanches);
            var LanchesListViewModel = new LancheListViewModel();
                LanchesListViewModel.Lanches = _lancheRepository.Lanches;
                LanchesListViewModel.CategoriaAtual = " Categoria Atual";

            return View(LanchesListViewModel);
                }
    }
    }

