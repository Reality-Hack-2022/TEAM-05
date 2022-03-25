using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URPAnimatingColorChanger : MonoBehaviour
{
    public float verticalMultiplier = 3.0f;
    public float movementSpeed = 5.0f;

    public Color StartColor;
    public Color EndColor;

    //private MaterialPropertyBlock _propBlock;

    GameObject choosenChild;
    public void AnimateAndColorChange()
    {
        
        for (int i = 0; i < transform.childCount; i++)
        {
            choosenChild = transform.GetChild(i).gameObject;

            choosenChild.transform.position = new Vector3(choosenChild.transform.position.x,(verticalMultiplier * Mathf.Sin((Time.time+choosenChild.transform.position.x/100.0f) * movementSpeed)),choosenChild.transform.position.z);

            choosenChild.GetComponent<Renderer>().material.color = Color.Lerp(StartColor, EndColor, Mathf.Sin((choosenChild.transform.position.y / verticalMultiplier)) / 2.0f + 0.5f);

        }
    }

    private void Awake()
    {
        //_propBlock = new MaterialPropertyBlock();
    }
    private void Start()
    {
        /*
        for (int i = 0; i < transform.childCount; i++)
        {
            choosenChild = transform.GetChild(i).gameObject;
            _propBlock.SetColor("_Color", Color.Lerp(StartColor, EndColor, Random.Range(0.0f, 1.0f)));
            choosenChild.GetComponent<Renderer>().SetPropertyBlock(_propBlock);
        }*/
        

    }

    private void Update()
    {
        AnimateAndColorChange();
    }

}
