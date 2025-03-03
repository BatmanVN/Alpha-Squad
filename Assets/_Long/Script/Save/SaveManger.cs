using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using UnityEngine;

public class SaveManger : MonoBehaviour
{
    [SerializeField] private BombData BombData;
    [SerializeField] private PistolData PistolData;
    [SerializeField] private RilfeData RilfeData;
    [SerializeField] private ShotgunData ShotgunData;
    [SerializeField] private SmgData SmgData;
    [SerializeField] private SniperData SniperData;
    [SerializeField] private AgentData AgentData;

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
    [Button]
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
                GameData data = JsonUtility.FromJson<GameData>(json);

                if (data != null)
                {

                    data.BombsData = BombData.bombData;
                    data.PistolsData = PistolData.data;
                    data.RilfesData = RilfeData.rifleData;
                    data.ShotgunsData = ShotgunData.shotgunData;
                    data.SmgsData = SmgData.smgData;
                    data.SnipersData = SniperData.sniperData;

                    Debug.Log("Dữ liệu đã tải từ: " + filePath);
                }
            }
            catch (System.Exception e)
            {
                Debug.LogError("Lỗi khi đọc JSON: " + e.Message);
            }
        }
    }
}

[System.Serializable]
public class GameData
{
    public List<Bomb> BombsData;
    public List<Pistol> PistolsData;
    public List<Rilfe> RilfesData;
    public List<Shotgun> ShotgunsData;
    public List<Smg> SmgsData;
    public List<Sniper> SnipersData;
    public List<Agent> Agents;
}
