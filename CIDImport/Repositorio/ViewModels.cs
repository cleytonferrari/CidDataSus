using System;
using System.Collections.Generic;
using CsvHelper.Configuration;

namespace Repositorio
{
    public class ViewModelCapitulo
    {
        //NUMCAP: n�mero do cap�tulo (em numera��o ar�bica); se igual a zero, indica o cap�tulo que cont�m os c�digos n�o oficialmente pertinentes � CID-10;
        [CsvField(Name = "NUMCAP")]
        public string NumeroCapitulo { get; set; }

        //CATINIC: c�digo da primeira categoria do cap�tulo;
        [CsvField(Name = "CATINIC")]
        public string CategoriaInicial { get; set; }

        [CsvField(Ignore = true)]
        public int CategoriaInicialCodigo
        {
            get { return Ferramentas.TrocaLetraPorNumero(CategoriaInicial); }
        }

        //CATFIM: c�digo da �ltima categoria do cap�tulo;
        [CsvField(Name = "CATFIM")]
        public string CategoriaFinal { get; set; }

        [CsvField(Ignore = true)]
        public int CategoriaFinalCodigo
        {
            get { return Ferramentas.TrocaLetraPorNumero(CategoriaFinal); }
        }

        //DESCRICAO: descri��o (nome) do cap�tulo; e
        [CsvField(Name = "DESCRICAO")]
        public string Descricao { get; set; }

        //DESCRABREV: descri��o (nome) abreviado do cap�tulo, com at� 50 caracteres.
        [CsvField(Name = "DESCRABREV")]
        public string DescricaoAbreviada { get; set; }
    }

    public class ViewModelGrupo
    {
        //CATINIC: c�digo da primeira categoria do grupo;
        [CsvField(Name = "CATINIC")]
        public string CategoriaInicial { get; set; }

        [CsvField(Ignore = true)]
        public int CategoriaInicialCodigo
        {
            get { return Ferramentas.TrocaLetraPorNumero(CategoriaInicial); }
        }

        //CATFIM: c�digo da �ltima categoria do grupo;
        [CsvField(Name = "CATFIM")]
        public string CategoriaFinal { get; set; }

        [CsvField(Ignore = true)]
        public int CategoriaFinalCodigo
        {
            get { return Ferramentas.TrocaLetraPorNumero(CategoriaFinal); }
        }

        //DESCRICAO: descri��o (nome) do grupo; e
        [CsvField(Name = "DESCRICAO")]
        public string Descricao { get; set; }

        //DESCRABREV: descri��o (nome) abreviado do grupo, com at� 50 caracteres.
        [CsvField(Name = "DESCRABREV")]
        public string DescricaoAbreviada { get; set; }
    }

    public class ViewModelCategoria
    {
        //CAT: c�digo da categoria;
        [CsvField(Name = "CAT")]
        public string CodigoDaCategoria { get; set; }

        [CsvField(Ignore = true)]
        public int CodigoDaCategoriaCodigo
        {
            get { return Ferramentas.TrocaLetraPorNumero(CodigoDaCategoria); }
        }

        [CsvField(Ignore = true)]
        public IEnumerable<ViewModelSubCategoria> ListaDeSubCategorias { get; set; }


        //CLASSIF: indica se a situa��o da categoria em rela��o � classifica��o cruz/asterisco:
        //em branco: n�o tem dupla classifica��o;
        //+: classifica��o por etiologia; e
        //*: classifica��o por manifesta��o.
        [CsvField(Name = "CLASSIF")]
        public string Classificacao { get; set; }

        //DESCRICAO: descri��o (nome) da categoria;
        [CsvField(Name = "DESCRICAO")]
        public string Descricao { get; set; }

        //DESCRABREV: descri��o (nome) abreviado da categoria, com at� 50 caracteres (inclui o c�digo da categoria);
        [CsvField(Name = "DESCRABREV")]
        public string DescricaoAbreviada { get; set; }

