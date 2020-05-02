using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    private float spead;
    
    // Start is called before the first frame update
    void Start()
    {
           spead = Random.Range(5f, 15f); 
    }

    // Update is called once per frame
    void Update()
    {
           transform.position += new Vector3(0f, 0f, -1 * spead * Time.deltaTime);
           if(transform.position.z < -13.0f)
           {
               //Debug.Log("Game Over");
               //Time.timeScale = 0;
               SceneManager.LoadScene("GameOver");
           }
           
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("paddle"))
        {
            Destroy(gameObject);  
            collision.gameObject.transform.localScale -= new Vector3(Random.Range(0.2f, 1.0f), 0f, 0f);
            if (collision.gameObject.transform.localScale.x < 1.0f)
            {
                collision.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
             }
          }
       }
}