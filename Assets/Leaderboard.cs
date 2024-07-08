using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace leaderboard
{
    public class Leaderboard : MonoBehaviour
    {
        public GameObject serverButton;
        public static Dan.Models.Entry[] leaderboard;
        bool leaderboardUpdated = false;

        public Transform leaderboardGUI;
        // Update is called once per frame
        void Start()
        {
            Dan.Main.Leaderboards.MyBoard.GetEntries((Dan.Models.Entry[] obj) => leaderboard = obj);
        }

        private void Update()
        {
            if (!leaderboardUpdated && leaderboard != null)
            {
                foreach (Dan.Models.Entry curr in leaderboard)
                {
                    GameObject currButton = Instantiate(serverButton, leaderboardGUI);
                    currButton.GetComponent<ServerButton>().name.text = curr.Username;
                    currButton.GetComponent<ServerButton>().score.text = curr.Score.ToString();
                    leaderboardUpdated = true;
                }
            }
        }
    }
}