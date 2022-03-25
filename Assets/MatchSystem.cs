using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchSystem : MonoBehaviour
{
    public void Update()
    {
    
    }
    void OnTriggerEnter(Collider Collided)
    {
        Place(Collided);
    }

    void Place(Collider PlaceColl)
    {
        float time = 5.0f;
        while(time > 0.0f)
        if (PlaceColl.name == gameObject.name)
        {
            gameObject.transform.position = PlaceColl.transform.position;
            gameObject.transform.rotation = PlaceColl.transform.rotation;
            time -= Time.deltaTime;
        }
        Physics.SyncTransforms();
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameObject.GetComponent<AudioSource>().Play();
    }
}
