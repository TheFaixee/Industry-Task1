using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private float horizontalInput;
    private float verticalInput;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        //InputKey

        if (Input.GetKey(KeyCode.W))
        {
            transform.localScale = new Vector3(1, 3, 1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localScale = new Vector3(1, 1, 4);
        }



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Time.timeScale = 0;
        }
        if (other.gameObject.CompareTag("Points"))
        {
            ScoreScripts.scoreValue += 20;
        }
    }
}        
        
    

