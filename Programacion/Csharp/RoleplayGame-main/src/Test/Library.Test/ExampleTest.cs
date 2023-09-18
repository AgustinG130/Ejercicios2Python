using Library;
using NUnit.Framework;

namespace Test.Library
{
    public class ExampleTest
    {
        [Test]
        public void dummyTest()
        {
            Assert.True(true);
        }
        [Test]
        public void Mago()
        {
            Wizard Istari = new Wizard();
            Istari.SetName("Gandalf");
            Istari.SetItem("Magic Staff");
            Istari.SetHealth(100);
            Istari.SetMagic(100);
            Istari.SetAttack(10);
            string expected = "Gandalf";
            Assert.AreEqual(Istari.GetName(),expected); //funciona


            Wizard Istari2 = new Wizard();
            Istari2.SetName("Gandalf2");
            Istari2.SetItem("Magic Staff");
            Istari2.SetHealth(100);
            Istari2.SetMagic(100);
            Istari2.SetAttack(10);
            expected = "Gandalf2";
            Assert.AreEqual(Istari2.GetName(),expected); //funciona

            //el metodo de pelea deberia ser algo asi: donde Istari2 seria el golpeado y Istari el que golpea
            Istari2.SetHealth(Istari2.GetHealth() - Istari.GetAttack());
            Assert.AreEqual(Istari2.GetHealth(),90); //verifico si se cumple
            

        }  
        
        [Test]
        public void dwarves()
        {

            Dwarves Enano = new Dwarves();
            Enano.SetName("Enano 1");
            Enano.SetItem("Axe");
            Enano.SetHealth(100);
            Enano.SetArmor(60);
            Enano.SetAttack(30);
            string expected = "Enano 1";
            Assert.AreEqual(Enano.GetName(),expected); //funciona

            Dwarves Enano2 = new Dwarves();
            Enano2.SetName("Enano 2");
            Enano2.SetItem("Axe");
            Enano2.SetHealth(100);
            Enano2.SetArmor(60);
            Enano2.SetAttack(30);
            expected = "Enano 2";
            Assert.AreEqual(Enano2.GetName(),expected); //funciona



            //el metodo de pelea deberia ser algo asi: donde Istari2 seria el golpeado y Istari el que golpea
            Enano2.SetHealth(Enano2.GetHealth()-Enano.GetAttack());
            Assert.AreEqual(Enano2.GetHealth(),70); //verifico si se cumple
            

        }  
        [Test]
        public void elves()
        {

            Elves Elfo = new Elves();
            Elfo.SetName("Elfo 1");
            Elfo.SetItem("Bow");
            Elfo.SetHealth(100);
            Elfo.SetArrow(5);
            Elfo.SetAttack(50);
            string expected = "Elfo 1";
            Assert.AreEqual(Elfo.GetName(),expected); //funciona

            Elves Elfo2 = new Elves();
            Elfo2.SetName("Elfo 2");
            Elfo2.SetItem("Bow");
            Elfo2.SetHealth(100);
            Elfo2.SetArrow(5);
            Elfo2.SetAttack(50);
            expected = "Elfo 2";
            Assert.AreEqual(Elfo2.GetName(),expected); //funciona



            //el metodo de pelea deberia ser algo asi: donde Istari2 seria el golpeado y Istari el que golpea
            Elfo2.SetHealth(Elfo2.GetHealth()-Elfo.GetAttack());
            Assert.AreEqual(Elfo2.GetHealth(),50); //verifico si se cumple
            

        }
        [Test]
        public void Fight()
        {   
            Fight fight = new Fight();
            Elves elfo = new Elves();         //instancio los objetos
            Wizard mago = new Wizard();
            elfo.SetName("Legolas");
            elfo.SetItem("Bow");
            elfo.SetHealth(100);
            elfo.SetArrow(5); //no tiene una funcion aun
            elfo.SetAttack(50);
            mago.SetName("Gandalf");
            mago.SetItem("Baston");
            mago.SetHealth(100);
            mago.SetMagic(100);
            mago.SetAttack(50);
            fight.GetBattle(mago,elfo); //ejecuto el metodo GetBattle y le hago daño al mago
            Assert.AreEqual(mago.GetHealth(),50); //verifico 

        }            
    }
    
}