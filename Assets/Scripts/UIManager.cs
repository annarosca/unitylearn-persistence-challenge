using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_InputField playerName;
    //[SerializeField] private TMPro.TMP_Text placeholder;
    private void Start()
    {
        if (GameManager.gameManager.playerName != null)
        {
            playerName.text = GameManager.gameManager.playerName;
        }
        GameManager.gameManager.LoadResults();
    }

    private void StartGame()
    {
        GameManager.gameManager.playerName = playerName.text.Length > 0 ? playerName.text : "Anonymous";
        SceneManager.LoadScene(1);
    }
}
