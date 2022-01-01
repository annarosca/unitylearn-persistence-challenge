using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public string playerName;
    public int playerPoints;

    public string highScorePlayer;
    public int highScore;

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

    [System.Serializable]
    class SaveData
    {
        public string playerName;
        public int playerPoints;
    }

    public void SaveResults()
    {
        SaveData data = new SaveData();
        data.playerName = playerName;
        data.playerPoints = playerPoints;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadResults()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            highScorePlayer = data.playerName;
            highScore = data.playerPoints;
        }
    }
}
