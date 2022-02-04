using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* TODO
- Bruit lorsqu'on grab la balle ?
- Bruit lorsque la balle touche le sol
- Bruit spécial lorsque le joueur touche le panier
*/

public class sound : MonoBehaviour
{
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Plane")
        // collision avec l'objet nommé "Plane"
        // collision.gameObject.tag
        {
            source.Play();
            Debug.Log("Collision");
        }
    }
}