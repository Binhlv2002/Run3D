using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStart : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;
    public AudioSource ready;
    public AudioSource go;
    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        ready.Play();
        countDown3.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown3.SetActive(false);
        ready.Play();
        countDown2.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown2.SetActive(false);
        ready.Play();
        countDown1.SetActive(true);
        yield return new WaitForSeconds(1);
        countDown1.SetActive(false);
        ready.Play();
        countDownGo.SetActive(true);
        go.Play();
        yield return new WaitForSeconds(1);
        countDownGo.SetActive(false);
        PlayerMove.canMove = true;

    }
}
