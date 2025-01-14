using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Walk(bool walk)
    {
        anim.SetBool(AnimationsTags.WALK_PARAMETER, walk);
    }

    public void Defend(bool defend)
    {
        anim.SetBool(AnimationsTags.DEFEND_PARAMETER, defend);
    }

    public void Attack_1()
    {
        anim.SetTrigger(AnimationsTags.ATTACK_TRIGGER_1);
    }
    public void Attack_2()
    {
        anim.SetTrigger(AnimationsTags.ATTACK_TRIGGER_2);
    }

    void FreezeAnimation()
    {
        anim.speed = 0f;
    }

    public void UnFreezeAnimation()
    {
        anim.speed = 1f;
    }
}
