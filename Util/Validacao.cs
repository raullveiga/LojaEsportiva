using System;

namespace Util
{
    public class Validacao
    {
        public static bool validarCPF(string CPF)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf, digito;
            int soma = 0, resto = 0;

            CPF = CPF.Replace(".", "").Replace("-", "");


            if (CPF.Length != 11)
            {
                return false;
            }

            if (CPF == "00000000000" || CPF == "11111111111" || CPF == "22222222222"
            || CPF == "33333333333" || CPF == "44444444444" || CPF == "55555555555"
            || CPF == "66666666666" || CPF == "77777777777" || CPF == "88888888888" || CPF == "99999999999")
            {
                return false;
            }
            tempCpf = CPF.Substring(0, 9);
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt16(tempCpf[i].ToString()) * multiplicador1[i];
            }
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += Convert.ToInt16(tempCpf[i].ToString()) * multiplicador2[i];
            }
            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            //Verifica se os ultimos 2 digitos obtidos são iguais aos do cpf passado
            return CPF.EndsWith(digito);
        }
    }
}