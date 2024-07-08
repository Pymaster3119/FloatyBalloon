using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace powerups
{
    public class HealthPowerup : MonoBehaviour
    {
        public int healthRecovered;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            player.BaloonController controller;
            if (collision.TryGetComponent(out controller))
            {
                controller.healthSource.Stop();
                controller.healthSource.Play();
                controller.health = Mathf.Min(100, controller.health + 10);
                Destroy(gameObject);
            }
        }
    }
}