using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    [SerializeField] float movespeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInformation();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInformation()
    {
        Debug.Log("Welcome to obstacle game");
        Debug.Log("Reach to the other end without colliding with any object");
    }

    void MovePlayer()
    {
        float xvalue= Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float yvalue= 0;
        float zvalue= Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(xvalue,yvalue,zvalue);
    }
}
