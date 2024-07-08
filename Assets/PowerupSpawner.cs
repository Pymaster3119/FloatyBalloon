using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public int spawnHealthProbability;
    public GameObject healthPowerup;
    public int spawnDamageProbability;
    public GameObject damagePowerup;
    public int spawnFirerateProbability;
    public GameObject fireratePowerup;
    public int spawnResistanceProbability;
    public GameObject resistancePowerup;
    public int spawnAutofireProbability;
    public GameObject autofirePowerup;
    public static int coinChance;
    // Start is called before the first frame update
    void Start()
    {
        if (coinChance == 0)
            coinChance = 400;
        spawnDamageProbability = coinChance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Random.Range(0,spawnHealthProbability) == 1)
        {
            Instantiate(healthPowerup, transform.position + new Vector3(Random.Range(-10, 10), 6), transform.rotation);
        }
        if (Random.Range(0, spawnDamageProbability) == 1)
        {
            Instantiate(damagePowerup, transform.position + new Vector3(Random.Range(-10, 10), 6), transform.rotation);
        }
        if (Random.Range(0, spawnFirerateProbability) == 1)
        {
            Instantiate(fireratePowerup, transform.position + new Vector3(Random.Range(-10, 10), 6), transform.rotation);
        }
        if (Random.Range(0, spawnResistanceProbability) == 1)
        {
            Instantiate(resistancePowerup, transform.position + new Vector3(Random.Range(-10, 10), 6), transform.rotation);
        }
        if (Random.Range(0, spawnAutofireProbability) == 1)
        {
            Instantiate(autofirePowerup, transform.position + new Vector3(Random.Range(-10, 10), 6), transform.rotation);
        }
    }
}
