﻿using System.ComponentModel.DataAnnotations;

namespace PanelAdmin.Models
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}