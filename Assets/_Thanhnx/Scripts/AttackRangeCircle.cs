using UnityEngine;
public class AttackRangeCircle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("enemy")){
            Debug.Log("Kẻ địch trong tầm bắn: " + other.name);
        }   
    }
}