        //REFER: cont�m, quando a categoria tiver dupla classifica��o, o c�digo da categoria segundo a outra classifica��o (nem todos os casos de dupla classifica��o cont�m este campo); e
        [CsvField(Name = "REFER")]
        public string Referencia { get; set; }

        //EXCLUIDOS: cont�m o(s) c�digo(s) de categorias exclu�das que agora fazem parte desta categoria.
        [CsvField(Name = "EXCLUIDOS")]
        public string Excluidos { get; set; }
    }

    public class ViewModelSubCategoria
    {
        //SUBCAT: c�digo da subcategoria (sem incluir ponto); para categorias sem subcategorias, o quarto caractere est� em branco;
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


        //CLASSIF: indica se a situa��o da subcategoria em rela��o � classifica��o cruz/asterisco:
        //em branco: n�o tem dupla classifica��o;
        //+: classifica��o por etiologia; e
        //*: classifica��o por manifesta��o.
        [CsvField(Name = "CLASSIF")]
        public string Classificacao { get; set; }

        //RESTRSEXO: indica se a subcategoria s� pode ser usada para homens ou mulheres:
        //em branco: pode ser utilizada em qualquer situa��o;
        //F: s� deve ser utilizada para o sexo feminino; e
        //M: s� deve ser utilizada para o sexo masculino.
        [CsvField(Name = "RESTRSEXO")]
        public string RestricaoDeSexo { get; set; }

        //CAUSAOBITO: indica se a subcategoria pode causar �bito:
        //em branco: n�o h� restri��o; e
        //N: a subcategoria tem pouca probabilidade de causar �bito.
        //Observa��o: al�m disto, deve-se atentar para o fato de que as subcategorias da classifica��o asterisco n�o devem ser utilizadas na classifica��o de causas de �bitos, assim como as subcategorias do cap�tulo XIX e do cap�tulo XXI.
        [CsvField(Name = "CAUSAOBITO")]
        public string CausaObito { get; set; }

        //DESCRICAO: descri��o (nome) da subcategoria;
        [CsvField(Name = "DESCRICAO")]
        public string Descricao { get; set; }

        //DESCRABREV: descri��o (nome) abreviado da subcategoria, com at� 50 caracteres (inclui o c�digo da subcategoria);
        [CsvField(Name = "DESCRABREV")]
        public string DescricaoAbreviada { get; set; }

        //REFER: cont�m, quando a subcategoria tiver dupla classifica��o, o c�digo da subcategoria segundo a outra classifica��o (nem todos os casos de dupla classifica��o cont�m este campo); e
        [CsvField(Name = "REFER")]
        public string Referencia { get; set; }

        //EXCLUIDOS: cont�m o(s) c�digo(s) de subcategorias exclu�das que agora fazem parte desta subcategoria.
        [CsvField(Name = "EXCLUIDOS")]
        public string Excluidos { get; set; }
    }

    public class ViewModelGrupoCid0
    {
        //CATINIC: c�digo da primeira categoria do grupo;
        [CsvField(Name = "CATINIC")]
        public string CategoriaInicial { get; set; }

        //CATFIM: c�digo da �ltima categoria do grupo;
        [CsvField(Name = "CATFIM")]
        public string CategoriaFinal { get; set; }

        //DESCRICAO: descri��o (nome) do grupo; e
        [CsvField(Name = "DESCRICAO")]
        public string Descricao { get; set; }

        //REFER: cont�m, a refer�ncia do grupo na classifica��o do cap�tulo II da CID-10 (Neoplasias).
        [CsvField(Name = "REFER")]
        public string Referencia { get; set; }
    }

    public class ViewModelCategoriaCid0
    {

        //CAT: c�digo da categoria;
        [CsvField(Name = "CAT")]
        public string CodigoDaCategoria { get; set; }

        //DESCRICAO: descri��o (nome) da categoria; e
        [CsvField(Name = "DESCRICAO")]
        public string Descricao { get; set; }

        //REFER: cont�m a refer�ncia da categoria na classifica��o do cap�tulo II da CID-10 (Neoplasias);
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