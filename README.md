# Data Storage and Retrieval in Unity

This project demonstrates two Unity data storage systems: **ScriptableObjects** for structured game data and **PlayerPrefs** for persistent player data.

---

## Project Structure

```
Assets/
  Scripts/
    SubjectData.cs
    SubjectDataDisplay.cs
    PlayerPrefsManager.cs
  ScriptableObjects/
    SubjectData.asset
  Scenes/
    SampleScene.unity
```

---

## 1. ScriptableObjects

### How it works
ScriptableObjects are Unity assets that store data independently from any scene or GameObject. Instead of hardcoding values into scripts, you define the data once in an asset file and reference it from anywhere in the project.

**`SubjectData.cs`** defines the data structure. It inherits from `ScriptableObject` and contains five fields of different data types:
- `subjectName` (string) — the name of the subject
- `creditHours` (int) — number of credit hours
- `passingGrade` (float) — minimum grade to pass
- `isMandatory` (bool) — whether the subject is compulsory
- `enrolledStudents` (int) — number of students enrolled

**`SubjectDataDisplay.cs`** is a MonoBehaviour that reads from the `SubjectData` asset and writes each field to a TextMeshPro UI Text object on screen. It does this in `Start()` so the data displays as soon as the scene loads.

### How to test
1. Open `SampleScene`
2. In the Project window, navigate to `Assets/ScriptableObjects` and select `SubjectData`
3. Change any value in the Inspector (e.g. change `creditHours` to `5`)
4. Press **Play**
5. The updated value appears instantly on screen — no code changes needed

This proves that the display script is reading live from the asset.

---

## 2. PlayerPrefs

### How it works
PlayerPrefs is Unity's built-in system for saving small pieces of data to the player's device. The data persists even after the game is closed and reopened, making it useful for settings, high scores, and usernames.

**`PlayerPrefsManager.cs`** handles three operations:

**Save** — reads values from three input fields and writes them to disk:
- `PlayerPrefs.SetInt("HighScore", value)` — stores an integer
- `PlayerPrefs.SetFloat("Volume", value)` — stores a decimal number
- `PlayerPrefs.SetString("Username", value)` — stores text

**Load** — retrieves stored values and displays them in the UI:
- `PlayerPrefs.GetInt("HighScore", 0)` — reads the integer (default 0 if not found)
- `PlayerPrefs.GetFloat("Volume", 1f)` — reads the float (default 1.0)
- `PlayerPrefs.GetString("Username", "Player")` — reads the string (default "Player")

**Delete** — removes all three keys from storage using `PlayerPrefs.DeleteKey()`

### How to test
1. Press **Play**
2. Type values into the three input fields:
   - Score: `850`
   - Volume: `0.7`
   - Username: `Keza`
3. Click **Save** — status shows "Data Saved!" and display texts update
4. **Stop Play**, then press **Play** again
5. Click **Load** — the same values reappear, proving data survived the session
6. Click **Delete** to wipe all stored values and confirm they are gone

---



## Requirements
- Unity 6
