using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Track
{

  public string name;

  public AudioClip clip;

  [Range(0f, 1f)]
  public float volume = 1;
  [Range(.1f, 3f)]
  public float pitch = 1;

  [HideInInspector]
  public AudioSource source;
}