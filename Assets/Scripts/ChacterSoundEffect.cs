using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChacterSoundEffect : MonoBehaviour
{
    private AudioSource soundFX;

    [SerializeField]
    private AudioClip attack_Sound1, attack_Sound2, die_Sound;
    // Start is called before the first frame update
    void Awake()
    {
        soundFX = GetComponent<AudioSource>();
    }

    public void Attack_1()
    {
        soundFX.clip = attack_Sound1;
        soundFX.Play();
    }
    public void Attack_2()
    {
        soundFX.clip = attack_Sound2;
        soundFX.Play();
    }
    public void Die()
    {
        soundFX.clip = die_Sound;
        soundFX.Play();
    }
}
