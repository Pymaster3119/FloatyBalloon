using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace powerups
{
    public class ResistanceUpgrade : MonoBehaviour
    {
        public float resistanceMultiplier;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            player.BaloonController controller;
            if (collision.TryGetComponent(out controller))
                player.BaloonController.resistance *= resistanceMultiplier; Destroy(gameObject);
        }
    }
}