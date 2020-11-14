﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Roomates.Models
{
  public  class RegisterModelForRoomate
    {
  
        public string ConfirmPassword { get; set; }
        public string Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public bool QuestionForRoomate { get; set; }
        public bool Messages { get; set; }
        public bool DoYouHaveSpace { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }


    }
}
