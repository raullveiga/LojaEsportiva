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



        }
    }
}