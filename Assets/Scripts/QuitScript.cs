using System.Collections;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
	public void Quit ()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
