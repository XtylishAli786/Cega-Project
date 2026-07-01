using TMPro;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public TextMeshProUGUI scoreText;
    public int score = 0;
    public GameObject winPanel;
    private Animator animator;



    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0, v);

        transform.Translate(move * speed * Time.deltaTime, Space.World);

        if (move != Vector3.zero)
        {
            transform.forward = move;
        }


        if (Mathf.Abs(v) > 0.1f || Mathf.Abs(h) > 0.1f)
        {
            animator.SetBool("isRuning", true);
        }
        else
        {
            animator.SetBool("isRuning", false);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            score++;
            scoreText.text = "Score : " + score;
            Destroy(other.gameObject);
            print("Score : " + score);
        }

        if (other.CompareTag("Finish"))
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f;
            print("You Win!");
        }

       





}



    public void OnFootstep()
    {
        
    }













}


