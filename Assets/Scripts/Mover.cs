using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mover : MonoBehaviour 
{
    public Text scoreText;
    Rigidbody rbody; 
    public float speed = 5; 
    int score = 0;
    void Start()
    {
        scoreText.text = "Score: " + score;
        rbody = GetComponent<Rigidbody>(); 
    }

    void Update()
    {

        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        rbody.AddForce(dir * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Danger"))  
        {
            SceneManager.LoadScene(0);   
        }
        else
        {
            score++;
            
        }
        Destroy(other.gameObject);
        scoreText.text = "Score: " + score;
        

    }


}
