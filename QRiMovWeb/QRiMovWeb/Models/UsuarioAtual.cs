﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QRiMovWeb.Models
{
    public class UsuarioAtual
    {
        public static string user { get; set; }


        public static string getUser()
        {
            return "";
        }
    }
}
