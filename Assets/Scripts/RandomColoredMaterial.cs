using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColoredMaterial : MonoBehaviour
{
    //public MeshRenderer[] renderers;

    void Start()
    {
        //Color newColor = Random.ColorHSV();
        //Color newColor = Random.ColorHSV(0f, .5f);
        Color newColor = Random.ColorHSV(0f, 1f, 0.9f, 1f, 0.7f, 1f);
        ApplyMaterial(newColor, 0);

    }

    void ApplyMaterial(Color color, int targetMaterialIndex)
    {
        Material generatedMaterial = new Material(Shader.Find("Standard"));
        generatedMaterial.SetColor("_Color", color);
            gameObject.GetComponent<Renderer>().material = generatedMaterial;
    }
}
