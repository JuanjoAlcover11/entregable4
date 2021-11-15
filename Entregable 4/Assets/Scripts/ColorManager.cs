using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color RandomColor;
    public Vector3 RandomScale;
    public Vector3 RandomPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        RandomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        GetComponent<MeshRenderer>().material.color = RandomColor;

        RandomScale = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        GetComponent<MeshRenderer>().transform.localScale = RandomScale;

        RandomPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        GetComponent<MeshRenderer>().transform.localPosition = RandomPosition;
    }
}
