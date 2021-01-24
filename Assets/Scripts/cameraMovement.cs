using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
   [SerializeField]
   private Transform Target;
   
   private Vector3 offset;
 
   // Use this for initialization
   void Start () 
   {
       offset = transform.position;
   }
 
   // Update is called once per frame
   void Update () 
   {
        /*if(Target){
            transform.position = Target.TransformPoint(new Vector3(-1.2f,10.5f,-10f));
            transform.LookAt(Target);
        }*/
        transform.position = Target.transform.position+offset;
   }
}