using UnityEngine;
using System.IO;

public static class SaveSystem
{
    public static void Save<T>(T saveData) where T : ISaveData
    {
        string path = GetPath<T>();
        string json = JsonUtility.ToJson(saveData, true);
        File.WriteAllText(path, json);
    }

    public static T Load<T>() where T : ISaveData
    {
        string path = GetPath<T>();
        string json = File.ReadAllText(path);
        return JsonUtility.FromJson<T>(json);
    }

    public static string GetPath<T>()
    {
        string fileName = typeof(T).Name + ".json";
        return Path.Combine(Application.persistentDataPath, fileName); 
    }
}

public interface ISaveData { }