using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Cors;
namespace TodoApi.Controllers;

[ApiController]
[EnableCors]
[Route("[controller]")]
[Produces("application/json")]
public class SanteController : ControllerBase
{
    Dictionary<int, List<Question>> sante = new Dictionary<int, List<Question>>(){
        { 1 , new List<Question>(){
            new Question(){
                QuestionID = 1,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "Question Réponse"
                },
                Enonce = "MST : QU'EST CE QUE ÇA VEUT DIRE?",
                Reponse = new List<string>(){
                    "Maladie Sans Traitement",
                    "Maladie Sexuellement Transmissible",
                    "Maladie Sexuelle Terrible",
                    "Maladie Sexuelle Traitable"
                },
                Explication =@"Les Maladies Sexuellement
                                Transmissibles (MST) peuvent
                                être provoquées par :
                                ‣ Un virus
                                ‣ Une bactérie
                                ‣ Un parasite
                                ‣ Un champignon
                                Leurs transmissions ont lieu
                                principalement lors de
                                relations sexuelles :
                                ‣ Rapport anal
                                ‣ Vaginal
                                ‣ Oro-génital",
                Solution = 2
            },
            new Question(){
                QuestionID = 2,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "Question Réponse"
                },
                Enonce = @"QUE SIGNIFIE LE SIGLE IST ?",
                Reponse = new List<string>(){
                    "INFECTION SEXUELLEMENT TRANSMISSIBLE",
                    "INSTITUT SEXUEL DE TOULOUSE",
                    "INFORMATION SCIENTIFIQUE ET TECHNIQUE",
                    "INDICE DE SIMILARITÉ TERRIENNE"
                },
                Solution = 1
            },
            new Question(){
                QuestionID = 3,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "Question Réponse"
                },
                Enonce = @"COMMENT SE PROTÉGER DES IST ?",
                Reponse = new List<string>(){
                    @"SE LAVER LE SEXE 3 FOIS PAR JOUR
(COMME POUR LES DENTS)",
                    "UTILISER UN PRÉSERVATIF",
                    "PRENDRE LA PILULE",
                    "BIEN CHOISIR SON/SA PARTENAIRE"
                },
                Solution = 2
            },
            new Question(){
                QuestionID = 4,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "Question Réponse"
                },
                Enonce = @"QUEL EST LE MEILLEUR MOYEN DE SAVOIR SI ON A UNE IST ?",
                Reponse = new List<string>(){
                    "SE RENSEIGNER SUR DES FORUMS ET SITES INTERNET",
                    "SE FAIRE DÉPISTER",
                    "REGARDER SON SEXE",
                    "ACHETER UN TEST EN PHARMACIE"
                },
                Solution = 2
            },
            new Question(){
                QuestionID = 5,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "Question Réponse"
                },
                Enonce = @"QUELLE EST L’IST LA PLUS FRÉQUENTE CHEZ LES JEUNES ?",
                Reponse = new List<string>(){
                    "HÉPATITE B",
                    "CHLAMYDIAE",
                    "VIH",
                    "HERPÈS GÉNITAL"
                },
                Solution = 2
            },
            new Question(){
                QuestionID = 6,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "Question Réponse"
                },
                Enonce = @"LE RISQUE DE TRANSMISSION D'UNE IST EN PRATIQUANT UNE FELLATION EST ",
                Reponse = new List<string>(){
                    "FAIBLE",
                    "MOYEN",
                    "ELEVÉ",
                    "TRÈS ÉLEVÉ"
                },
                Solution = 4
            },
            new Question(){
                QuestionID = 7,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "Question Réponse"
                },
                Enonce = @"LCOMMENT ATTRAPE-T-ON UNE IST ?",
                Reponse = new List<string>(){
                    "EN PORTANT UN MÊME VÊTEMENT 2 JOURS DE SUITE",
                    "LORS DE RAPPORTS SEXUELS NON PROTÉGÉS",
                    "SI ON SE FAIT PIQUER PAR UN MOUSTIQUE",
                    "EN MANGEANT UN YAOURT 1 JOUR APRÈS SA DATE LIMITE"
                },
                Solution = 2
            },
            new Question(){
                QuestionID = 8,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "Question Réponse"
                },
                Enonce = @"ON NE PEUT PAS ÊTRE CONTAMINÉ(E) PAR LE VIH SI :",
                Reponse = new List<string>(){
                    "VOTRE PARTENAIRE UTILISE UN PRÉSERVATIF LORS D’UN RAPPORT SEXUEL",
                    "VOTRE PARTENAIRE PRATIQUE SEULEMENT LA SODOMIE SANS PRÉSERVATIF",
                    "VOTRE PARTENAIRE SE RETIRE AVANT D’ÉJACULER",
                    "VOTRE PARTENAIRE SE NETTOIE LE SEXE AVANT UN RAPPORT SEXUEL"
                },
                Solution = 2
            },
        }},
        { 2 , new List<Question>(){
            new Question(){
                QuestionID = 1,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "CONNAITRE SON CORPS"
                },
                Enonce = "Le cyprine c'est : ",
                Reponse = new List<string>(){
                    "Une fleur exotique",
                    "Un lubrifiant naturel",
                    "Une pillule contraceptive",
                    "Je ne sais pas",
                },
                Explication="La « mouille » que l’on appelle plus scientifiquement « cyprine » est le lubrifiant naturel du vagin qui facilite la pénétration lors d’un rapport sexuel. Les glandes de Bartholin, situées de chaque côté de la vulve, sécrètent la cyprine.",
                Solution = 2
            },
            new Question(){
                QuestionID = 2,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "CONNAITRE SON CORPS"
                },
                Enonce = "L'hymen c'est : ",
                Reponse = new List<string>(){
                    "Une chanson",
                    "Un félin",
                    "Une membrane",
                    "Je ne sais pas",
                },
                Explication = "L’hymen est une petite membrane de peau de forme et d’épaisseur variables qui ferme partiellement, le vagin. Cette membrane s'assouplit et s'ouvre davantage lors des premiers rapports sexuels.",
                Solution = 3
            },
            new Question(){
                QuestionID = 3,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "CONNAITRE SON CORPS"
                },
                Enonce = "Où se trouve le col de l'utérus",
                Reponse = new List<string>(){
                    "Dans le cerveau",
                    "Dans les Alpes",
                    "Au fond du vagin",
                    "Je ne sais pas",
                },
                Explication = @"Le col de l’utérus est un sas d’entrée qui se trouve au fond du vagin, comme une porte d'entrée de l'utérus.

