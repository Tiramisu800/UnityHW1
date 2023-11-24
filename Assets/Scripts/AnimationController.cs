using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _gameObject;

    [SerializeField] private Slider _movementSlider;

    void Update()
    {
        _animator.SetFloat("MoveState", _movementSlider.value);
    }

    /*
    public void RunIdle() 
    {
        _animator.SetFloat("MoveState", 0);
    }
    public void RunWalk()
    {
        _animator.SetFloat("MoveState", (float)0.5);
    }
    public void RunRun()
    {
        _animator.SetFloat("MoveState", 1);
    }
    */

    public void RunJump()
    {
        _animator.SetTrigger("Jump");
    }
    public void RunDance()
    {
        _animator.SetTrigger("Dance");
    }

}
