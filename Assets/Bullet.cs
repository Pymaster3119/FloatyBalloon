using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace player
{
    public class Bullet : MonoBehaviour
    {
        public int speed;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(speed * Time.deltaTime, 0, 0, Space.Self);

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.name.Contains("Zombie"))
            {
                collision.GetComponent<Zombie.AirZombie>().health -= BaloonController.damage;
                BaloonController.score += BaloonController.main.scoreDeaths;
            }
        }
    }
}