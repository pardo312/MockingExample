using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using Player;
using Enemies;
namespace Test
{
    public class PlayerTest
    {
        [UnityTest]
        [TestCase(6, 320, 50, ExpectedResult = null)]
        public IEnumerator recibirDaño(int numeroDeChoques,int vidaDelJugador, int dañoRecibido)
        {

            GameObject player = new GameObject();
            Status status = player.AddComponent<Status>();
            status.life = vidaDelJugador;
            GameObject enemy = new GameObject();
            Spikes spikes = enemy.AddComponent<Spikes>();

            for (int i = 0; i < numeroDeChoques; i++)
            {
                spikes.actOnCollisionWithPlayer(player, dañoRecibido);
            }
            yield return new WaitForSeconds(0.3f); 
            Assert.AreEqual(20, player.GetComponent<Status>().life);
            
        }
    }
}
