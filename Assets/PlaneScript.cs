using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    public float planeSpeed;
    public bool toLeft;
    float timer = 0;
    public bool zombiesSpawned;
    public float zombiesToSpawn;
    public GameObject zombie;
    // Start is called before the first frame update
    void Start()
    {
        toLeft = transform.position.x < player.BaloonController.main.transform.position.x;
        transform.localScale = new Vector3(toLeft ? -1 : 1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(toLeft? planeSpeed * Time.deltaTime : -planeSpeed * Time.deltaTime, 0, 0);
        if(toLeft != transform.position.x < player.BaloonController.main.transform.position.x)
        {
            if (!zombiesSpawned)
                for (int i = 0; i < zombiesToSpawn; i++)
                    Instantiate(zombie, transform.position + new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)), transform.rotation); zombiesSpawned = true;
            timer += Time.deltaTime * 2;
            transform.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(0, toLeft?-45:45, timer));
        }
    }
}
