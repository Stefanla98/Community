using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DorrInteraction : MonoBehaviour
{
	Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        m_animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
	if (Input.GetKeyDown(KeyCode.E)){
		m_animator.SetBool("Walk", !m_animator.GetBool("Walk"));
	}  
}
}
