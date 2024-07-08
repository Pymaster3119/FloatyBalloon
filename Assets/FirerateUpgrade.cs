using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace powerups
{
    public class FirerateUpgrade : MonoBehaviour
    {
        public float firerateMultiplier;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            player.BaloonController controller;
            if (collision.TryGetComponent(out controller))
                player.BaloonController.firerate /= firerateMultiplier; Destroy(gameObject);
        }
    }
}