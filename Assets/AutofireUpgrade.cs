using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace powerups
{
    public class AutofireUpgrade : MonoBehaviour
    {
        public float autofireMultiplier;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            player.BaloonController controller;
            if (collision.TryGetComponent(out controller))
                player.Autofire.firerate /= autofireMultiplier; Destroy(gameObject);
        }
    }
}