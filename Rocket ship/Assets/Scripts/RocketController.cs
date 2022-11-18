using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
  [SerializeField] float ThrusterForce = 10f;
  [SerializeField] float Leftfright = 10f;
  [SerializeField] float Thiltingforce = 10f;

    bool thrust = false;
    bool left = false;
    bool right = false;

    Rigidbody rb;

    private void Awake(){
     rb = GetComponent<Rigidbody>();
    }

    private void Update(){
      float tilt = Input.GetAxis("Horizontal");
      thrust = Input.GetKey(KeyCode.Space);
      left = Input.GetKey(KeyCode.LeftArrow);
      right = Input.GetKey(KeyCode.RightArrow);
    
        if (Mathf.Approximately(tilt, 0f)){
            rb.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3(0f, 0f, (tilt * Thiltingforce * Time.deltaTime))));
        }
        rb.freezeRotation = false;
    }

    private void FixedUpdate(){
        if (thrust){
            rb.AddRelativeForce(Vector3.up * ThrusterForce * Time.deltaTime);
        }

         if (left){
            rb.AddRelativeForce(Vector3.left * ThrusterForce * Time.deltaTime);
        }

         if (right){
            rb.AddRelativeForce(Vector3.right * ThrusterForce * Time.deltaTime);
        }
        
    }
}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class RocketController : MonoBehaviour
//{
//   [SerializeField] float thrusterForce = 10f;
//   [SerializeField] float tiltingForce = 10f;
//   
//    bool thrust =false;
//
//   Rigidbody rb;
//
//   private void Awake()
//   {
//        rb = GetComponent<Rigidbody>();
//   }
//   private void Update()
//   {
//        float tilt = Input.GetAxis("Horizontal");
//        thrust = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Space);
//
//        if(!Mathf.Approximately(tilt, 0f))
//        {
//            rb.freezeRotation = true;
//            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (new Vector3(0f,0f,(tilt * tiltingForce * Time.deltaTime))));
//        }
//        rb.freezeRotation = false;
//
//
//
//   }
//
//   private void FixedUpdate()
//   {
//        if(thrust)
//        {
//            rb.AddRelativeForce(Vector3.up * thrusterForce * Time.deltaTime);
//        }
//   }
//
//
//}
//