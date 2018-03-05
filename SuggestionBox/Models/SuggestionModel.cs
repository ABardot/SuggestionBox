using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuggestionBox.Models
{
    public class SuggestionModel
    {   //Always have an ID in Model
        [Key] //Key data annotation which creates a unique identifier  
        public int SuggestionId { get; set; }

        public string Topic { get; set; }
        public string Suggestion { get; set; } // Anytime you add a model you should always build Ctrl + Shift + b


    }
}