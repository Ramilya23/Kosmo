using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectAnimation : MonoBehaviour
{
    public Animator animator;
    public void PlayTwo()
    {
        animator.SetBool("2", true);
    }
    public void Pink()
    {
        animator.SetFloat("Pink", 0);

    }
    public void Playthree()
    {
        animator.SetTrigger("3");
    }
}
