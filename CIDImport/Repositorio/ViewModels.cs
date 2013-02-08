using System;
using System.Collections.Generic;
using CsvHelper.Configuration;

namespace Repositorio
{
    public class ViewModelCapitulo
    {
        //NUMCAP: número do capítulo (em numeração arábica); se igual a zero, indica o capítulo que contém os códigos não oficialmente pertinentes à CID-10;
        [CsvField(Name = "NUMCAP")]
        public string NumeroCapitulo { get; set; }

        //CATINIC: código da primeira categoria do capítulo;
        [CsvField(Name = "CATINIC")]
        public string CategoriaInicial { get; set; }

        [CsvField(Ignore = true)]
        public int CategoriaInicialCodigo
        {
            get { return Ferramentas.TrocaLetraPorNumero(CategoriaInicial); }
        }

        //CATFIM: código da última categoria do capítulo;
        [CsvField(Name = "CATFIM")]
        public string CategoriaFinal { get; set; }

        [CsvField(Ignore = true)]
        public int CategoriaFinalCodigo
        {
            get { return Ferramentas.TrocaLetraPorNumero(CategoriaFinal); }
        }

        //DESCRICAO: descrição (nome) do capítulo; e
        [CsvField(Name = "DESCRICAO")]
        public string Descricao { get; set; }

        //DESCRABREV: descrição (nome) abreviado do capítulo, com até 50 caracteres.
        [CsvField(Name = "DESCRABREV")]
        public string DescricaoAbreviada { get; set; }
    }

    public class ViewModelGrupo
    {
        //CATINIC: código da primeira categoria do grupo;
        [CsvField(Name = "CATINIC")]
        public string CategoriaInicial { get; set; }

        [CsvField(Ignore = true)]
        public int CategoriaInicialCodigo
        {
            get { return Ferramentas.TrocaLetraPorNumero(CategoriaInicial); }
        }

        //CATFIM: código da última categoria do grupo;
        [CsvField(Name = "CATFIM")]
        public string CategoriaFinal { get; set; }

        [CsvField(Ignore = true)]
        public int CategoriaFinalCodigo
        {
            get { return Ferramentas.TrocaLetraPorNumero(CategoriaFinal); }
        }

        //DESCRICAO: descrição (nome) do grupo; e
        [CsvField(Name = "DESCRICAO")]
        public string Descricao { get; set; }

        //DESCRABREV: descrição (nome) abreviado do grupo, com até 50 caracteres.
        [CsvField(Name = "DESCRABREV")]
        public string DescricaoAbreviada { get; set; }
    }

    public class ViewModelCategoria
    {
        //CAT: código da categoria;
        [CsvField(Name = "CAT")]
        public string CodigoDaCategoria { get; set; }

        [CsvField(Ignore = true)]
        public int CodigoDaCategoriaCodigo
        {
            get { return Ferramentas.TrocaLetraPorNumero(CodigoDaCategoria); }
        }

        [CsvField(Ignore = true)]
        public IEnumerable<ViewModelSubCategoria> ListaDeSubCategorias { get; set; }


        //CLASSIF: indica se a situação da categoria em relação à classificação cruz/asterisco:
        //em branco: não tem dupla classificação;
        //+: classificação por etiologia; e
        //*: classificação por manifestação.
        [CsvField(Name = "CLASSIF")]
        public string Classificacao { get; set; }

        //DESCRICAO: descrição (nome) da categoria;
        [CsvField(Name = "DESCRICAO")]
        public string Descricao { get; set; }

        //DESCRABREV: descrição (nome) abreviado da categoria, com até 50 caracteres (inclui o código da categoria);
        [CsvField(Name = "DESCRABREV")]
        public string DescricaoAbreviada { get; set; }

        //REFER: contém, quando a categoria tiver dupla classificação, o código da categoria segundo a outra classificação (nem todos os casos de dupla classificação contém este campo); e
        [CsvField(Name = "REFER")]
        public string Referencia { get; set; }

        //EXCLUIDOS: contém o(s) código(s) de categorias excluídas que agora fazem parte desta categoria.
        [CsvField(Name = "EXCLUIDOS")]
        public string Excluidos { get; set; }
    }

