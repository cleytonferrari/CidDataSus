using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var repositorio = new Repositorio.Repositorio();
            var capitulos = repositorio.ListarCapitulos().ToList();
            return View(capitulos);
        }

        public ActionResult Capitulo(string id)
        {
            var repositorio = new Repositorio.Repositorio();
            var capitulo = repositorio.ListarCapitulos().FirstOrDefault(x => x.NumeroCapitulo == id);
            ViewBag.capitulo = capitulo;
            var grupos = repositorio.ListarGrupos().Where(x =>
                x.CategoriaInicialCodigo >= capitulo.CategoriaInicialCodigo &&
                x.CategoriaFinalCodigo <= capitulo.CategoriaFinalCodigo
                ).ToList();
            return View(grupos);
        }

        public ActionResult Grupo(string categoriaInicial, string categoriaFinal)
        {
            var repositorio = new Repositorio.Repositorio();
            var grupo = repositorio.ListarGrupos().FirstOrDefault(x => x.CategoriaInicial == categoriaInicial && x.CategoriaFinal == categoriaFinal);
            ViewBag.grupo = grupo;
            var capitulo = repositorio.ListarCapitulos().FirstOrDefault(x =>
                    grupo.CategoriaInicialCodigo >= x.CategoriaInicialCodigo &&
                    grupo.CategoriaFinalCodigo <= x.CategoriaFinalCodigo
                    );

            ViewBag.capitulo = capitulo;

            var categorias = repositorio.ListarCategorias().Where(x =>
                x.CodigoDaCategoriaCodigo >= grupo.CategoriaInicialCodigo &&
                x.CodigoDaCategoriaCodigo <= grupo.CategoriaFinalCodigo
                ).ToList();

            return View(categorias);
        }

        public ActionResult Categoria(string codigoDaCategoria)
        {
            var repositorio = new Repositorio.Repositorio();

            var categoria = repositorio.ListarCategorias().FirstOrDefault(x => x.CodigoDaCategoria == codigoDaCategoria);

            var subCategorias = repositorio.ListarSubCategorias().Where(x =>
               x.CodigoDaCategoria == codigoDaCategoria).ToList();

            categoria.ListaDeSubCategorias = subCategorias;

            var grupo = repositorio.ListarGrupos().FirstOrDefault(x => categoria.CodigoDaCategoriaCodigo >= x.CategoriaInicialCodigo && categoria.CodigoDaCategoriaCodigo <= x.CategoriaFinalCodigo);
            ViewBag.grupo = grupo;

            var capitulo = repositorio.ListarCapitulos().FirstOrDefault(x =>
                    grupo.CategoriaInicialCodigo >= x.CategoriaInicialCodigo &&
                    grupo.CategoriaFinalCodigo <= x.CategoriaFinalCodigo
                    );

            ViewBag.capitulo = capitulo;

            return View(categoria);
        }

        public ActionResult Detalhe(string codigo)
        {
            var repositorio = new Repositorio.Repositorio();
            var subcategoria = repositorio.ListarSubCategorias().FirstOrDefault(x => x.CodigoDaSubCategoria == codigo);
            
            return View(subcategoria);
        }

        public ActionResult Busca (string busca)
        {
            var repositorio = new Repositorio.Repositorio();
            var subCategorias = repositorio.ListarSubCategorias().Where(x => x.Descricao.ToLower().Contains(busca.ToLower())).ToList();
            ViewBag.busca = busca;
            return View(subCategorias);
        }
    }
}
