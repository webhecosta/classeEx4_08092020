using System;

class Pessoa {

   public string nome;
   public int idade;
   public double peso,altura,teste,pesoNovo,pesoAtual;
 
     //FUNÇÃO ENVELHECER
   public void Envelhecer(double idade,double altura) {  
    if (idade < 21){
      altura = altura + 0.5;      
    }
    idade +=1;  
    //return idade;
    //return altura; 
    Console.WriteLine("Idade :  {0} \nAltura: {1}" ,idade , altura);
 
  }
   //FUNÇÃO ENGORDAR
   public double Engordar(double pesoNovo,double pesoAtual) {
      peso = pesoAtual + pesoNovo;
      return peso;    
  }
   //FUNÇÃO EMAGRECER
    public double Emagrecer(double pesoNovo,double pesoAtual) {
      peso = pesoAtual - pesoNovo;
      return peso;    
  }
    
   //FUNÇÃO MOSTRAR O NOVO RESULTADO
   public void MostraInformacao(string nome, int idade, double peso,double altura){
    Console.WriteLine("Nome: {0}, idade: {1}, peso: {2}, altura: {3}", nome, idade, peso, altura);
    Console.WriteLine("---------NOVOS DADOS----------");
    Console.WriteLine("Nome:"+ nome);
    Envelhecer(idade,1.6);
    Console.WriteLine("Nova Peso: " + Emagrecer(4,peso));
  
  
  
    
  




  }

}