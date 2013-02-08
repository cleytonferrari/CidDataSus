using System.Collections.Generic;

namespace Repositorio
{
    public class Repositorio
    {
        public IEnumerable<ViewModelCapitulo> ListarCapitulos()
        {
            var recurso = Properties.Resources.CID_10_CAPITULOS;
            return new LerCsv<ViewModelCapitulo>().Ler(recurso);
        }

        public IEnumerable<ViewModelGrupo> ListarGrupos()
        {
            var recurso = Properties.Resources.CID_10_GRUPOS;
            return new LerCsv<ViewModelGrupo>().Ler(recurso);
        }

        public IEnumerable<ViewModelCategoria> ListarCategorias()
        {
            var recurso = Properties.Resources.CID_10_CATEGORIAS;
            return new LerCsv<ViewModelCategoria>().Ler(recurso);
        }

        public IEnumerable<ViewModelSubCategoria> ListarSubCategorias()
        {
            var recurso = Properties.Resources.CID_10_SUBCATEGORIAS;
            return new LerCsv<ViewModelSubCategoria>().Ler(recurso);
        }

        public IEnumerable<ViewModelGrupoCid0> ListarGruposCid0()
        {
            var recurso = Properties.Resources.CID_O_GRUPOS;
            return new LerCsv<ViewModelGrupoCid0>().Ler(recurso);
        }

        public IEnumerable<ViewModelCategoriaCid0> ListarCateogiasCid0()
        {
            var recurso = Properties.Resources.CID_O_CATEGORIAS;
            return new LerCsv<ViewModelCategoriaCid0>().Ler(recurso);
        }
    }
}