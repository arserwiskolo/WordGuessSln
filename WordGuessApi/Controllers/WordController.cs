using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WordGuess;
using WordGuess.Models;
using WordGuess.Storage;

namespace WordGuessWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordController : ControllerBase
    {
        // Private data member 
        private WordGuessSystem _library;

        public WordController(WordGuessSystem library)
        {
            //var wordStorage = new wordStorageList();
            //var playerStorage = new playerStorageList();
            _library = library;//new WordGuessSystem(wordStorage, playerStorage);
        }

        // Return all books at the library
        [HttpGet]
        public List<Word> GetAllWords()
        {
            List<Word> results = _library.GetAllWords();
            return results;
        }

        [HttpPost]
        public string PopulateLetter(Word newWord) 
        {
            _library.AddNewWord(newWord);
            return "Word added";
        }

    }
}
