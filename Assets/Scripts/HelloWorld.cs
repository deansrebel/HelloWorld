using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    #region Unity lifecyclen


    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Hello World! :)");
        Debug.LogWarning("Hello World! :)");
        Debug.LogError("Hello World! :)");
    }

    // Update is called once per frame
    private void Update() { }

    #endregion
}