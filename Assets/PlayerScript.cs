using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public GameObject playerSpawner;

    private void Start()
    {
        TeleportToSpawner();
    }

    public void TeleportToSpawner()
    {
        var spawnerTransform = playerSpawner.GetComponent<Transform>();
        transform.position = spawnerTransform.position + Vector3.up * 2;
        transform.rotation = spawnerTransform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            Lose();
        }
    }

    public void Lose()
    {
        TeleportToSpawner();
    }

    public void Finish()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
