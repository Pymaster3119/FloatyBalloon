using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace manager
{
    public class GameManager : MonoBehaviour
    {
        public Animator deathMenu;
        public static GameManager main;
        public bool fired;
        // Start is called before the first frame update
        void Start()
        {
            main = this;
            fired = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (player.BaloonController.main.health<=0 && !fired)
            {
                player.BaloonController.main.playerSpeed = 0;
                player.BaloonController.main.coinSource.volume = 0;
                player.BaloonController.main.healthSource.volume = 0;
                player.BaloonController.main.bulletAudio.volume = 0;
                deathMenu.gameObject.SetActive(true);
                deathMenu.Play("Window In");
                fired = true;
            }
        }

        public void goToScene(int scene)
        {
            if (scene == 1)
                DontDestroyOnLoad(gameObject.transform.Find("Audio Source"));
            SceneManager.LoadScene(scene);
        }
    }
}