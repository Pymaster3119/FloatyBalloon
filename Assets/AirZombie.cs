using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zombie
{
    public class AirZombie : MonoBehaviour
    {
        public float speed;
        public float damage;
        public float health;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            damage = Mathf.RoundToInt(0.00001f * transform.position.y * transform.position.y + 1);
            transform.rotation= Quaternion.Euler(0,0,Mathf.Atan2(player.BaloonController.main.transform.position.y - transform.position.y, player.BaloonController.main.transform.position.x - transform.position.x) * Mathf.Rad2Deg);
            transform.Translate(speed * Time.deltaTime, 0, 0, Space.Self);
            transform.rotation = Quaternion.Euler(0, 0, 0);

            if ((transform.position - player.BaloonController.main.transform.position).magnitude < 1)
            {
                player.BaloonController.main.health -= damage / player.BaloonController.resistance;
                Destroy(gameObject);
            }

            if (health <= 0)
                Destroy(gameObject);
        }
    }
}