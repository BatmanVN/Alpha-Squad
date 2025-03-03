using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using UnityEngine;

public class SaveManger : MonoBehaviour
{
    public string filePath;

    [Button]
    public void SaveGameData(List<ScriptableObject> Data, string filename)
    {
        string filePath = Path.Combine(Application.dataPath,"_Game/SaveFile" ,filename + ".json");

        List<string> jsondata = new List<string>();
        foreach (var scriptableObject in Data)
        {
            string json = JsonUtility.ToJson(scriptableObject, true);
            jsondata.Add(json);
        }
        string finalJson = "{ \"list\": [" + string.Join(",", jsondata) + "] }";
        try
        {
            File.WriteAllText(filePath, finalJson);
            Debug.Log("Dữ liệu đã được lưu tại: " + filePath);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Không thể lưu file JSON: " + e.Message);
        }
    }


    private void LoadFile()
    {
        {
            if (!File.Exists(filePath))
            {
                Debug.LogWarning("Không tìm thấy file JSON: " + filePath);
                return;
            }

            try
            {
                string json = File.ReadAllText(filePath);
            }
            catch (System.Exception e)
            {
                Debug.LogError("Lỗi khi đọc JSON: " + e.Message);
            }
        }
    }
}
