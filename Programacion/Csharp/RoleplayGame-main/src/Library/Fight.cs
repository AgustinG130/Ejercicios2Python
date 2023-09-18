using System.Net.Http.Headers;
namespace Library
{
    public class Fight
    {
        public void GetBattle<T1,T2>(T1 character1, T2 character2) where T1 : Characters where T2 : Characters //traigo Character para los T1 y T2 de forma generica
        {
            int newHealth = character2.GetHealth() - character1.GetAttack(); //guardo en la variable el daño recibido
            character1.SetHealth(newHealth); //asigno la salud con la variable
        }

    }
}
