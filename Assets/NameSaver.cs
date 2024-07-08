using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
namespace UI
{
    public class NameSaver : MonoBehaviour
    {
        public static string playerName;
        public TextMeshProUGUI nameInput;
        public TextMeshProUGUI nameOutput;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            playerName = nameInput.text;
            nameOutput.text = playerName;
        }

        public void ChangeScene(int scene)
        {
            SceneManager.LoadScene(scene);
        }
    }
}