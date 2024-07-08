using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace player
{
    public class BaloonController : MonoBehaviour
    {
        public int playerSpeed;
        public List<GameObject> cachedCloudRenderers;
        public GameObject cloudRenderer;
        public static BaloonController main;
        public float health;
        public static float damage;
        public GameObject bulletPrefab;
        public AudioSource bulletAudio;
        public static int score;
        public int scoreHeight;
        public int scoreDeaths;
        float previousHeight;
        public static float firerate;
        public float timer;
        public static float resistance;
        public AudioSource coinSource;
        public static int coins;
        public AudioSource healthSource;
        // Start is called before the first frame update
        void Start()
        {
            main = this;
            if (damage == 0)
            {
                damage = 10;
            }
            if (firerate == 0)
            {
                firerate = 0.75f;
            }
            if (resistance == 0)
            {
                resistance = 1;
            }
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 5, playerSpeed * Time.deltaTime,0);
            Camera.main.transform.position = transform.position - new Vector3(0,0,10);
            bool rendererExists = false;
            foreach(GameObject curr in cachedCloudRenderers)
                if (Mathf.Abs(curr.transform.position.x - transform.position.x) < 25)
                    rendererExists = true;

            if (!rendererExists)
                cachedCloudRenderers.Add(Instantiate(cloudRenderer, new Vector3(transform.position.x, 495), Quaternion.Euler(-90,0,0)));

            if(Input.GetMouseButtonDown(0) && timer > firerate)
            {
                timer = 0;
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, Mathf.Atan2(mousePosition.y - transform.position.y, mousePosition.x - transform.position.x) * Mathf.Rad2Deg));
                bulletAudio.Play();
            }
            if (transform.position.y - previousHeight > 1)
            {
                previousHeight = transform.position.y;
                score += scoreHeight;
            }
        }
    }
}