using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New VoiceLine", menuName = "VoiceLine/Subtitles")]
public class SubtitlesScriptable : ScriptableObject
{
    public string subtitleText;
    public AudioClip voiceLine;

}
