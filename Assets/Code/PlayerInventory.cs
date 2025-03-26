using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private HashSet<int> keys = new HashSet<int>(); // ใช้ Set เพื่อเก็บ ID ของกุญแจที่เก็บได้

    public void CollectKey(int keyID)
    {
        keys.Add(keyID);
        Debug.Log("เก็บกุญแจ ID: " + keyID);
    }

    public bool HasKey(int keyID)
    {
        return keys.Contains(keyID);
    }
}

