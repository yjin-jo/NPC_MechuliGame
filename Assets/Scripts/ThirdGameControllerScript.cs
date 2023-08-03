using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ThirdGameControllerScript : MonoBehaviour
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

    [SerializeField] private ThirdMainImageScript startObject;
    //[SerializeField] private MainImageScript correctObject;
    [SerializeField] private Sprite[] images;
    //8.5 5.5
    // 0.01 1.69 -5 

    //[SerializeField] private GameObject hint_have_mongmong;
    //[SerializeField] private GameObject mongmong_house_back;
    //public GameObject obtainhintbutton;
   //public GameObject hint_blank;// 예시

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
            if ((int)time <= 9)
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
        else if (score == 1 && (int)time > 0) //성공 버튼 관련 , 다음 스테이지로 scene 전환 
        {
            //blank.SetActive(true); //투명
            success.SetActive(true);
            select.SetActive(true);
            //Invoke("ThirdScene", 5);
            //SceneManager.LoadScene("obtainhintScene");
            /*if (Input.GetKeyDown(KeyCode.Space))
            {
                mongmong_house_back.SetActive(true);
                hint_have_mongmong.SetActive(true);
                obtainhintbutton.SetActive(true); // 힌트획득 버튼 
            }*/
            //obtainhintbutton.SetActive(true);
            //obtainhintbutton.SetActive(true); // 힌트획득 버튼 
            //yield return new WaitForSeconds(2f);에러 
            //Invoke("SecondScene", 5);
        }

    }

    public void SecondScene()
    {
        SceneManager.LoadScene("MainScene");
    }


    private int[] Randomiser(int[] locations)
    {
        int[] array = locations.Clone() as int[];
        for (int i = 0; i < array.Length; i++)
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
        int[] locations = { 0, 1, 2, 2, 2, 2, 3, 3 };
        locations = Randomiser(locations);

        Vector3 startPosition = startObject.transform.position;

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                ThirdMainImageScript gameImage;
                if (i == 0 && j == 0)
                {
                    gameImage = startObject;
                }
                else
                {
                    gameImage = Instantiate(startObject) as ThirdMainImageScript;
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

    private ThirdMainImageScript firstOpen;
    private ThirdMainImageScript secondOpen;
    private ThirdMainImageScript thirdOpen;
    private ThirdMainImageScript fourOpen;

    //private int score = 0;
    private int attempts = 0;


    [SerializeField] private TextMesh scoreText;
    [SerializeField] private TextMesh attemptsText;
    

    public bool canOpen
    {
        get { return fourOpen == null; }
    }

    public void imageOpened(ThirdMainImageScript startObject)
    {
        if (firstOpen == null)
        {
            firstOpen = startObject;
            StartCoroutine(CheckGuessedfir());
        }
        else if (secondOpen == null)
        {
            secondOpen = startObject;
            StartCoroutine(CheckGuessed());
        }
        else if (thirdOpen == null)
        {
            thirdOpen = startObject;
            StartCoroutine(CheckGuessedthird());
        }
        else if (fourOpen == null)
        {
            fourOpen = startObject;
            StartCoroutine(CheckGuessedfour());
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
            //score++;
            //scoreText.text = "Score: " + score;

        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            firstOpen.Close();
            secondOpen.Close();
            firstOpen = null;
            secondOpen = null;
        }

        attempts++;
        attemptsText.text = "Attempts: " + attempts;

        //firstOpen = null;
        //secondOpen = null;
    }
    private IEnumerator CheckGuessedthird()
    {
        if (secondOpen.spriteId == thirdOpen.spriteId)
        {
            //score++;
            //scoreText.text = "Score: " + score;

        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            firstOpen.Close();
            secondOpen.Close();
            thirdOpen.Close();
            firstOpen = null;
            secondOpen = null;
            thirdOpen = null;
        }

        attempts++;
        attemptsText.text = "Attempts: " + attempts;

        //firstOpen = null;
        //secondOpen = null;
        //thirdOpen = null;
    }

    private IEnumerator CheckGuessedfour()
    {
        if (fourOpen.spriteId == thirdOpen.spriteId)
        {
            score++;
            scoreText.text = "Score: " + score;

        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            firstOpen.Close();
            secondOpen.Close();
            thirdOpen.Close();
            fourOpen.Close();
            firstOpen = null;
            secondOpen = null;
            thirdOpen = null;
            fourOpen = null;
        }

        attempts++;
        attemptsText.text = "Attempts: " + attempts;

        //firstOpen = null;
        //secondOpen = null;
        //thirdOpen = null;
    }


    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }

    /*public void have_hint()
    {
        hint_blank.SetActive(true);
    }*/
}