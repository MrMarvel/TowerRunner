using UnityEngine;

public class FinishPlatformScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        var player = other.gameObject;
        player.GetComponent<PlayerScript>().Finish();
    }
}
