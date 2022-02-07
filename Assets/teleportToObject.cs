using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class teleportToObject : MonoBehaviour
{
    public CharacterController player;
    public GameObject destination;

    private void OnTriggerEnter(Collider other)
    {
        player.enabled = false;
        player.transform.position = destination.transform.position;
        player.enabled = true;
    }
}
