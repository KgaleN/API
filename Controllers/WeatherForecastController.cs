using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers;

[ApiController]
[Route("controller")]
public class WeatherForecastController : ControllerBase
{
   

   
     public List<string> Words= new List<string>{"Pyrax","I","Wanna","Thank","You","...","everybody","plotting","my","demise"};

    [HttpGet]
    [Route("all")]
    public ActionResult<string> allWords()
    {     
        return wordsAll();      
    }


    [HttpGet]
    [Route("random")]
    public ActionResult<string> randomWords()
    {     
        return wordRandom();      
    }

    [HttpGet]
    [Route("sorted")]
    public ActionResult<string> sortWord()
    {     
        return wordSort();      
    }

    public string wordsAll()
    {
       var word= String.Join(", ", Words.ToArray());
       return word;
    }

    public string wordRandom()
    {
         var random = new Random();
         int index = random.Next(Words.Count);
         return  Words[index];
    }

    public string wordSort()
    {
        Words.Sort();
        string word= String.Join(", ", Words);
        return word;
    }

    
}
