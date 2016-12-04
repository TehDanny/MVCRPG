using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRPG.Models
{
    public static class GlobalVariables
    {
        public static List<Models.Character> Characters { get; set; } = new List<Character>();
    }
}