using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupPanelController : MonoBehaviour
{
    bool isOpen = false;
    Animator myAnimator;
    [SerializeField]
    AnimationClip openAnimation;
    [SerializeField]
    AnimationClip closeAnimation;


    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }


    void Update()
    {
        
    }

    public void OnOpenButton()
    {
        if (!isOpen)
        {
            myAnimator.SetTrigger("Open");
            isOpen = true;
        }
    }

    public void OnCloseButton()
    {
        if (isOpen)
        {
            myAnimator.SetTrigger("Close");
            isOpen = false;
        }
    }

}
