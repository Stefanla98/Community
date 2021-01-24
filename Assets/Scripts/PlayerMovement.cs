using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = .1f;

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        /*
        if( Input.GetKeyDown("space")){
            Vector3 jump = new Vector3(0.0f, 30, 0.0f);
            transform.position += jump * speed;
        }
        */


        transform.position += moveDirection * speed;
    }

    void OnTriggerEnter(Collider other){
        
        if(other.gameObject.tag == "Hazard"){
            Debug.Log(" triggered me");
            //other.gameObject.SetActive(false);
            Vector3 jump = new Vector3(0.0f, 60, 0.0f);
            transform.position += jump * speed;
        }
    }
}