﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
{
  "firstname": "Roger",
  "lastname": "Moore",
  "age": 89,
  "isAlive": false,
  "adress": {
    "street": "First Street",
    "city": "London", 
    "postcode": "31-NXX"
  },
  "phoneNumbers": [
    {
      "type": "home",
      "number": "+61 222222"
    },
    {
      "type": "mobile",
      "number": "+61 333333"
    }
  ]
}*/

namespace WindowsFormsApp1
{
    public class jsonPerson
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }
    }
}
