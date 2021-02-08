using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int obstacleLife = 10;
    public bool death = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")){
            lowerPlayerLife(other.gameObject);
        }
    }

    public void lowerPlayerLife(GameObject player)
    {
        Status playerStatus = player.GetComponent<Status>();
        playerStatus.life-=10;
    }

    private void Update()
    {
        if (obstacleLife < 1)
        {
            ObstacleDie();
        }
    }
    private void ObstacleDie()
    {
        gameObject.SetActive(false);
        death = true;
    }
}
