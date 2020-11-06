using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [System.Obsolete]
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "ground")
        {
            StartCoroutine(Restart());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    private IEnumerator Restart()
    {

        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

        
    }
}
