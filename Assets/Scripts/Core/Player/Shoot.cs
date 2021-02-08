using UnityEngine;
using Enemies;

namespace Player
{
    public class Shoot : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                checkIfCollidesWithEnemy();
            }
        }
        private void checkIfCollidesWithEnemy()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Transform selection = hit.transform;
                shoot(selection.GetComponent<IEnemy>());
            }

        }

        public void shoot(IEnemy obstacleSelected)
        {
            if (obstacleSelected!= null)
            {
                if(obstacleSelected.typeOfEnemy == (int)TypeOfEnemy.Spikes)
                {
                    GetComponent<Status>().score++;
                    IEnemy spikes = obstacleSelected;
                    spikes.enemyLife-=2;
                }
                else if(obstacleSelected.typeOfEnemy == (int)TypeOfEnemy.LowEnemy)
                {

                }
            }
        }
    }
}


