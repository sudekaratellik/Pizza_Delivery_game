using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    //camera position
    void LateUpdate()//fizikteki gecikmeyi engellemek i�in
    {
        transform.position = thingToFollow.transform.position+ new Vector3(0,0,-10);
        
        
    }
}
