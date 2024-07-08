using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class FirerateIndicator : MonoBehaviour
    {
        public Slider alternate;
        private void Update()
        {
            GetComponent<Slider>().value = player.BaloonController.main.timer / player.BaloonController.firerate;
            if (player.Autofire.firerate != 0)
            {
                alternate.value = player.BaloonController.main.GetComponent<player.Autofire>().timer / player.Autofire.firerate;
            }
            else
                alternate.gameObject.SetActive(false);
        }
    }
}