using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchSystem : MonoBehaviour
{
    void OnTriggerEnter(Collider Collided)
    {
        if (Collided.name == gameObject.name)
        {
            Place(Collided);
        }
    }

    void Place(Collider PlaceColl)
    {
        float time = 5.0f;
        while(time > 0.0f)
        {
            gameObject.transform.position = PlaceColl.transform.position;
            gameObject.transform.rotation = PlaceColl.transform.rotation;
            time -= Time.deltaTime;
        }
        Physics.SyncTransforms();
        PlaceColl.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<Renderer>().sharedMaterial.color = Color.green;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameObject.GetComponent<AudioSource>().Play();
    }
}
