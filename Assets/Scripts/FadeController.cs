using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeController : MonoBehaviour
{
    [SerializeField]
    private GameObject fadePanel, textPanel;

    [SerializeField]
    private Animator fadePanelAnim, textPanelAnim;

    public void FadeIn()
    {
        fadePanel.SetActive(true);
        fadePanelAnim.Play("FadeBlackIn");
        StartCoroutine(fadeTextIn());
    }

    IEnumerator fadeTextIn(){
        yield return new WaitForSeconds(2f);
        textPanel.SetActive(true);
        textPanelAnim.Play("FadeTextIn");
    }

    public void FadeOut()
    {
        StartCoroutine(FadePanelOut());
    }

    IEnumerator FadePanelOut()
    {
        fadePanelAnim.Play("FadeBlackOut");
        yield return new WaitForSeconds(1f);
        
        fadePanel.SetActive(false);
        textPanel.SetActive(false);
    }
}
