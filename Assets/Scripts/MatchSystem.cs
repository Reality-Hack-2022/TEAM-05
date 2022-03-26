using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchSystem : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-2,2), 0, Random.Range(-2, 2));
    }
    void OnTriggerEnter(Collider Collided)
    {
        if (Collided.name == gameObject.name)
        {
            Place(Collided);
        }
    }

    void Place(Collider PlaceColl)
    {
        gameObject.transform.position = PlaceColl.transform.position;
        gameObject.transform.rotation = PlaceColl.transform.rotation;
        PlaceColl.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<Renderer>().sharedMaterial.color = Color.green;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameObject.GetComponent<AudioSource>().Play();
    }
}
