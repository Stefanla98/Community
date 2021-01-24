using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
    //[SerializeField]
    //private GameObject fadeController;
    private bool interactWithObject;
    private string interactWith = "";

    void Start()
    {
        interactWithObject = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (interactWithObject == true && Input.GetKeyDown(KeyCode.E))
        {
            if (
                SceneManager.GetActiveScene() ==
                SceneManager.GetSceneByName("Day1") &&
                interactWith == "Car"
            )
            {
                FindObjectOfType<FadeController>().FadeIn();

                //canvas pops up with text
                Invoke("GoToScene1", 5);
                //FindObjectOfType<FadeController>().FadeOut();
            }
            else if (
                SceneManager.GetActiveScene() ==
                SceneManager.GetSceneByName("Night1")
            )
            {
                FindObjectOfType<FadeController>().FadeIn();

                //you go to bed, dreading the next day..
                Invoke("GoToScene2", 5);
            }
            else if (
                SceneManager.GetActiveScene() ==
                SceneManager.GetSceneByName("Day2")
            )
            {
                //here we go, another day at work..
                FindObjectOfType<FadeController>().FadeIn();

                //canvas pops up with text
                Invoke("GoToScene3", 5);
            }
            else if (
                SceneManager.GetActiveScene() ==
                SceneManager.GetSceneByName("Night2")
                &&
                interactWith == "RonGarden"
            )
            {
                //you decide to help your neighbor with his garden
                FindObjectOfType<FadeController>().FadeIn();

                //canvas pops up with text
                Invoke("GoToScene4", 5);
            }
            else if (
                SceneManager.GetActiveScene() ==
                SceneManager.GetSceneByName("Night2.1")
            )
            {
                //you go to bed, thinking about what to do tomorrow
                FindObjectOfType<FadeController>().FadeIn();

                //canvas pops up with text
                Invoke("GoToScene5", 5);
            }
            else if (
                SceneManager.GetActiveScene() ==
                SceneManager.GetSceneByName("Day3")
            )
            {
                //you decide to abandon work and focus on your gardening
                FindObjectOfType<FadeController>().FadeIn();

                //canvas pops up with text
                Invoke("GoToScene6", 5);
            }
            else if (
                SceneManager.GetActiveScene() ==
                SceneManager.GetSceneByName("Night3")
            )
            {
                //you help the stranger with their car.
                FindObjectOfType<FadeController>().FadeIn();

                //canvas pops up with text
                Invoke("GoToScene7", 5);
            }
            else if (
                SceneManager.GetActiveScene() ==
                SceneManager.GetSceneByName("Night3.1")
            )
            {
                //fade to white.
                //congrats u got the good ending!s
                SceneManager.LoadScene("GameFinished");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("abc");
            interactWithObject = true;
            interactWith = gameObject.tag;
            Debug.Log(interactWith);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactWithObject = false;
            interactWith = "";
        }
    }

    void GoToScene1(){
        SceneManager.LoadScene("Night1");
    }

    void GoToScene2(){
        SceneManager.LoadScene("Day2");
    }

    void GoToScene3(){
        SceneManager.LoadScene("Night2");
    }

    void GoToScene4(){
        SceneManager.LoadScene("Night2.1");
    }

    void GoToScene5(){
        SceneManager.LoadScene("Day3");
    }

    void GoToScene6(){
        SceneManager.LoadScene("Night3");
    }

    void GoToScene7(){
        SceneManager.LoadScene("Night3.1");
    }
}
