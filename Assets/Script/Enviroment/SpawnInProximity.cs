using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnInProximity : MonoBehaviour
{
    private Transform _playerMovement;
    public float distanceToPlayer;

    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = FindAnyObjectByType<PlayerMovement>().gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerMovement == null) return;
        distanceToPlayer = Vector3.Distance(_playerMovement.position, transform.position);

        if (distanceToPlayer < 4) 
        {
            StartCoroutine(FadeIn());
        } else
        {
            StartCoroutine(FadeOut());
        }
    }


    IEnumerator FadeIn()
    {
        //float elapsed = 0f;

        while (this.GetComponent<CanvasGroup>().alpha < 0.5f) 
        {
            //elapsed += Time.deltaTime;
            //this.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(0f, 0.5f, elapsed / 2f);
            this.GetComponent<CanvasGroup>().alpha += 0.01f * Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator FadeOut()
    {
        //float elapsed = 0f;

        while (this.GetComponent<CanvasGroup>().alpha > 0f)
        {
            //elapsed += Time.deltaTime;
            //this.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(0.5f, 0f, elapsed / 2f);
            this.GetComponent<CanvasGroup>().alpha -= 0.01f * Time.deltaTime;
            yield return null;
        }
    }
}
