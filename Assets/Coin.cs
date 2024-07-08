using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace powerups
{
    public class Coin : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            player.BaloonController controller;
            if (collision.TryGetComponent(out controller))
            {
                controller.coinSource.Stop();
                controller.coinSource.Play();
                player.BaloonController.coins += 10;
                Destroy(gameObject);
            }
        }
    }
}