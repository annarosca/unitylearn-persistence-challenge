using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_InputField playerName;

    private void StartGame()
    {
        Debug.Log(playerName.text);
        SceneManager.LoadScene(1);
    }
}