    public class ViewModelSubCategoria
    {
        //SUBCAT: código da subcategoria (sem incluir ponto); para categorias sem subcategorias, o quarto caractere está em branco;
        [CsvField(Name = "SUBCAT")]
        public string CodigoDaSubCategoria { get; set; }

        [CsvField(Ignore = true)]
        public string CodigoDaCategoria
        {
            get { return CodigoDaSubCategoria.Substring(0, 3); }
        }

        [CsvField(Ignore = true)]
        public int CodigoDaCategoriaCodigo
        {
            get { return Ferramentas.TrocaLetraPorNumero(CodigoDaCategoria); }
        }


        //CLASSIF: indica se a situação da subcategoria em relação à classificação cruz/asterisco:
        //em branco: não tem dupla classificação;
        //+: classificação por etiologia; e
        //*: classificação por manifestação.
        [CsvField(Name = "CLASSIF")]
        public string Classificacao { get; set; }

        //RESTRSEXO: indica se a subcategoria só pode ser usada para homens ou mulheres:
        //em branco: pode ser utilizada em qualquer situação;
        //F: só deve ser utilizada para o sexo feminino; e
        //M: só deve ser utilizada para o sexo masculino.
        [CsvField(Name = "RESTRSEXO")]
        public string RestricaoDeSexo { get; set; }

        //CAUSAOBITO: indica se a subcategoria pode causar óbito:
        //em branco: não há restrição; e
        //N: a subcategoria tem pouca probabilidade de causar óbito.
        //Observação: além disto, deve-se atentar para o fato de que as subcategorias da classificação asterisco não devem ser utilizadas na classificação de causas de óbitos, assim como as subcategorias do capítulo XIX e do capítulo XXI.
        [CsvField(Name = "CAUSAOBITO")]
        public string CausaObito { get; set; }

        //DESCRICAO: descrição (nome) da subcategoria;
        [CsvField(Name = "DESCRICAO")]
        public string Descricao { get; set; }

        //DESCRABREV: descrição (nome) abreviado da subcategoria, com até 50 caracteres (inclui o código da subcategoria);
        [CsvField(Name = "DESCRABREV")]
        public string DescricaoAbreviada { get; set; }

        //REFER: contém, quando a subcategoria tiver dupla classificação, o código da subcategoria segundo a outra classificação (nem todos os casos de dupla classificação contém este campo); e
        [CsvField(Name = "REFER")]
        public string Referencia { get; set; }

        //EXCLUIDOS: contém o(s) código(s) de subcategorias excluídas que agora fazem parte desta subcategoria.
        [CsvField(Name = "EXCLUIDOS")]
        public string Excluidos { get; set; }
    }

    public class ViewModelGrupoCid0
    {
        //CATINIC: código da primeira categoria do grupo;
        [CsvField(Name = "CATINIC")]
        public string CategoriaInicial { get; set; }

        //CATFIM: código da última categoria do grupo;
        [CsvField(Name = "CATFIM")]
        public string CategoriaFinal { get; set; }

        //DESCRICAO: descrição (nome) do grupo; e
        [CsvField(Name = "DESCRICAO")]
        public string Descricao { get; set; }

        //REFER: contém, a referência do grupo na classificação do capítulo II da CID-10 (Neoplasias).
        [CsvField(Name = "REFER")]
        public string Referencia { get; set; }
    }

    public class ViewModelCategoriaCid0
    {

        //CAT: código da categoria;
        [CsvField(Name = "CAT")]
        public string CodigoDaCategoria { get; set; }

        //DESCRICAO: descrição (nome) da categoria; e
        [CsvField(Name = "DESCRICAO")]
        public string Descricao { get; set; }

        //REFER: contém a referência da categoria na classificação do capítulo II da CID-10 (Neoplasias);
        [CsvField(Name = "REFER")]
        public string Referencia { get; set; }

    }

    public static class Ferramentas
    {
        public static int TrocaLetraPorNumero(string texto)
        {

            string ascii = ((int)texto[0]).ToString();
            string resto = texto.Substring(1, texto.Length-1);
            string valor = ascii + resto;
            return int.Parse(valor);
        }
    }
}