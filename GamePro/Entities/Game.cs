﻿using GamePro.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro.Entities
{
   public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
