using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public string playerName;

    private void Awake()
    {
        if (gameManager != null)
        {
            Destroy(gameObject);
            return;
        }
        gameManager = this;
        DontDestroyOnLoad(gameObject);
    }
}
