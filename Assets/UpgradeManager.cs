using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace powerups
{
    public class UpgradeManager : MonoBehaviour
    {
        public TMPro.TextMeshProUGUI autofireText;
        public TMPro.TextMeshProUGUI damageText;
        public TMPro.TextMeshProUGUI resistanceText;
        public TMPro.TextMeshProUGUI firerateText;
        public TMPro.TextMeshProUGUI coinText;
        public int firerateCost;
        public int damageCost;
        public int resistanceCost;
        public int autofireCost;
        public int coinCost;
        public void UpgradeFirerate()
        {
            if (player.BaloonController.coins >= firerateCost)
            {
                player.BaloonController.coins -= firerateCost;
                player.BaloonController.firerate /= 1.5f;
            }
        }
        public void UpgradeDamage()
        {
            if (player.BaloonController.coins >= damageCost)
            {
                player.BaloonController.coins -= damageCost;
                player.BaloonController.damage *= 1.5f;
            }
        }
        public void UpdateResistance()
        {
            if (player.BaloonController.coins >= resistanceCost)
            {
                player.BaloonController.coins -= resistanceCost;
                player.BaloonController.resistance *= 1.5f;
            }
        }
        public void UpdateAutofire()
        {
            if (player.BaloonController.coins >= autofireCost)
            {
                player.BaloonController.coins -= autofireCost;
                if (player.Autofire.firerate == 0)
                    player.Autofire.firerate = 10;
                else
                    player.Autofire.firerate /= 1.5f;
            }
        }
        public void UpdateCoin()
        {
            if (player.BaloonController.coins >= coinCost)
            {
                player.BaloonController.coins -= coinCost;
                PowerupSpawner.coinChance = Mathf.RoundToInt(PowerupSpawner.coinChance / 1.5f);
            }
        }
        private void Update()
        {

            if (player.Autofire.firerate == 0)
            {
                autofireText.text = "Add an automatic gun (200)";
                autofireCost = 200;
            }
            else
            {
                autofireCost = Mathf.RoundToInt(700 * Mathf.Pow(0.9f, player.Autofire.firerate));
                autofireText.text = "Upgrade Automatic Gun (" + autofireCost.ToString() + ")";
            }
            resistanceCost = Mathf.RoundToInt(50 * Mathf.Pow(1.3f, player.BaloonController.resistance));
            resistanceText.text = "Upgrade Resistance (" + resistanceCost.ToString() + ")";
            damageCost = Mathf.RoundToInt(70 * Mathf.Pow(1.4f, player.BaloonController.damage));
            damageText.text = "Upgrade Damage (" + damageCost.ToString() + ")";
            firerateCost = Mathf.RoundToInt(250 * Mathf.Pow(0.1f, player.BaloonController.firerate));
            firerateText.text = "Upgrade Fire Rate (" + firerateCost.ToString() + ")";
            coinCost = Mathf.RoundToInt(1000 * Mathf.Pow(0.985f, PowerupSpawner.coinChance));
            coinText.text = "Upgrade Coin Spawn Rates (" + coinCost.ToString() + ")";
        }
    }
}