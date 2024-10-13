using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Citatos : MonoBehaviour
{
    private TMP_Text objectCitata;
    void Start()
    {
        objectCitata = gameObject.GetComponent<TextMeshPro>();
    }
    void Update()
    { 
        switch(ChatBubbleAppearance.Instance.frazesk){
            case 1:
                objectCitata.text = "Labas, mano vardas Teodoras, aš padėsiu tau išmokti saugiai elgtis su kompiuteriu.";
                break;
            case 2:
                objectCitata.text = "Čia yra mano programėlė, spustelk ant jos, kad įjungtum.";
                break;
            case 3:
                objectCitata.text = "Oho! Žiūrek, tau atėjo laiškas!";
                break;
            case 4:
                objectCitata.text = "Ei, tu gi perskaitei laišką prieš atidarydamas nuorodą?";
                break;
            case 5:
                objectCitata.text = "Tave bando apgauti! Kai laiškas yra iš nepažįstomo žmogaus, visada atidžiai perskaityk jį ir įsitikink, kad jis nėra kenkėjiškas.";
                break;
            case 6:
                objectCitata.text = "Jeigu laiške daug klaidų ir jame siūlomas greitas ir paprastas darbas, tai yra apgavystė.";
                break;
            case 7:
                objectCitata.text = "Jei nesi įsitikinęs laiško saugumu, niekada neatidarinėk jame esančių nuorodų! Iš tavęs gali pavogti duomenis.";
                break;
            case 8:
                objectCitata.text = "O! Pažiūrėk čia, atėjo kažkoks pranešimas!";
                break;
            case 9:
                objectCitata.text = "Tokioje situacijoje svarbiausia nepanikuoti!";
                break;
            case 10:
                objectCitata.text = "Prisimink, NIEKADA nesiųsk jokių duomenų, ypač banko kortelės.";
                break;
            case 11:
                objectCitata.text = "Dažniausiai jie iš viso neturi tavo duomenų, jie tik meluoja, bet net jeigu duomenys buvo pavogti, tokius žmones reikia ignoruoti ir kreiptis į policiją";
                break;
        }
    }
}