using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Citatos : MonoBehaviour
{
    private TMP_Text myText;
    int frazesk = 1;
    void Start()
    {
        myText = GetComponent<TMP_Text>();
    }
    void Update()
    { 
        switch(frazesk){
                case 1:
            if(Input.GetKeyDown(KeyCode.Space))
            {
                myText.text = "Labas, mano vardas Teodoras, aš padėsiu tau išmokti saugiai elgtis su kompiuteriu.";
                frazesk++;
            }
            break;
                case 2:
            if(Input.GetKeyDown(KeyCode.Space))
            {
                myText.text = "Čia yra mano programėlė, spustelk ant jos, kad įjungtum.";
                frazesk++;
            }
            break;
                case 3:
            if(Input.GetKeyDown(KeyCode.Space))
            {
                myText.text = "Oho! Žiūrek, tau atėjo laiškas!";
                frazesk++;
            }
            break;
                 case 4:
            if(Input.GetKeyDown(KeyCode.Space))
            {
                myText.text = "Ei, tu gi perskaitei laišką prieš atidarydamas nuorodą?";
                frazesk++;
            }
            break;
                case 5:
            if(Input.GetKeyDown(KeyCode.Space))
            {
                myText.text = "Tave bando apgauti! Kai laiškas yra iš nepažįstomo žmogaus, visada atidžiai perskaityk jį ir įsitikink, kad jis nėra kenkėjiškas.";
                frazesk++;
            }
            break;
                case 6:
            if(Input.GetKeyDown(KeyCode.Space))
            {
                myText.text = "Jeigu laiške daug klaidų ir jame siūlomas greitas ir paprastas darbas, tai yra apgavystė.";
                frazesk++;
            }
            break;
                case 7:
            if(Input.GetKeyDown(KeyCode.Space))
            {
                myText.text = "Jei nesi įsitikinęs laiško saugumu, niekada neatidarinėk jame esančių nuorodų! Iš tavęs gali pavogti duomenis.";
                frazesk++;
            }
            break;
                case 8:
            if(Input.GetKeyDown(KeyCode.Space))
            {
                myText.text = "O! Pažiūrėk čia, atėjo kažkoks pranešimas!";
                frazesk++;
            }
            break;
                case 9:
            if(Input.GetKeyDown(KeyCode.Space))
            {
                myText.text = "Tokioje situacijoje svarbiausia nepanikuoti!";
                frazesk++;
            }
            break;
                case 10:
            if(Input.GetKeyDown(KeyCode.Space))
            {
                myText.text = "Prisimink, NIEKADA nesiųsk jokių duomenų, ypač banko kortelės.";
                frazesk++;
            }
            break;
                case 11:
            if(Input.GetKeyDown(KeyCode.Space))
            {
                myText.text = "Dažniausiai jie iš viso neturi tavo duomenų, jie tik meluoja, bet net jeigu duomenys buvo pavogti, tokius žmones reikia ignoruoti ir kreiptis į policiją";
                frazesk++;
            }
            break;
        }
    }
}
