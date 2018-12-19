using UnityEngine;

public class Gunshot : MonoBehaviour
{
    private float destroyTime;

    void Start()
    {
        var sound = this.GetComponent<AudioSource>();
        destroyTime = sound.clip.length;
    }
}