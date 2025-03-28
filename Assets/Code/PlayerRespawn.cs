using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 respawnPosition; // ตำแหน่งที่ผู้เล่นจะเกิดใหม่
    private Rigidbody rb; // Rigidbody ของ Player

    void Start()
    {
        // กำหนดตำแหน่งเริ่มต้นของผู้เล่นเป็นจุดเกิดใหม่
        respawnPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // เช็คว่าผู้เล่นตกจากฉาก (เช่น ตกจากพื้นที่ที่ y < -10)
        if (transform.position.y < -10)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        // รีเซ็ตตำแหน่งของผู้เล่น
        transform.position = respawnPosition;
        rb.velocity = Vector3.zero; // ทำให้ผู้เล่นหยุดเคลื่อนที่ทันที
        rb.angularVelocity = Vector3.zero; // หยุดการหมุน
    }

    // ใช้ฟังก์ชันนี้ถ้าผู้เล่นตายจากการชนศัตรูหรือกับดัก
    public void SetRespawnPoint(Vector3 newRespawnPosition)
    {
        respawnPosition = newRespawnPosition;
    }
}
