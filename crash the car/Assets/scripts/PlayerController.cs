using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed = 0;
    public float turnRight;
    public float horizontalInput;
    public float verticalInput;
    private Rigidbody rb;
    private int count;
    public TextMeshProUGUI countText;
    public GameObject winTextMessage;


    // Start is called before the first frame update
    void Start()
    {
       rb=GetComponent<Rigidbody>();
        count=0;
        SetCountText();
        winTextMessage.SetActive(false);
    }

    void SetCountText()
    {
        countText.text="COLLECTED ITEMS : "+count.ToString();
        if(count>=84)
        {
            winTextMessage.SetActive(true);
            SceneManager.LoadScene("win");
        }
    }



    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*Time.deltaTime*speed*verticalInput);
        transform.Rotate(Vector3.up*Time.deltaTime*turnRight*horizontalInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("collectible"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Finish"))
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene("ending");
        }
    }


}
