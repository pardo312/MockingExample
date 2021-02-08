using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;

namespace Tests
{
    public class Test
    {

        // A Test behaves as an ordinary method
        [Test]
        //Spikes
        [TestCase(2,3, false)]
        [TestCase(5,3, true)]
        [TestCase(3,3,false)]
        public void ShootEnemy(int numberOfShotsEnemyTakes, int typeOfEnemy, bool isEnemySupposedToBeDead)
        {
            //Arrange
            GameObject player = new GameObject();   
            Player.Shoot shootScript = player.AddComponent<Player.Shoot>(); ;
            Player.Status status = player.AddComponent<Player.Status>(); ;

            Enemies.IEnemy enemy = Substitute.For<Enemies.IEnemy>();
            enemy.enemyLife.Returns(10);
            enemy.typeOfEnemy.Returns(typeOfEnemy);
            int initLife = 10;

            //Act
            for (int i = 0; i < numberOfShotsEnemyTakes; i++)
            {
                player.GetComponent<Player.Shoot>().shoot(enemy);
            }

            //Assert
            Assert.AreEqual(initLife - (numberOfShotsEnemyTakes * 2), enemy.enemyLife);
        }

    }
}
