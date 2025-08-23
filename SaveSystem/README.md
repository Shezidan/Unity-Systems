# Unity Save System

A lightweight and generic save system I use for my Unity projects.

## Features
- Generic save and load methods, making it easy to save different types of data across any game.
- Clean and concise implementation (only 23 lines of code).
- Automatic file name generation for convenience.
- Requires the ISaveData interface to prevent errors and ensure only compatible types are saved.

## Example Usage
```csharp
public class Player : MonoBehaviour
{
    public string playerName;
    public int level;

    public void Save()
    {
        PlayerData playerData = new PlayerData();
        {
            playerData.playerName = playerName;
            playerData.level = level;
        }
        SaveSystem.Save<PlayerData>(playerData);
    
    }

    public void Load()
    {
        PlayerData playerData = SaveSystem.Load<PlayerData>();
        playerName = playerData.playerName;
        level = playerData.level;
    }
}

public class PlayerData : ISaveData
{
    public string playerName;
    public int level;
}
