using UnityEngine;
using System.IO;

public static class SaveSystem
{
    public static void Save<T>(T saveData) where T : ISaveData
    {
        string fileName = typeof(T).Name + ".json";
        string path = Path.Combine(Application.persistentDataPath, fileName);
        var data = JsonUtility.ToJson(saveData, true);
        File.WriteAllText(path, data);
    }

    public static T Load<T>()
    {
        string fileName = typeof(T).Name + ".json";
        string path = Path.Combine(Application.persistentDataPath, fileName);
        string json = File.ReadAllText(path);
        return JsonUtility.FromJson<T>(json);
    }
}

public interface ISaveData { }