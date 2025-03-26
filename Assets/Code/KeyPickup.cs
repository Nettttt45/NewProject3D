using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public int keyID; // ระบุว่ากุญแจดอกนี้เปิดประตูไหน

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory != null)
            {
                inventory.CollectKey(keyID); // ให้ผู้เล่นเก็บกุญแจดอกนี้
                Destroy(gameObject); // ทำลายกุญแจ
            }
        }
    }
}
