using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;

namespace CIDimport
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("== CID-10 CAPITULOS ==");
            var capitulos = new Repositorio.Repositorio().ListarCapitulos().ToList();
            if (capitulos.Any())
            {
                foreach (var capitulo in capitulos)
                    Console.WriteLine(capitulo.DescricaoAbreviada);    
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("== CID-10 GRUPOS ==");
            var grupos = new Repositorio.Repositorio().ListarGrupos().ToList();
            if (grupos.Any())
            {
                foreach (var grupo in grupos)
                    Console.WriteLine(grupo.DescricaoAbreviada);
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("== CID-10 CATEGORIAS ==");
            var categorias = new Repositorio.Repositorio().ListarCategorias().ToList();
            if (categorias.Any())
            {
                foreach (var categoria in categorias)
                    Console.WriteLine(categoria.DescricaoAbreviada);
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("== CID-10 SUBCATEGORIAS ==");
            var subcategorias = new Repositorio.Repositorio().ListarSubCategorias().ToList();
            if (subcategorias.Any())
            {
                foreach (var subcategoria in subcategorias)
                    Console.WriteLine(subcategoria.DescricaoAbreviada);
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("== CID-0 GRUPOS ==");
            var gruposcid0 = new Repositorio.Repositorio().ListarGruposCid0().ToList();
            if (gruposcid0.Any())
            {
                foreach (var grupoCid0 in gruposcid0)
                    Console.WriteLine(grupoCid0.Descricao);
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("== CID-0 CATEGORIAS ==");
            var categoriasCid0 = new Repositorio.Repositorio().ListarCateogiasCid0().ToList();
            if (categoriasCid0.Any())
            {
                foreach (var categoriaCid0 in categoriasCid0)
                    Console.WriteLine(categoriaCid0.Descricao);
            }
            Console.ReadKey();
        }
    }
}
