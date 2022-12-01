






public class Question {
    public long QuestionID { get; set; }
    public QuestionType QuestionType { get; set; }
    public string Enonce{ get; set; }

    public string Explication {get;set;}
    public List<String> Reponse{ get; set; }
    public long Solution {get;set;}

}
public class QuestionType{
    public long QuestionTypeID{ get; set; }
    public string Theme{ get; set; }
}

