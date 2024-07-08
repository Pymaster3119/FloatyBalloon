using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class HealthBar : MonoBehaviour
    {

        public TMPro.TextMeshProUGUI percentage;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            GetComponent<Slider>().value = player.BaloonController.main.health;
            percentage.text = Mathf.RoundToInt(Mathf.Max(0,player.BaloonController.main.health)) + "%";
        }
    }
}