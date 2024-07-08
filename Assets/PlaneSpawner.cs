using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zombie
{
    public class PlaneSpawner : MonoBehaviour
    {
        public GameObject planePrefab;
        public int planeFrequency;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            float b = Mathf.Pow(10, Mathf.Log10(0.25f) / 994.5f);
            planeFrequency = Mathf.RoundToInt(100 * Mathf.Pow(b, transform.position.y));
            if (Random.Range(0, planeFrequency) == 1)
            {
                Instantiate(planePrefab, transform.position + new Vector3((Random.Range(-1,1) * 2 + 1)*10,0,0), transform.rotation);
            }
        }
    }
}