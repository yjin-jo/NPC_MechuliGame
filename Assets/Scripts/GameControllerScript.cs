using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    public const int columns = 4;
    public const int rows = 2;

    public const float Xspace = 4f;
    public const float Yspace = -5f;

    private float time = 15;
    public GameObject re_button;// 실패 리플레이 버튼 관련 
    public GameObject failure;
    public GameObject success;
    public GameObject select;
    public GameObject blank; //성공실패화면시 터치 안되게 

    [SerializeField] private TextMesh timeText;

    [SerializeField] private MainImageScript startObject;
    //[SerializeField] private MainImageScript correctObject;
    [SerializeField] private Sprite[] images;
    //8.5 5.5
    // 0.01 1.69 -5 

    private int score = 0;
    void Update()
    {
        if ((int)time == 0)
        {
            Debug.Log("  0");
            timeText.text = "  0";
            //Debug.Log("종료");
            //timeText.text = "종료";
        }
        else
        {
            time -= Time.deltaTime;
            Debug.Log((int)time);
            if ((int)time <=9)
                timeText.text = "  " + (int)time;
            else
                timeText.text = " " + (int)time;
            //timeText.text = "Time: " + (int)time;
        }

        if (score != 1 && (int)time <= 0)// 실패관련
        {
            //blank.SetActive(true); //투명 
            re_button.SetActive(true); //리플레이 버튼 관련 
            failure.SetActive(true); //실패 버튼 관련 
        }
        else if (score ==1 && (int)time> 0) //성공 버튼 관련 , 다음 스테이지로 scene 전환 
        {
            //blank.SetActive(true); //투명
            success.SetActive(true);
            select.SetActive(true);
            //yield return new WaitForSeconds(2f);에러 
            //우선 Invoke("SecondScene", 5);
        }

    }

    public void selectToAnotherScene()
    {
        SceneManager.LoadScene("MainScene 1");
    }

    public void SecondScene()
    {   
        SceneManager.LoadScene("MainScene 1");
    }


    private int[] Randomiser(int[] locations)
    {
        int[] array = locations.Clone() as int[];
        for(int i=0; i<array.Length; i++)
        {
            int newArray = array[i];
            int j = Random.Range(i, array.Length);
            array[i] = array[j];
            array[j] = newArray;
        }
        return array;
    }
    
    private void Start()
    {
        int[] locations = { 0, 0, 1, 1, 2, 2, 3, 3 };
        locations = Randomiser(locations);

        Vector3 startPosition = startObject.transform.position;

        for(int i=0; i<columns; i++)
        {
            for(int j=0; j<rows; j++)
            {
                MainImageScript gameImage;
                if (i == 0 && j == 0)
                {
                    gameImage = startObject;
                }
                else
                {
                    gameImage = Instantiate(startObject) as MainImageScript;
                }//
                
                int index = j * columns + i;
                int id = locations[index];
                gameImage.ChangeSprite(id, images[id]);

                float positionX = (Xspace * i) + startPosition.x;
                float positionY = (Yspace * j) + startPosition.y;
              
                gameImage.transform.position = new Vector3(positionX, positionY, startPosition.z);
            }
        }
    }

    private MainImageScript firstOpen;
    private MainImageScript secondOpen;

    //private int score = 0;
    private int attempts = 0;
   

    [SerializeField] private TextMesh scoreText;
    [SerializeField] private TextMesh attemptsText;
  

    public bool canOpen
    {
        get { return secondOpen == null; }
    }

    public void imageOpened(MainImageScript startObject)
    {
        if(firstOpen == null)
        {
            firstOpen = startObject;
            StartCoroutine(CheckGuessedfir());
        }
        else
        {
            secondOpen = startObject;
            StartCoroutine(CheckGuessed());
        }
        /*if (score != 1 && (int)time <= 0)// 실패관련
        {
            re_button.SetActive(true); //리플레이 버튼 관련 
            failure.SetActive(true); //실패 버튼 관련 
        }*/


    }
    private IEnumerator CheckGuessedfir()
    {
        if (firstOpen.spriteId == 2)
        {
            //score++;
            //scoreText.text = "Score: " + score;
        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            firstOpen.Close();
            firstOpen = null;
        }

        attempts++;
        attemptsText.text = "Attempts: " + attempts;

        //firstOpen = null;
    }
    private IEnumerator CheckGuessed()
    {
        if (firstOpen.spriteId == secondOpen.spriteId)
        {
            score++;
            scoreText.text = "Score: " + score;

        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            firstOpen.Close();
            secondOpen.Close();
        }

        attempts++;
        attemptsText.text = "Attempts: " + attempts;

        firstOpen = null;
        secondOpen = null;
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }


}
