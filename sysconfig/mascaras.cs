using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysconfig
{
    public class mascaras
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private char tecla;
        private string palavra;
        private Int32 fator = 1;

        /// <summary>
        /// retirando caractere da string
        /// </summary>
        private void retiraCaractere(char carac)
        { 
            string[] campos = palavra.Split(carac);
            palavra = Convert.ToDouble(string.Concat(campos)).ToString();
        }

        /// <summary>
        /// Acrescenta zeros a string
        /// </summary>
        private void acrescentaZeros(int normal, int backspace)
        {
            while ((palavra.Length < normal) || ((palavra.Length < backspace) && (tecla == (char)Keys.Back)))
            {
                palavra = "0" + palavra;
            }
        }

        /// <summary>
        /// Compara se é backspace
        /// </summary>
        private void retornaFator()
        {
            if (tecla == (char)Keys.Back)
                fator = 3;
        }

        /// <summary>
        /// Chama funcao para retirada de caracter e insercao de zeros
        /// </summary>
        public void limpaNumero(char simbolo, int min, int max)
        {  
            retiraCaractere(simbolo);
            acrescentaZeros(min, max);
            retornaFator();
        }

        /// <summary>
        /// Funcao recebe a quantidade de partes do numero, inicio e quantidade de 
        /// caracteres de cada parte dentro da string, caracter e efetua qualquer tipo de mascara.
        /// </summary>
        private void masctipo(Int32 quantidade, string[,] limites)
        {
            string partes = "";
            Int32 contador = 0;
            while (contador < quantidade)
            {
                partes += palavra.Substring(Convert.ToInt32(limites[contador, 0]), Convert.ToInt32(limites[contador, 1])) + limites[contador, 2];
                contador = contador + 1;
            }
            palavra = partes;
        }

        /// <summary>
        /// Metodo recebe uma Tecla
        /// </summary>
        public void recebeTecla(char x)
        {
            tecla = x;
        }

        /// <summary>
        /// Metodo recebe uma palavra
        /// </summary>
        public void recebePalavra(string y)
        {
            palavra = y;
        }

        /// <summary>
        /// Metodo recebe caracter e retorna falso se numero
        /// </summary>
        public bool mascaraNumero(Int32 maximo)
        {
            if ((!char.IsNumber(tecla) || (palavra.Length >= maximo && Convert.ToInt32(palavra.Substring(0, 1)) != 0)) && (tecla != (char)Keys.Back))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Aplica a mascara de CEP
        /// </summary>
        public string mascaraCEP()
        {
            limpaNumero('-', 7, 9);
            string[,] partes = { { "0", "5", "-" }, { "5", Convert.ToString(1 + fator), "" } };
            masctipo(2, partes);
            return palavra;
        }

        /// <summary>
        /// Aplica a mascara de CNPJ
        /// </summary>
        public string mascaraCNPJ()
        {
            string[] camposAux;
            palavra = string.Concat(camposAux = palavra.Split('/'));
            limpaNumero('-', 13, 15);
            string[,] partes = { { "0", "8", "/" }, { "8", "4", "-" }, { "12", Convert.ToString(1 * fator), "" } };
            masctipo(3, partes);
            return palavra;
        }
    }
}
