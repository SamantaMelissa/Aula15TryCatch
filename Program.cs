using System;

namespace Aula15TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Permissao app = new Permissao(); //Aqui não trabalha com váriavel e nem ação
            
            //métodos
            app.Autorizar();
            app.Acessar(app.Permitir);
           
           
            
           
        
        }
    }
}
