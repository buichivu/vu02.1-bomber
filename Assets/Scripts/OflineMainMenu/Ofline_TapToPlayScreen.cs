using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ofline_TapToPlayScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickScreen()
    {
        if (!this.isClick)
        {
            Offline_Context.Waitting.ShowWaiting();
            LoadingScreenManager.LoadScene("BomberMap", true);
        }
    }
    

    private bool isClick;


}
