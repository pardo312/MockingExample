using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemies
{
    public interface IEnemy
    {
        int typeOfEnemy { get;}
        int enemyLife { get; set; }
        void actOnCollisionWithPlayer(GameObject player);
        void ObstacleDie();
    }
}
