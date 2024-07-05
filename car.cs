using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]float steerSpeed =1f;//dönme hareketi için
    [SerializeField]float moveSpeed = 30f;//hýz kontrolü için
    [SerializeField] float boostSpeed = 60f;
    [SerializeField] float slowSpeed = 30f;

   
 
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed*Time.deltaTime;//dönme hareketini klavyeden giriþ alarak kontrol etmek için
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed*Time.deltaTime;//her cihazda ayný kare okuma hýzýný saglamak icin
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
