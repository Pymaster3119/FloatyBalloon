using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace player
{
    public class Autofire : MonoBehaviour
    {
        public static float firerate;
        public float timer;
        public GameObject bullet;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            if (timer >= firerate && firerate != 0)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 10);
                float mindistance = 10000;
                GameObject mindist = null;
                foreach (Collider2D curr in colliders)
                {
                    if(curr.name.Contains("Zombie") && (transform.position - curr.transform.position).magnitude < mindistance)
                    {
                        mindist = curr.gameObject;
                    }
                }

                if(mindist != null)
                {
                    float rotation = Mathf.Atan2(mindist.transform.position.y - transform.position.y, mindist.transform.position.x - transform.position.x) * Mathf.Rad2Deg;
                    Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, rotation));
                    timer = 0;
                }
            }
        }
    }
}