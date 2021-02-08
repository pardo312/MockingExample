using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

namespace Enemies
{
    public class Spikes : MonoBehaviour,IEnemy
    {
        public int typeOfEnemy { get; set; }
        public int enemyLife { get; set; }
        public bool death = false;

        public void Start()
        {
            typeOfEnemy = (int)TypeOfEnemy.Spikes;
            enemyLife = 10;
        }
        private void Update()
        {
            if (enemyLife < 1)
            {
                ObstacleDie();
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                actOnCollisionWithPlayer(other.gameObject,10);
            }
        }

        public void actOnCollisionWithPlayer(GameObject player,int dañoRecibido)
        {
            Status playerStatus = player.GetComponent<Status>();
            playerStatus.life -= dañoRecibido;
        }
        public void ObstacleDie()
        {
            gameObject.SetActive(false);
            death = true;
        }
    }
}