L’ouverture du col est grande comme une tête d’épingle, et sans carton d’invitation pas facile d’entrer.",
                Solution = 3
            },
            new Question(){
                QuestionID = 4,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "CONNAITRE SON CORPS"
                },
                Enonce = "A quoi servent les règles ?",
                Reponse = new List<string>(){
                    "Dans le cerveau",
                    "Dans les Alpes",
                    "Au fond du vagin",
                    "Je ne sais pas",
                },
                Explication = @"Chaque mois à partir de la puberté, l’utérus se prépare à accueillir un œuf fécondé. Pour cela, la paroi interne de l’utérus (la muqueuse) s’épaissit.

A la fin de chaque cycle, si la fécondation n’a pas eu lieu, la partie superficielle de la muqueuse (appelée endomètre) est évacuée : c’est ce qu’on appelle les règles.",
                Solution = 3
            },
            new Question(){
                QuestionID = 5,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "CONNAITRE SON CORPS"
                },
                Enonce = "Une couronne perlée c’est :",
                Reponse = new List<string>(){
                    "Une brioche au sucre",
                    "Des petites excroissances cutanées blanches sur la couronne du pénis",
                    "Une plante aquatique",
                    "Une Infection Sexuellement Transmissible (IST)",
                },
                Explication = @"C’est une petite fantaisie complètement naturelle, normale et indolore, à ne pas confondre avec les condylomes ou une mycose. Ce n’est pas une infection sexuellement transmissible (IST) mais un phénomène physiologique normal.",
                Solution = 2
            },
            new Question(){
                QuestionID = 6,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "CONNAITRE SON CORPS"
                },
                Enonce = "Devant un pénis courbé que faire ?",
                Reponse = new List<string>(){
                    "Appeler direct le chirurgien",
                    "Se dire que chaque corps est différent, c'est ce qui donne du charme",
                    "Acheter un tuyau pour le remettre dans le droit chemin",
                    "Renoncer à avoir des rapports sexuels",
                },
                Explication = @"La majorité des hommes n’a pas un pénis droit. Vers le haut, vers le bas, vers la droite ou la gauche, lorsque la courbure ne cause pas de problèmes dans les relations sexuelles, aucun traitement n’est nécessaire, avoir un pénis courbé est en fait normal.",
                Solution = 3
            },
            new Question(){
                QuestionID = 7,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "CONNAITRE SON CORPS"
                },
                Enonce = "Le sperme contient :",
                Reponse = new List<string>(){
                    "Parfois des virus dont il faut se protéger",
                    "Des protéines en très grande quantité",
                    "De la vitamine C",
                },
                Explication = @"Attention, en effet si on a attrapé un virus, certains de ces virus (comme l’hépatite B par exemple) peuvent être présents dans le sperme et donc se transmettre lors des relations sexuelles. On parle alors d’IST.",
                Solution = 1
            },
            
        }},
        { 3 , new List<Question>(){
            new Question(){
                QuestionID = 1,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "LES TROUBLES DU CORPS"
                },
                Enonce = "L’ENDOMÉTRIOSE, C’EST QUOI ?",
                Reponse = new List<string>(){
                    "Un match de football",
                    "Un marathon",
                    "Une fleur",
                    "Une maladie chronique",
                },
                Explication="L’endométriose est une maladie chronique qui touche environ 10% des femmes. L’endométriose correspond à la présence de fragments de muqueuse utérine (endomètre) en dehors de l’utérus. C’est une maladie chronique dite « œstrogèno-dépendante », car ces fragments d’endomètre présentent les mêmes caractéristiques que la muqueuse de l’utérus, et sont donc sensibles à la variation hormonale, particulièrement celle des œstrogènes.",
                Solution = 4
            },
            new Question(){
                QuestionID = 2,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "CONNAITRE SON CORPS"
                },
                Enonce = "Les éjaculations précoces c’est :",
                Reponse = new List<string>(){
                    "Ejaculer quand on a un QI de 120",
                    "Ejaculer trop rapidement pour être satisfait",
                    "Ne pas éjaculer quand on se masturbe",
                },
                Explication = @"On parle d’éjaculation précoce ou prématurée quand l’éjaculation survient trop vite chez le garçon lors d’un rapport sexuel. Il n’y a pas de durée précise pour parler d’éjaculation prématurée, on en parle quand elle laisse la personne insatisfaite avec la sensation qu’elle n’a aucun contrôle.",
                Solution = 2
            },
            new Question(){
                QuestionID = 3,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "CONNAITRE SON CORPS"
                },
                Enonce = "LE VAGINISME, C’EST QUOI ?",
                Reponse = new List<string>(){
                    "Une personne de petite taille",
                    "Une voiture de sport",
                    "Une contraction musculaire prolongée",
                    "Une marque de café",

                },
                Explication = @"Le vaginisme est une contraction musculaire prolongée ou récurrente des muscles qui entourent l’ouverture du vagin. Cette contraction empêche partiellement ou totalement les pénétrations. Parfois, lorsque le vaginisme est total, il empêche même la pénétration d’un doigt ou d’un tampon. Plus rarement, c’est juste les pénétrations d’un pénis/jouet sexuel qui sont empêchées.",
                Solution = 3
            },
            new Question(){
                QuestionID = 4,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "CONNAITRE SON CORPS"
                },
                Enonce = "LE VAGINOSES , C’EST QUOI ?",
                Reponse = new List<string>(){
                    "Une inflammations",
                    "Un nez d'ogre",
                    "Une télé",
                    "Un vagin",
                },
                Explication = @"Il s'agit d'une infection du vagin qui n'est pas due à des levures, mais à des bactéries. Elle se développe lorsque la microflore du vagin est perturbée.",
                Solution = 1
            },

            
        }},
        { 4 , new List<Question>(){
            new Question(){
                QuestionID = 1,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "PREVENTION"
                },
                Enonce = "C’EST QUOI UN PRÉSERVATIF ?",
                Reponse = new List<string>(){
                    "Un moyen de contraception",
                    "Une montagne",
                    "Un poème",
                    "Une brise d'été",
                },
                Explication="Un préservatif est un étui plus ou moins fin, communément fait de latex ou de polyuréthane. Le plus connu est le préservatif dit « masculin » qui se place sur le pénis, mais il existe également un préservatif dit « féminin » qui se place à l’intérieur du vagin avant le rapport sexuel. Il permet à la femme de choisir elle-même de se protéger et peut se mettre en place jusqu’à 8h avant le rapport sexuel.",
                Solution = 1
            },
            new Question(){
                QuestionID = 2,
                QuestionType = new QuestionType(){
                    QuestionTypeID = 0,
                    Theme = "PREVENTION"
                },
                Enonce = "QU’EST-CE QUE LA PREP ?",
                Reponse = new List<string>(){
                    "Un mode de prévention du VIH",
                    "Une formation",
                    "Un chat",
                    "Une louche",
                },
                Explication="La PrEP, ou Prophylaxie Pré-Exposition, est un mode de prévention du VIH. Il s’agit de la prise d’un traitement anti-VIH à titre préventif, de manière continue ou discontinue.La PrEP s’adresse aux personnes qui ne sont pas déjà porteuses du virus, ayant des difficultés à se protéger ou exposées à des risques de transmission, et appartenant à un groupe vulnérable au VIH.",
                Solution = 1
            },
        }},

    };

    [HttpGet("{ThemeID}")]
    public Question getQuestion(int ThemeID)
    {
        List<Question> AllQuestionFromThemeID = new List<Question>();
        if(sante.TryGetValue(ThemeID,out AllQuestionFromThemeID)){
            var random = new Random();
            int index = random.Next(AllQuestionFromThemeID.Count);
            Question ToReturn = AllQuestionFromThemeID[index];
            ToReturn.Solution = -1;
            ToReturn.Explication ="";  
            return ToReturn;
        }else{
            return null;
        }
    }
    [HttpGet("{ThemeID}/{QuestionID}/{ReponseID}")]
    public Tuple<long,string> checkQuestion(int ThemeID,int QuestionID,int ReponseID)
    {
        List<Question> AllQuestionFromThemeID = new List<Question>();
        if(sante.TryGetValue(ThemeID,out AllQuestionFromThemeID)){
            Question UniqueQuestion = AllQuestionFromThemeID.Find(x=> x.QuestionID==QuestionID);
            
            return new Tuple<long, string>(UniqueQuestion.Solution,UniqueQuestion.Explication);
        }else{
            return new Tuple<long, string>(0,"");
        }
    }



}

