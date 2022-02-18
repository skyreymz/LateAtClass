using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToScene : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter(Collider other)
    {
        Teleportation();
    }

    public void Teleportation()
    {
        SceneManager.LoadScene(sceneName);
    }
}
