using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class PedidoController : Controller

    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
        {
            _pedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        [HttpGet]
        public IActionResult checkout()
        {
            return View();


            //var itens = _carrinhoCompra.GetCarrinhoCompraItems();
            //_carrinhoCompra.CarrinhoCompraItems = itens;

            //var carrinhoCompraVM = new CarrinhoCompraViewModel
            //{
            //    carrinhoCompra = _carrinhoCompra,
            //    carrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            //};
         
        }
        [HttpPost]
        public IActionResult Checkout(Pedido pedido)
        {
            return View();
        }
    }
}
    

