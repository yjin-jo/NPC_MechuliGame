using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class PlayerData
{
    public List<string> hints = new List<string>();
}

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public PlayerData nowPlayer = new PlayerData();

    string path;
    string filename = "save.json";

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(instance.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

        path = Application.persistentDataPath + "/";
        print(path);
        LoadData();
    }

    public void SaveData()
    {
        string data = JsonUtility.ToJson(nowPlayer);
        File.WriteAllText(path + filename, data);
    }

    public void LoadData()
    {
        if (File.Exists(path + filename))
        {
            string data = File.ReadAllText(path + filename);
        
            nowPlayer = JsonUtility.FromJson<PlayerData>(data);
        }
        else
        {
            nowPlayer = new PlayerData();
        }
    }
}
