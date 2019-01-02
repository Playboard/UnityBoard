using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject card;
    public GameObject board;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPosition = new Vector3
            (
                Random.Range(-10, 10),
                5.0f,
                Random.Range(-7, 7)
            );
            Instantiate(card, spawnPosition, Quaternion.identity);
        }
    }
}
