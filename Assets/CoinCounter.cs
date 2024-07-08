using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = player.BaloonController.coins.ToString();
    }
}
