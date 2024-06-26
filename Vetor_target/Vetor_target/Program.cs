using System;

class Program
{
    static void Main()
    {
        //declarando vetor
        int[] dia_do_ano = new int [366];

        //inicializando o ramdomizador para os valores dos dias
        Random randomização = new Random();

        //declarando variaveis
        int valor_de_faturamento_total = 0;

        int media_faturamento = 0;

        int dias_com_media_atingida = 0;
  
        //laço de repetição para dar os valores para o vetor
        for (int i = 1; i <= 365; i++ ) {
            int valor_de_faturamento = randomização.Next(0, 5000);
            dia_do_ano[i] = valor_de_faturamento;
            //somando os valores do setor para fazer a média
            valor_de_faturamento_total = valor_de_faturamento_total + valor_de_faturamento;
        }
        //declarando as variavéis para comparação nas condições
        int menor_valor_faturado = dia_do_ano[1+1];
        int maior_valor_faturado = dia_do_ano[0];

        //fazendo o calculo da média
        media_faturamento = valor_de_faturamento_total / 365;

        // Acessando o vetor para fazer toda a consulta de menor valor, maior valor  e dias onde a media foi atingida
        for (int i = 1; i < dia_do_ano.Length; i++)
        {
            if (dia_do_ano[i] < menor_valor_faturado)
            {
                menor_valor_faturado = dia_do_ano[i];
            }

            else if (dia_do_ano[i] > maior_valor_faturado){
                
                maior_valor_faturado = dia_do_ano[i];
            }

            if (dia_do_ano[i] > media_faturamento) {
                dias_com_media_atingida++;
            }
            //tirando o comentario consegue consultar todos os dias para melhor avaliar a funcionalidade
           //Console.WriteLine("Dia {0} teve o faturamento de:{1}", i, dia_do_ano[i]);
        }
        //exibindo as informações para o usuario
        Console.WriteLine("Menor valor faturado:"+menor_valor_faturado);
        Console.WriteLine("Média de faturamento:"+media_faturamento);
        Console.WriteLine("Maior valor faturado:"+maior_valor_faturado);
        Console.WriteLine("Numero de dias onde a média foi atingida:"+dias_com_media_atingida);
    }
}