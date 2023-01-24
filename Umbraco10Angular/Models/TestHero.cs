﻿using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Models
{
    //OCP - SuperHero Extends CommonHero  
    public class SuperHero : CommonHero, ISuperHero
    {
        public string superPower { get; set; }
    }

}
