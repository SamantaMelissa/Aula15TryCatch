using System;

namespace Aula15TryCatch
{
    public class Permissao
    {
    
        public bool Permitir { get; set; }

        public void Autorizar(){
            Console.WriteLine("Deseja permitir acesso? Digite true ou false.");
           //ERRO --> Permitir = Boolean.Parse(Console.ReadLine());

           
           try{
               Permitir = Boolean.Parse(Console.ReadLine());
           } catch(Exception){
               Console.WriteLine("Erro na aplicação");
           }

        }
         public void Acessar(bool Acesso){
           if(Acesso){
            Console.WriteLine("Acesso permitido!");
            } else{
            Console.WriteLine("Acesso negado!");
            }
            
          }


    }
}