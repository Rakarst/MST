using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Cors;
namespace TodoApi.Controllers;

[ApiController]
[EnableCors]
[Route("[controller]")]
[Produces("application/json")]
public class SexualiteController : ControllerBase
{
    Dictionary<int, List<Question>> sexualite = new Dictionary<int, List<Question>>(){
        { 1 , new List<Question>(){
            new Question(){
                QuestionID = 1,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "PRATIQUES ET USAGES"
                },
                Enonce = "Un piercing situé en haut de la rencontre des deux grandes lèvres vaginales est appelé :",
                Reponse = new List<string>(){
                    "Médusa",
                    "Christina",
                    "Alberta",
                },
                Explication =@"Ce piercing situé au niveau de la rencontre des deux grandes lèvres vaginales, en haut, s'appelle un Christina.",
                Solution = 2
            },
            new Question(){
                QuestionID = 2,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "PRATIQUES ET USAGES"
                },
                Enonce = "Ca veut dire quoi BDSM",
                Reponse = new List<string>(){
                    "Bondage - Domination - Soumission/Sadisme - Masochsime",
                    "Banane - Dinausore - Salive - Marrant",
                    
                },
                Explication =@"Le plus souvent, ce terme désigne des pratiques sexuelles utilisant la douleur,la contraite, l'humiliation érotique ou la mise en scène de certains type de fantasmes.Généralement toutes les pratiques qui mettent en place une logique dominant/dominé sont concernées",
                Solution = 2
            },
            new Question(){
                QuestionID = 3,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "PRATIQUES ET USAGES"
                },
                Enonce = "On peut faire l'amour sans pénétration",
                Reponse = new List<string>(){
                    "Vrai",
                    "Faux",  
                },
                Explication =@"En matière de sexe,tant qu'il y a consentement des partenaires, il n'y a pas de protocole à suivre à la lettre.Le rapport sexuel n'implique pas nécessairement de pénétration.Tu peux très bien prendre ton pieds avec des caresses,des baisers,des frottements,en te masturbant,ect.",
                Solution = 1
            },
            
        }},
        { 2 , new List<Question>(){
            new Question(){
                QuestionID = 1,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "PRENDRE SOIN DE SA SEXUALITE"
                },
                Enonce = "C'est une mauvaise idée de se brosser les dents avant une fellation ?",
                Reponse = new List<string>(){
                    "Vrai",
                    "Faux",
                },
                Explication="Se laver les dents avant et après un rapport buccal(fellation,anulingus,cunnilingus) n'est pas recommandé car les gencives peuvent être abimées par le brossage. La brosse à dents peut provoquer des microlésions et des saignements qui peuvent facovriser le risque de transmettre ou d'attraper une IST. Mieux vaut se rincer la bouche à l'eau.",
                Solution = 1
            },
            new Question(){
                QuestionID = 2,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "PRENDRE SOIN DE SA SEXUALITE"
                },
                Enonce = "Suis-je obligé d'avoir une sexualité épanouie ?",
                Reponse = new List<string>(){
                    "Oui",
                    "Non",
                },
                Explication="La vie sexuelle peut être un espace de désir, de plaisir, et d'épanouissement. Néanmoins, vous pouvez également vous retrouver confrontée à des expèriences décevantes,insatisfaisantes,ou tout simplement oubliables",
                Solution = 1
            },
            new Question(){
                QuestionID =3,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "PRENDRE SOIN DE SA SEXUALITE"
                },
                Enonce = "Mon copain me met la pression pour essayer la sodomie. Est-ce que je doit accepter pour sauver mon couple ?",
                Reponse = new List<string>(){
                    "Oui",
                    "Non",
                },
                Explication="Vous avez le droit de ne pas vouloir faire quelque-chose, quelle que soit la pratique,dans votre sexualité.Si votre partenaire ne parvient pas à entendre cela, c'est à lui/elle de réfléchir à son attitude... pas à vous.",
                Solution = 2
            }
        }},
        { 3 , new List<Question>(){
            new Question(){
                QuestionID = 1,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "DISCRIMINATIONS ET VIOLENCES"
                },
                Enonce = "C'est quoi le point du mari ?",
                Reponse = new List<string>(){
                    "Une Violence obstétricale",
                    "Une femme appelé marie",
                    "Un mari appelé point",
                },
                Explication="Le point du mari est une pratique obstétricale consistant à recoudre, à la suite de l'accouchement, une déchirure du périnée ou une épisiotomie par un ou des points de suture supplémentaires et inutiles. L'objectif : réduire la taille de l'entrée du vagin afin d'accroître supposément le plaisir masculin à la pénétration, lors du rapport sexuel.",
                Solution = 1
            },
             new Question(){
                QuestionID = 2,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "DISCRIMINATIONS ET VIOLENCES"
                },
                Enonce = "C'est normal l'homosexualité ?",
                Reponse = new List<string>(){
                    "Oui",
                    "Non",
                },
                Explication="C'est tout à fait normal ! L’homosexualité désigne une attirance sexuelle pour une personne du même sexe. Ainsi, une personne pourra parler d’attirance homosexuelle si elle se sent attirée par d’autres personnes du même sexe. Si elle est attirée par le sexe opposé, on parlera en revanche d’hétérosexualité.",
                Solution = 1
            }
        }},
    };


    [HttpGet("{ThemeID}")]
    public Question getQuestion(int ThemeID)
    {
        List<Question> AllQuestionFromThemeID = new List<Question>();
        if (sexualite.TryGetValue(ThemeID, out AllQuestionFromThemeID))
        {
            var random = new Random();
            int index = random.Next(AllQuestionFromThemeID.Count);
            return AllQuestionFromThemeID[index];
        }
        else
        {
            return null;
        }
    }
    [HttpGet("{ThemeID}/{QuestionID}/{ReponseID}")]
    public bool checkQuestion(int ThemeID, int QuestionID, int ReponseID)
    {
        List<Question> AllQuestionFromThemeID = new List<Question>();
        if (sexualite.TryGetValue(ThemeID, out AllQuestionFromThemeID))
        {
            Question UniqueQuestion = AllQuestionFromThemeID.Find(x => x.QuestionID == QuestionID);
            return UniqueQuestion.Solution == ReponseID ? true : false;
        }
        else
        {
            return false;
        }
    }
}

