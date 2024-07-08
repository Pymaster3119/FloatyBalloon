using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zombie
{
    public class GroundZombieSpawner : MonoBehaviour
    {
        public GameObject groundZombie;
        public int zombieCount;
        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < zombieCount; i++)
            {
                Instantiate(groundZombie,transform.position + new Vector3(Random.Range(-50, 50),0,0),transform.rotation);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}