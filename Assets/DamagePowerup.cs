using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace powerups
{
    public class DamagePowerup : MonoBehaviour
    {
        public float damageMultiplier;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            player.BaloonController controller;
            if (collision.TryGetComponent(out controller))
                player.BaloonController.damage *= damageMultiplier; Destroy(gameObject);
        }
    }
}