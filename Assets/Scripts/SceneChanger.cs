using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("Scene1Guion");
    }
    public void Scene2()
    {
        SceneManager.LoadScene("Scene2VerCuadro");
    }
    public void Scene3()
    {
        SceneManager.LoadScene("Scene3EnSet");
    }
}