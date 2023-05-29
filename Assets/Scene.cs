using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public Dropdown dTest;
    public int Index = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DropdownValue();
    }

    public void DropdownValue()
    {
        Index = dTest.GetComponent<Dropdown>().value;
    }
    public void Play()
    {
        SceneManager.LoadScene(Index+1);
        Debug.Log(Index);
    }
}
