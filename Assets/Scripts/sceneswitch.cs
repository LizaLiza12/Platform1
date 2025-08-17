using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswitch : MonoBehaviour
{
    [SerializeField] private GameObject VictoryUI;

    private void Start()
    {
        VictoryUI.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("finish1"))
        {
            StartCoroutine(Waitloadlastscene(2));
        }
        if (collision.CompareTag("finish2"))
        {
            StartCoroutine(Waitloadlastscene(3));
        }
        if (collision.CompareTag("finish3"))
            VictoryUI.SetActive(true);
    }
    private void ScaneController(int LoadScene)
    {
        SceneManager.LoadScene(LoadScene);
    }
    public void Startmenu()
    {
        ScaneController(0);
    }
    public void NextLevel()
    {
        var index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index + 1);
    }
    public void RestartLevel()
    {
        var index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
    private IEnumerator Waitloadlastscene(int indexscen)
    {
        yield return new WaitForSeconds(2f);
        ScaneController(indexscen);
    }
}
   
