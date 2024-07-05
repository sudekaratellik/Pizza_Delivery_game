using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]float steerSpeed =1f;//d�nme hareketi i�in
    [SerializeField]float moveSpeed = 30f;//h�z kontrol� i�in
    [SerializeField] float boostSpeed = 60f;
    [SerializeField] float slowSpeed = 30f;

   
 
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed*Time.deltaTime;//d�nme hareketini klavyeden giri� alarak kontrol etmek i�in
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed*Time.deltaTime;//her cihazda ayn� kare okuma h�z�n� saglamak icin
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;

        }
    }
}
