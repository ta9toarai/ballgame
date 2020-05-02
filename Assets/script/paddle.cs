using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{   
    //private float spead;
    public float spead;

    // Start is called before the first frame update
    void Start()
    {
          //spead = 5f; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * spead, 0f, 0f);
        // Debug.Log(transform.position.x);
    }
}
