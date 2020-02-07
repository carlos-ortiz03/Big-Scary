using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartButton : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
