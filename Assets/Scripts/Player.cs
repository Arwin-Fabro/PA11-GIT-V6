using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = new Vector3(this.transform.position.x, Mathf.Clamp(this.transform.position.y, -3.92f, 3.97f), this.transform.position.z);

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

      

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GreenCube")
        {
            Score.Points += 5;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "RedCube")
        {
            SceneManager.LoadScene("GameOver");
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "BrownCube")
        {
            Score.Points -= 2;
            Destroy(other.gameObject);
        }

    }
}
