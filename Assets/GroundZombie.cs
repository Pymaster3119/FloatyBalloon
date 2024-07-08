using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zombie
{
    public class GroundZombie : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.localScale = transform.position.x < player.BaloonController.main.transform.position.x ? new Vector3(0.13f, 0.13f, 0.13f) : new Vector3(-0.13f, 0.13f, 0.13f);
            transform.Translate(transform.position.x < player.BaloonController.main.transform.position.x ? Time.deltaTime : -Time.deltaTime, 0, 0);
        }
    }
}