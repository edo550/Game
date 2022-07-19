using UnityEngine.Audio;
using System;
using UnityEngine;

public class audioManager : MonoBehaviour
{

    public Sound[] sounds;



    // Start is called before the first frame update
    void Awake(){
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

    }

    void Start()
    {
        Play("Menu");
        Play("Game");
        Play("Bird");
        Play("Game 1");
        Play("Game2");
    }

    public void Crow()
    {
        Play("Crow");
    }
    public void Fuel()
    {
        Play("Fuel");
    }
    public void Coin()
    {
        Play("Coin");
    }
    public void Run()
    {
        Play("Run");
    }
    public void Boss()
    {
        Play("Boss");
    }
    public void TypeWriter()
    {
        Play("TypeWriter");
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }

}
