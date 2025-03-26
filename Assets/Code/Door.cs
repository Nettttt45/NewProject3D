using UnityEngine;

public class Door : MonoBehaviour
{
    public int requiredKeyID; // ระบุว่าประตูนี้ต้องใช้กุญแจหมายเลขอะไร

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory != null && inventory.HasKey(requiredKeyID))
            {
                Debug.Log("เปิดประตู ID: " + requiredKeyID);
                Destroy(gameObject); // เปิดประตูโดยทำลายมัน
            }
            else
            {
                Debug.Log("ต้องการกุญแจ ID: " + requiredKeyID);
            }
        }
    }
}

