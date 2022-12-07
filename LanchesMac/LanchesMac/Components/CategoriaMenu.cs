using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Components
{
    public class CategoriaMenu: ViewComponent
    {
        private readonly ICategoriaRepository _categoriaReository;
      public CategoriaMenu(ICategoriaRepository categoriaReository)
        {
            _categoriaReository = categoriaReository;
        }
        public IViewComponentResult Invoke()
        {

            var categorias = _categoriaReository.categorias.OrderBy(c => c.categoriaName);
            return View(categorias);
        }

    }
}
