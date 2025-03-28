using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ตรวจสอบว่าชนกับผู้เล่นหรือไม่
        {
            PlayerRespawn playerRespawn = other.GetComponent<PlayerRespawn>();
            if (playerRespawn != null)
            {
                playerRespawn.Respawn(); // เรียกใช้ฟังก์ชันเกิดใหม่
            }
        }
    }
}
