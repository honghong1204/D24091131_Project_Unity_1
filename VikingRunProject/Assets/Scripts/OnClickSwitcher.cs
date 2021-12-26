using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class OnClickSwitcher : MonoBehaviour, IPointerClickHandler
{
    public int SceneToSwitchTo;
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(SceneToSwitchTo);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
