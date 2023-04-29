using UnityEngine;

public class WindScript : MonoBehaviour
{
    public float WindSpeed = 10;
    private void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        other.GetComponent<Rigidbody>().AddForce(transform.forward * WindSpeed);
    }
}
