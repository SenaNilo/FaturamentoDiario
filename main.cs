using System;

class Program {
  public static void Main (string[] args) {
    int i, diaUtil, fatuMaiorMensal=0;
    double maiorFatu=0, menorFatu=0, somatoria=0, mediaMensal;
    Console.WriteLine("Quantos dias úteis terá este mês?");
    diaUtil = int.Parse(Console.ReadLine());
    double[] faturamento = new double[diaUtil];
    
    Console.WriteLine("* Se houver um dia sem faturamento, digite 0 *");
    
    for(i = 0; i < diaUtil; i++){
      Console.WriteLine("Faturamento do {0}º dia útil: ", i+1);
      faturamento[i] = double.Parse(Console.ReadLine());
      somatoria = somatoria + faturamento[i];
      
      if(i == 0){
        maiorFatu = faturamento[i];
        menorFatu = faturamento[i];
      }else{
        if(maiorFatu < faturamento[i]){
          maiorFatu = faturamento[i];
        }else{
          if(menorFatu > faturamento[i]){
            menorFatu = faturamento[i]; 
          }
        }
      }
    }
    mediaMensal = somatoria / diaUtil;
    for(i = 0; i < diaUtil; i++){
      if(faturamento[i] > mediaMensal){
        fatuMaiorMensal++;
      }
    }
    Console.WriteLine("Neste mês obteve se");
    Console.WriteLine("Maior faturamento = {0}", maiorFatu);
    Console.WriteLine("Menor faturamento = {0}", menorFatu);
    Console.WriteLine("Média Mensal = {0}", mediaMensal);
    Console.WriteLine("Quantidades de dias que superaram a média mensal = {0}", fatuMaiorMensal);
    
  }
}