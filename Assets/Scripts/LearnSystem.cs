using UnityEngine;
using System.Linq;
using Microsoft.MixedReality.Toolkit.Input;

public class LearnSystem : MonoBehaviour, IMixedRealityPointerHandler
{
    Vector3 pos;
    GameObject country;
    public void OnPointerDown(MixedRealityPointerEventData eventData)
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(Resources.Load("Music/" + gameObject.name, typeof(AudioClip)) as AudioClip);
        GameObject[] list = GameObject.FindGameObjectsWithTag("Wall");
        country = list.Where(obj => obj.name == gameObject.name).SingleOrDefault();
        pos = country.transform.position;
        country.transform.position -= Vector3.forward * Time.deltaTime * 5;
    }
    public void OnPointerClicked(MixedRealityPointerEventData eventData) { }
    public void OnPointerDragged(MixedRealityPointerEventData eventData) { }
    public void OnPointerUp(MixedRealityPointerEventData eventData)
    { 
        country.transform.position = pos;
    }
}